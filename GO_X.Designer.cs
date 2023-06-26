namespace GOXViewer
{
    partial class GO_X
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            display = new PvGUIDotNet.PvDisplayControl();
            statusControl = new PvGUIDotNet.PvStatusControl();
            ActionGroup = new GroupBox();
            ConnectionControlButton = new Button();
            AcquisitionControlButton = new Button();
            CaptureGroup = new GroupBox();
            CaptureTimerCheckBox = new CheckBox();
            label5 = new Label();
            CaptureTimerTextBox = new TextBox();
            label4 = new Label();
            JPGCaptureCheckBox = new CheckBox();
            CaptureButton = new Button();
            CaptureMethodListBox = new ListBox();
            ParameterGroup = new GroupBox();
            GainReset = new Button();
            BlueGainNumeric = new NumericUpDown();
            GreenGainNumeric = new NumericUpDown();
            RedGainNumeric = new NumericUpDown();
            label1 = new Label();
            MaxMinLabel = new Label();
            WhiteBalanceCheckBox = new CheckBox();
            BlueGainTrackBar = new TrackBar();
            GreenGainTrackBar = new TrackBar();
            label2 = new Label();
            label = new Label();
            RedGainTrackBar = new TrackBar();
            B = new Label();
            G = new Label();
            R = new Label();
            SetFrameRateButton = new Button();
            FrameRateTextBox = new TextBox();
            ExposureAutoCheckBox = new CheckBox();
            ExposureTimeTextBox = new TextBox();
            SetExposureTimeButton = new Button();
            StreamingGoup = new GroupBox();
            SaveFileButton = new Button();
            FileNameTextBox = new TextBox();
            ImageNameTextBox = new TextBox();
            ImageName = new Label();
            label3 = new Label();
            ActionGroup.SuspendLayout();
            CaptureGroup.SuspendLayout();
            ParameterGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BlueGainNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenGainNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedGainNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BlueGainTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GreenGainTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedGainTrackBar).BeginInit();
            StreamingGoup.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            display.BackColor = Color.Transparent;
            display.BackgroundColor = Color.DarkGray;
            display.BorderStyle = BorderStyle.FixedSingle;
            display.ForeColor = SystemColors.AppWorkspace;
            display.Location = new Point(8, 27);
            display.Margin = new Padding(5, 3, 5, 3);
            display.Name = "display";
            display.ROI = new Rectangle(0, 0, 0, 0);
            display.Size = new Size(736, 403);
            display.TabIndex = 0;
            display.TextOverlay = "";
            display.TextOverlayColor = Color.Lime;
            display.TextOverlayOffsetX = 10;
            display.TextOverlayOffsetY = 10;
            display.TextOverlaySize = 18;
            // 
            // statusControl
            // 
            statusControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statusControl.BuffersReallocated = false;
            statusControl.DisplayThread = null;
            statusControl.Location = new Point(8, 436);
            statusControl.Margin = new Padding(5, 3, 5, 3);
            statusControl.MinimumSize = new Size(533, 37);
            statusControl.Name = "statusControl";
            statusControl.Size = new Size(736, 66);
            statusControl.Stream = null;
            statusControl.TabIndex = 1;
            statusControl.Warning = "";
            // 
            // ActionGroup
            // 
            ActionGroup.Controls.Add(ConnectionControlButton);
            ActionGroup.Controls.Add(AcquisitionControlButton);
            ActionGroup.Location = new Point(12, 12);
            ActionGroup.Name = "ActionGroup";
            ActionGroup.Size = new Size(250, 123);
            ActionGroup.TabIndex = 0;
            ActionGroup.TabStop = false;
            ActionGroup.Text = "Action";
            // 
            // ConnectionControlButton
            // 
            ConnectionControlButton.Location = new Point(6, 31);
            ConnectionControlButton.Name = "ConnectionControlButton";
            ConnectionControlButton.Size = new Size(112, 72);
            ConnectionControlButton.TabIndex = 4;
            ConnectionControlButton.Text = "Connect";
            ConnectionControlButton.UseVisualStyleBackColor = true;
            ConnectionControlButton.Click += ConnectionControlButton_Click;
            // 
            // AcquisitionControlButton
            // 
            AcquisitionControlButton.Location = new Point(132, 31);
            AcquisitionControlButton.Name = "AcquisitionControlButton";
            AcquisitionControlButton.Size = new Size(112, 72);
            AcquisitionControlButton.TabIndex = 3;
            AcquisitionControlButton.Text = "Start";
            AcquisitionControlButton.UseVisualStyleBackColor = true;
            AcquisitionControlButton.Click += AcquisitionControlButton_Click;
            // 
            // CaptureGroup
            // 
            CaptureGroup.Controls.Add(CaptureTimerCheckBox);
            CaptureGroup.Controls.Add(label5);
            CaptureGroup.Controls.Add(CaptureTimerTextBox);
            CaptureGroup.Controls.Add(label4);
            CaptureGroup.Controls.Add(JPGCaptureCheckBox);
            CaptureGroup.Controls.Add(CaptureButton);
            CaptureGroup.Controls.Add(CaptureMethodListBox);
            CaptureGroup.Location = new Point(268, 12);
            CaptureGroup.Name = "CaptureGroup";
            CaptureGroup.Size = new Size(250, 162);
            CaptureGroup.TabIndex = 1;
            CaptureGroup.TabStop = false;
            CaptureGroup.Text = "Capture";
            // 
            // CaptureTimerCheckBox
            // 
            CaptureTimerCheckBox.AutoSize = true;
            CaptureTimerCheckBox.Location = new Point(6, 128);
            CaptureTimerCheckBox.Name = "CaptureTimerCheckBox";
            CaptureTimerCheckBox.Size = new Size(18, 17);
            CaptureTimerCheckBox.TabIndex = 11;
            CaptureTimerCheckBox.UseVisualStyleBackColor = true;
            CaptureTimerCheckBox.CheckedChanged += CaptureTimerCheckBox_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 125);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 10;
            label5.Text = "ms.";
            // 
            // CaptureTimerTextBox
            // 
            CaptureTimerTextBox.Location = new Point(140, 122);
            CaptureTimerTextBox.Name = "CaptureTimerTextBox";
            CaptureTimerTextBox.Size = new Size(76, 27);
            CaptureTimerTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 125);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 8;
            label4.Text = "Save imgr every";
            // 
            // JPGCaptureCheckBox
            // 
            JPGCaptureCheckBox.AutoSize = true;
            JPGCaptureCheckBox.Location = new Point(124, 73);
            JPGCaptureCheckBox.Name = "JPGCaptureCheckBox";
            JPGCaptureCheckBox.Size = new Size(56, 24);
            JPGCaptureCheckBox.TabIndex = 7;
            JPGCaptureCheckBox.Text = ".jpg";
            JPGCaptureCheckBox.UseVisualStyleBackColor = true;
            // 
            // CaptureButton
            // 
            CaptureButton.Location = new Point(6, 56);
            CaptureButton.Name = "CaptureButton";
            CaptureButton.Size = new Size(112, 57);
            CaptureButton.TabIndex = 5;
            CaptureButton.Text = "StartCapture";
            CaptureButton.UseVisualStyleBackColor = true;
            CaptureButton.Click += CaptureButton_Click;
            // 
            // CaptureMethodListBox
            // 
            CaptureMethodListBox.FormattingEnabled = true;
            CaptureMethodListBox.ItemHeight = 20;
            CaptureMethodListBox.Location = new Point(6, 26);
            CaptureMethodListBox.Name = "CaptureMethodListBox";
            CaptureMethodListBox.Size = new Size(238, 24);
            CaptureMethodListBox.TabIndex = 0;
            // 
            // ParameterGroup
            // 
            ParameterGroup.Controls.Add(GainReset);
            ParameterGroup.Controls.Add(BlueGainNumeric);
            ParameterGroup.Controls.Add(GreenGainNumeric);
            ParameterGroup.Controls.Add(RedGainNumeric);
            ParameterGroup.Controls.Add(label1);
            ParameterGroup.Controls.Add(MaxMinLabel);
            ParameterGroup.Controls.Add(WhiteBalanceCheckBox);
            ParameterGroup.Controls.Add(BlueGainTrackBar);
            ParameterGroup.Controls.Add(GreenGainTrackBar);
            ParameterGroup.Controls.Add(label2);
            ParameterGroup.Controls.Add(label);
            ParameterGroup.Controls.Add(RedGainTrackBar);
            ParameterGroup.Controls.Add(B);
            ParameterGroup.Controls.Add(G);
            ParameterGroup.Controls.Add(R);
            ParameterGroup.Controls.Add(SetFrameRateButton);
            ParameterGroup.Controls.Add(FrameRateTextBox);
            ParameterGroup.Controls.Add(ExposureAutoCheckBox);
            ParameterGroup.Controls.Add(ExposureTimeTextBox);
            ParameterGroup.Controls.Add(SetExposureTimeButton);
            ParameterGroup.Location = new Point(12, 213);
            ParameterGroup.Name = "ParameterGroup";
            ParameterGroup.Size = new Size(506, 309);
            ParameterGroup.TabIndex = 2;
            ParameterGroup.TabStop = false;
            ParameterGroup.Text = "Parameter";
            // 
            // GainReset
            // 
            GainReset.Location = new Point(39, 262);
            GainReset.Name = "GainReset";
            GainReset.Size = new Size(120, 30);
            GainReset.TabIndex = 35;
            GainReset.Text = "Reset";
            GainReset.UseVisualStyleBackColor = true;
            GainReset.Click += GainReset_Click;
            // 
            // BlueGainNumeric
            // 
            BlueGainNumeric.DecimalPlaces = 3;
            BlueGainNumeric.Location = new Point(37, 224);
            BlueGainNumeric.Name = "BlueGainNumeric";
            BlueGainNumeric.Size = new Size(122, 27);
            BlueGainNumeric.TabIndex = 34;
            BlueGainNumeric.TextAlign = HorizontalAlignment.Right;
            BlueGainNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            BlueGainNumeric.ValueChanged += BlueGainNumeric_ValueChanged;
            // 
            // GreenGainNumeric
            // 
            GreenGainNumeric.DecimalPlaces = 3;
            GreenGainNumeric.Location = new Point(37, 191);
            GreenGainNumeric.Name = "GreenGainNumeric";
            GreenGainNumeric.Size = new Size(122, 27);
            GreenGainNumeric.TabIndex = 33;
            GreenGainNumeric.TextAlign = HorizontalAlignment.Right;
            GreenGainNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            GreenGainNumeric.ValueChanged += GreenGainNumeric_ValueChanged;
            // 
            // RedGainNumeric
            // 
            RedGainNumeric.DecimalPlaces = 3;
            RedGainNumeric.ImeMode = ImeMode.On;
            RedGainNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            RedGainNumeric.InterceptArrowKeys = false;
            RedGainNumeric.Location = new Point(37, 155);
            RedGainNumeric.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            RedGainNumeric.Name = "RedGainNumeric";
            RedGainNumeric.Size = new Size(122, 27);
            RedGainNumeric.TabIndex = 32;
            RedGainNumeric.TextAlign = HorizontalAlignment.Right;
            RedGainNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            RedGainNumeric.ValueChanged += RedGainNumeric_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 122);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 31;
            label1.Text = "Gain";
            // 
            // MaxMinLabel
            // 
            MaxMinLabel.AutoSize = true;
            MaxMinLabel.Location = new Point(13, 90);
            MaxMinLabel.Name = "MaxMinLabel";
            MaxMinLabel.Size = new Size(91, 20);
            MaxMinLabel.TabIndex = 26;
            MaxMinLabel.Text = "Max : MIn : ";
            // 
            // WhiteBalanceCheckBox
            // 
            WhiteBalanceCheckBox.AutoSize = true;
            WhiteBalanceCheckBox.Location = new Point(376, 62);
            WhiteBalanceCheckBox.Name = "WhiteBalanceCheckBox";
            WhiteBalanceCheckBox.Size = new Size(124, 24);
            WhiteBalanceCheckBox.TabIndex = 25;
            WhiteBalanceCheckBox.Text = "WhiteBalance";
            WhiteBalanceCheckBox.UseVisualStyleBackColor = true;
            WhiteBalanceCheckBox.CheckedChanged += WhiteBalanceCheckBox_CheckedChanged;
            // 
            // BlueGainTrackBar
            // 
            BlueGainTrackBar.Location = new Point(157, 221);
            BlueGainTrackBar.Maximum = 16000;
            BlueGainTrackBar.Name = "BlueGainTrackBar";
            BlueGainTrackBar.Size = new Size(343, 56);
            BlueGainTrackBar.TabIndex = 20;
            BlueGainTrackBar.TickFrequency = 16000;
            BlueGainTrackBar.Value = 1000;
            BlueGainTrackBar.Scroll += BlueGainTrackBar_Scroll;
            // 
            // GreenGainTrackBar
            // 
            GreenGainTrackBar.Location = new Point(157, 190);
            GreenGainTrackBar.Maximum = 16000;
            GreenGainTrackBar.Name = "GreenGainTrackBar";
            GreenGainTrackBar.Size = new Size(343, 56);
            GreenGainTrackBar.TabIndex = 20;
            GreenGainTrackBar.TickFrequency = 16000;
            GreenGainTrackBar.Value = 1000;
            GreenGainTrackBar.Scroll += GreenGainTrackBar_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 62);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 18;
            label2.Text = "FrameRate";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(13, 35);
            label.Name = "label";
            label.Size = new Size(103, 20);
            label.TabIndex = 11;
            label.Text = "ExposureTime";
            // 
            // RedGainTrackBar
            // 
            RedGainTrackBar.Location = new Point(157, 157);
            RedGainTrackBar.Maximum = 16000;
            RedGainTrackBar.Name = "RedGainTrackBar";
            RedGainTrackBar.Size = new Size(343, 56);
            RedGainTrackBar.TabIndex = 20;
            RedGainTrackBar.TickFrequency = 16000;
            RedGainTrackBar.Value = 1000;
            RedGainTrackBar.Scroll += RedGainTrackBar_Scroll;
            // 
            // B
            // 
            B.AutoSize = true;
            B.Location = new Point(15, 226);
            B.Name = "B";
            B.Size = new Size(18, 20);
            B.TabIndex = 16;
            B.Text = "B";
            // 
            // G
            // 
            G.AutoSize = true;
            G.Location = new Point(13, 193);
            G.Name = "G";
            G.Size = new Size(20, 20);
            G.TabIndex = 15;
            G.Text = "G";
            // 
            // R
            // 
            R.AutoSize = true;
            R.Location = new Point(15, 157);
            R.Name = "R";
            R.Size = new Size(18, 20);
            R.TabIndex = 14;
            R.Text = "R";
            // 
            // SetFrameRateButton
            // 
            SetFrameRateButton.Location = new Point(242, 60);
            SetFrameRateButton.Name = "SetFrameRateButton";
            SetFrameRateButton.Size = new Size(52, 24);
            SetFrameRateButton.TabIndex = 10;
            SetFrameRateButton.Text = "Set";
            SetFrameRateButton.UseVisualStyleBackColor = true;
            SetFrameRateButton.Click += SetFrameRateButton_Click;
            // 
            // FrameRateTextBox
            // 
            FrameRateTextBox.Location = new Point(124, 59);
            FrameRateTextBox.Name = "FrameRateTextBox";
            FrameRateTextBox.Size = new Size(112, 27);
            FrameRateTextBox.TabIndex = 9;
            // 
            // ExposureAutoCheckBox
            // 
            ExposureAutoCheckBox.AutoSize = true;
            ExposureAutoCheckBox.Location = new Point(375, 28);
            ExposureAutoCheckBox.Name = "ExposureAutoCheckBox";
            ExposureAutoCheckBox.Size = new Size(125, 24);
            ExposureAutoCheckBox.TabIndex = 8;
            ExposureAutoCheckBox.Text = "ExposureAuto";
            ExposureAutoCheckBox.UseVisualStyleBackColor = true;
            ExposureAutoCheckBox.CheckedChanged += ExposureAutoCheckBox_CheckedChanged;
            // 
            // ExposureTimeTextBox
            // 
            ExposureTimeTextBox.Location = new Point(124, 28);
            ExposureTimeTextBox.Name = "ExposureTimeTextBox";
            ExposureTimeTextBox.Size = new Size(112, 27);
            ExposureTimeTextBox.TabIndex = 8;
            // 
            // SetExposureTimeButton
            // 
            SetExposureTimeButton.Location = new Point(242, 29);
            SetExposureTimeButton.Name = "SetExposureTimeButton";
            SetExposureTimeButton.Size = new Size(52, 24);
            SetExposureTimeButton.TabIndex = 8;
            SetExposureTimeButton.Text = "Set";
            SetExposureTimeButton.UseVisualStyleBackColor = true;
            SetExposureTimeButton.Click += SetExposureTimeButton_Click;
            // 
            // StreamingGoup
            // 
            StreamingGoup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StreamingGoup.Controls.Add(display);
            StreamingGoup.Controls.Add(statusControl);
            StreamingGoup.Location = new Point(524, 12);
            StreamingGoup.Name = "StreamingGoup";
            StreamingGoup.Size = new Size(752, 508);
            StreamingGoup.TabIndex = 2;
            StreamingGoup.TabStop = false;
            StreamingGoup.Text = "Streaming";
            // 
            // SaveFileButton
            // 
            SaveFileButton.Location = new Point(18, 180);
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(112, 27);
            SaveFileButton.TabIndex = 5;
            SaveFileButton.Text = "저장경로설정";
            SaveFileButton.UseVisualStyleBackColor = true;
            SaveFileButton.Click += SaveFileButton_Click;
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.Location = new Point(136, 180);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new Size(376, 27);
            FileNameTextBox.TabIndex = 8;
            // 
            // ImageNameTextBox
            // 
            ImageNameTextBox.Location = new Point(136, 141);
            ImageNameTextBox.Name = "ImageNameTextBox";
            ImageNameTextBox.Size = new Size(126, 27);
            ImageNameTextBox.TabIndex = 9;
            // 
            // ImageName
            // 
            ImageName.AutoSize = true;
            ImageName.Location = new Point(25, 144);
            ImageName.Name = "ImageName";
            ImageName.Size = new Size(96, 20);
            ImageName.TabIndex = 10;
            ImageName.Text = "Image Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(661, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // GO_X
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 532);
            Controls.Add(label3);
            Controls.Add(ImageName);
            Controls.Add(ImageNameTextBox);
            Controls.Add(ActionGroup);
            Controls.Add(FileNameTextBox);
            Controls.Add(SaveFileButton);
            Controls.Add(StreamingGoup);
            Controls.Add(ParameterGroup);
            Controls.Add(CaptureGroup);
            Name = "GO_X";
            Text = "StreamingTool";
            ActionGroup.ResumeLayout(false);
            CaptureGroup.ResumeLayout(false);
            CaptureGroup.PerformLayout();
            ParameterGroup.ResumeLayout(false);
            ParameterGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BlueGainNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreenGainNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedGainNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)BlueGainTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GreenGainTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedGainTrackBar).EndInit();
            StreamingGoup.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PvGUIDotNet.PvDisplayControl display;
        private PvGUIDotNet.PvStatusControl statusControl;
        private GroupBox ActionGroup;
        private Button ConnectionControlButton;
        private Button AcquisitionControlButton;
        private GroupBox CaptureGroup;
        private CheckBox JPGCaptureCheckBox;
        private Button CaptureButton;
        private ListBox CaptureMethodListBox;
        private GroupBox ParameterGroup;
        private Label B;
        private Label G;
        private Label R;
        private Button button6;
        private Button SetFrameRateButton;
        private TextBox FrameRateTextBox;
        private CheckBox ExposureAutoCheckBox;
        private TextBox ExposureTimeTextBox;
        private Button SetExposureTimeButton;
        private GroupBox StreamingGoup;
        private Button SaveFileButton;
        private TextBox FileNameTextBox;
        private TextBox ImageNameTextBox;
        private TrackBar BlueGainTrackBar;
        private TrackBar GreenGainTrackBar;
        private Label label2;
        private Label label;
        private TrackBar RedGainTrackBar;
        private Label ImageName;
        private CheckBox WhiteBalanceCheckBox;
        private Label MaxMinLabel;
        private Label label1;
        private NumericUpDown RedGainNumeric;
        private NumericUpDown BlueGainNumeric;
        private NumericUpDown GreenGainNumeric;
        private Button GainReset;
        private CheckBox CaptureTimerCheckBox;
        private Label label5;
        private TextBox CaptureTimerTextBox;
        private Label label4;
        private Label label3;
    }
}