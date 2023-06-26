using PvDotNet;
using PvGUIDotNet;
using Jai_PleoraEbusLibrary;
using PleoraEBusLibrary;
using log4net;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GOXViewer
{
    public partial class GO_X : Form
    {
        private GOX Controller;
        private log4net.ILog log = log4net.LogManager.GetLogger(typeof(GO_X));
        private System.Windows.Forms.Timer timer = new();

        public GO_X()
        {
            Controller = new GOX(log);
            InitializeComponent();

            if (!Directory.Exists("C:\\사진\\JAI_Image"))
            {
                Controller.SetWritePath("C:\\사진\\JAI_Image");
            }
            else
            {
                Controller.SetWritePath("C:\\사진\\JAI_Image", false);
            }

            FileNameTextBox.Text = "C:\\사진\\JaI_Image";
            CaptureGroup.Enabled = false;
            ParameterGroup.Enabled = false;
            AcquisitionControlButton.Enabled = false;
        }

        private void HandleLinkDisconnected(PvDevice aDevice)
        {
            BeginInvoke(DisConnectedHandler);
        }
        private void DisConnectedHandler()
        {
            MessageBox.Show("Connection to device lost.");
            DisconnectControl();
        }

        private void ConnectionControlButton_Click(object sender, EventArgs e)
        {
            ConnectionControlButton.Enabled = false;
            if (ConnectionControlButton.Text.Equals("Connect"))
            {
                if (!ConnectControl())
                {
                    ConnectionControlButton.Enabled = true;
                    return;
                }

                ConnectionControlButton.Text = "Disconnect";
                CaptureMethodListBox.DataSource = Enum.GetValues(typeof(PleoraEBusLibrary.CaptureModeEnum));

                ExposureTimeTextBox.Text = Controller.ExposureTime.Value.ToString();
                FrameRateTextBox.Text = Controller.AcquisitionFrameRate.Value.ToString();

                ParameterGroup.Enabled = true;
                AcquisitionControlButton.Enabled = true;
            }
            else
            {
                DisconnectControl();

                statusControl.Warning = "";
                ConnectionControlButton.Text = "Connect";
                ParameterGroup.Enabled = false;
                AcquisitionControlButton.Enabled = false;
            }
            ConnectionControlButton.Enabled = true;
        }
        private bool ConnectControl()
        {
            PvDeviceFinderForm Finder = new PvDeviceFinderForm();
            if (Finder.ShowDialog() == DialogResult.OK)
            {
                if (Controller.Connect(Finder.Selected) is not PleoraEBusLibrary.PvConnectResult.Ok)
                {
                    MessageBox.Show("connect fail");
                    return false;
                }
            }
            else
            {
                return false;
            }
            Controller.SetOnLinkDisconnectedEvent(HandleLinkDisconnected);
            return true;
        }
        private void DisconnectControl()
        {
            if (AcquisitionControlButton.Text.Equals("Stop"))
            {
                AcquisitionControlButton.PerformClick();
            }
            Controller.Disconnect();
        }

        private void AcquisitionControlButton_Click(object sender, EventArgs e)
        {
            AcquisitionControlButton.Enabled = false;
            if (AcquisitionControlButton.Text.Equals("Start"))
            {
                statusControl.Stream = Controller.StreamValue;
                statusControl.DisplayThread = Controller.DisplayThreadValue;

                StartAcuisitionControl();

                CaptureGroup.Enabled = true;
                AcquisitionControlButton.Text = "Stop";
            }
            else
            {
                statusControl.Stream = null;
                statusControl.DisplayThread = null;

                StopAcuisitionControl();

                CaptureGroup.Enabled = false;
                AcquisitionControlButton.Text = "Start";
            }
            AcquisitionControlButton.Enabled = true;

        }
        private void StartAcuisitionControl()
        {
            StreamDisplayDelegate streamDisplay = StreamDisplay;
            Controller.SetStreamDisplay(streamDisplay);
            Controller.StartStream();
        }
        private void StreamDisplay(PvBuffer buffer, int channel = 0)
        {
            Invoke(() =>
            {
                display.Display(buffer);
                display.Refresh();
            });
        }
        private void StopAcuisitionControl()
        {
            Controller.StopStream();
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;

            var result = dialog.ShowDialog();
            if (result is not CommonFileDialogResult.Cancel or CommonFileDialogResult.None)
            {
                if (dialog.FileName != "")
                {
                    FileNameTextBox.Text = dialog.FileName;
                    Controller.SetWritePath(dialog.FileName, false);
                }
            }
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            CaptureButton.Enabled = false;

            Controller.CaptureControl(CaptureMethodListBox.Text);

            if (CaptureMethodListBox.Text.Equals("Trigger"))
            {
                JPGControl();
            }
            else
            {
                if (CaptureButton.Text.Equals("StartCapture"))
                {
                    timer.Start();
                    CaptureButton.Text = "StopCapture";
                    CaptureTimerCheckBox.Enabled = false;
                }
                else
                {
                    timer.Stop();
                    CaptureButton.Text = "StartCapture";
                    CaptureTimerCheckBox.Enabled = true;
                }

            }
            CaptureButton.Enabled = true;
        }
        private void JPGControl()
        {
            if (JPGCaptureCheckBox.Checked)
            {
                Controller.IsJpegWrite = true;
                Controller.StartWrite(ImageNameTextBox.Text);
            }
            else
            {
                Controller.IsJpegWrite = false;
                Controller.StartWrite(ImageNameTextBox.Text);
            }
        }
        private void CaptureTimerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CaptureTimerCheckBox.Checked)
            {
                CaptureTimerTextBox.Enabled = false;
                timer.Interval = int.Parse(CaptureTimerTextBox.Text);
                timer.Tick += new EventHandler(CaptureTimerControl_Tick);
            }
            else
            {
                CaptureTimerTextBox.Enabled = true;
                timer.Tick -= new EventHandler(CaptureTimerControl_Tick);
            }
        }
        private void CaptureTimerControl_Tick(object sender, EventArgs e)
        {
            JPGControl();
        }
        private void ExposureAutoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ExposureAutoCheckBox.Checked == true)
            {
                ExposureTimeTextBox.Enabled = false;
                Controller.ExposureAuto = true;
            }
            else
            {
                Controller.ExposureAuto = false;
                ExposureTimeTextBox.Enabled = true;
            }
        }
        private void SetExposureTimeButton_Click(object sender, EventArgs e)
        {
            MaxMInValue(Controller.ExposureTime, ExposureTimeTextBox);
        }
        private void SetFrameRateButton_Click(object sender, EventArgs e)
        {
            MaxMInValue(Controller.AcquisitionFrameRate, FrameRateTextBox);
        }
        private void MaxMInValue(PvGenFloat Parameter, TextBox text)
        {
            double value = double.Parse(text.Text);

            if (text.Text is not null && Parameter.Max > value && Parameter.Min < value)
            {
                Parameter.Value = value;
            }
            else
            {
                Parameter.Value = Parameter.Max;
                text.Text = Parameter.Max.ToString();
            }
            MaxMinLabel.Text = Parameter.Name + " Max : " + Parameter.Max + " Min : " + Parameter.Min;
        }

        private void RedGainTrackBar_Scroll(object sender, EventArgs e)
        {
            Controller.RedGain = ((double)RedGainTrackBar.Value) / 1000;
            RedGainNumeric.Value = (decimal)Controller.RedGain;
        }

        private void GreenGainTrackBar_Scroll(object sender, EventArgs e)
        {
            Controller.GreenGain = ((double)GreenGainTrackBar.Value) / 1000;
            GreenGainNumeric.Value = (decimal)Controller.GreenGain;
        }

        private void BlueGainTrackBar_Scroll(object sender, EventArgs e)
        {
            Controller.BlueGain = ((double)BlueGainTrackBar.Value) / 1000;
            BlueGainNumeric.Value = (decimal)Controller.BlueGain;
        }
        private void RedGainNumeric_ValueChanged(object sender, EventArgs e)
        {
            Controller.RedGain = (double)RedGainNumeric.Value;
            RedGainTrackBar.Value = (int)Controller.RedGain * 1000;
        }

        private void GreenGainNumeric_ValueChanged(object sender, EventArgs e)
        {
            Controller.GreenGain = (double)GreenGainNumeric.Value;
            GreenGainTrackBar.Value = (int)Controller.GreenGain * 1000;
        }

        private void BlueGainNumeric_ValueChanged(object sender, EventArgs e)
        {
            Controller.BlueGain = (double)BlueGainNumeric.Value;
            BlueGainTrackBar.Value = (int)Controller.BlueGain * 1000;
        }

        private void WhiteBalanceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Controller.WhiteBalanceAuto = (bool)WhiteBalanceCheckBox.Checked;
        }

        private void GainReset_Click(object sender, EventArgs e)
        {
            Controller.RedGain = 1;
            Controller.GreenGain = 1;
            Controller.BlueGain = 1;
            RedGainNumeric.Value = 1;
            GreenGainNumeric.Value = 1;
            BlueGainNumeric.Value = 1;
            RedGainTrackBar.Value = 1000;
            GreenGainTrackBar.Value = 1000;
            BlueGainTrackBar.Value = 1000;
        }
    }
}