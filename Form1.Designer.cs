namespace TT_Assist
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RulesTrackBar = new System.Windows.Forms.TrackBar();
            this.VFRlabel = new System.Windows.Forms.Label();
            this.IFRLabel = new System.Windows.Forms.Label();
            this.WeightGroupBox = new System.Windows.Forms.GroupBox();
            this.AnyWtRadioButton = new System.Windows.Forms.RadioButton();
            this.HeavyRadioButton = new System.Windows.Forms.RadioButton();
            this.LargeRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.SmallRadioButton = new System.Windows.Forms.RadioButton();
            this.EngineGroupBox = new System.Windows.Forms.GroupBox();
            this.AnyEngineRadioButton = new System.Windows.Forms.RadioButton();
            this.HeloRadioButton = new System.Windows.Forms.RadioButton();
            this.JetRadioButton = new System.Windows.Forms.RadioButton();
            this.TurboRadioButton = new System.Windows.Forms.RadioButton();
            this.PropRadioButton = new System.Windows.Forms.RadioButton();
            this.RWYLabel = new System.Windows.Forms.Label();
            this.RWYTextBox = new System.Windows.Forms.TextBox();
            this.RWYListBox = new System.Windows.Forms.ListBox();
            this.AddRWYButton = new System.Windows.Forms.Button();
            this.DelRWYButton = new System.Windows.Forms.Button();
            this.AddApprButton = new System.Windows.Forms.Button();
            this.AddParkedButton = new System.Windows.Forms.Button();
            this.DelGateButton = new System.Windows.Forms.Button();
            this.GateAddButton = new System.Windows.Forms.Button();
            this.GatesListBox = new System.Windows.Forms.ListBox();
            this.GatesTextBox = new System.Windows.Forms.TextBox();
            this.GatesLabel = new System.Windows.Forms.Label();
            this.ACTypeLabel = new System.Windows.Forms.Label();
            this.ACTypeTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GetAPTButton = new System.Windows.Forms.Button();
            this.AddParkedTextBox = new System.Windows.Forms.TextBox();
            this.DistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddApprTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowAppHxCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowParkHxCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RulesTrackBar)).BeginInit();
            this.WeightGroupBox.SuspendLayout();
            this.EngineGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RulesTrackBar
            // 
            this.RulesTrackBar.Location = new System.Drawing.Point(135, 115);
            this.RulesTrackBar.Maximum = 100;
            this.RulesTrackBar.Name = "RulesTrackBar";
            this.RulesTrackBar.Size = new System.Drawing.Size(134, 45);
            this.RulesTrackBar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.RulesTrackBar, "Slide shifter to change probablility of VFR or IFR");
            this.RulesTrackBar.Value = 50;
            // 
            // VFRlabel
            // 
            this.VFRlabel.AutoSize = true;
            this.VFRlabel.Location = new System.Drawing.Point(96, 115);
            this.VFRlabel.Name = "VFRlabel";
            this.VFRlabel.Size = new System.Drawing.Size(33, 26);
            this.VFRlabel.TabIndex = 1;
            this.VFRlabel.Text = "100%\r\nVFR";
            this.VFRlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IFRLabel
            // 
            this.IFRLabel.AutoSize = true;
            this.IFRLabel.Location = new System.Drawing.Point(275, 115);
            this.IFRLabel.Name = "IFRLabel";
            this.IFRLabel.Size = new System.Drawing.Size(33, 26);
            this.IFRLabel.TabIndex = 2;
            this.IFRLabel.Text = "100%\r\nIFR";
            this.IFRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightGroupBox
            // 
            this.WeightGroupBox.Controls.Add(this.AnyWtRadioButton);
            this.WeightGroupBox.Controls.Add(this.HeavyRadioButton);
            this.WeightGroupBox.Controls.Add(this.LargeRadioButton);
            this.WeightGroupBox.Controls.Add(this.MediumRadioButton);
            this.WeightGroupBox.Controls.Add(this.SmallRadioButton);
            this.WeightGroupBox.Location = new System.Drawing.Point(17, 155);
            this.WeightGroupBox.Name = "WeightGroupBox";
            this.WeightGroupBox.Size = new System.Drawing.Size(298, 45);
            this.WeightGroupBox.TabIndex = 3;
            this.WeightGroupBox.TabStop = false;
            this.WeightGroupBox.Text = "Weight";
            this.toolTip1.SetToolTip(this.WeightGroupBox, "Select aircraft weight class or allow TT_Assist to choose.");
            // 
            // AnyWtRadioButton
            // 
            this.AnyWtRadioButton.AutoSize = true;
            this.AnyWtRadioButton.Checked = true;
            this.AnyWtRadioButton.Location = new System.Drawing.Point(212, 20);
            this.AnyWtRadioButton.Name = "AnyWtRadioButton";
            this.AnyWtRadioButton.Size = new System.Drawing.Size(65, 17);
            this.AnyWtRadioButton.TabIndex = 7;
            this.AnyWtRadioButton.TabStop = true;
            this.AnyWtRadioButton.Text = "Random";
            this.toolTip1.SetToolTip(this.AnyWtRadioButton, "Randomly chooses an aircraft size");
            this.AnyWtRadioButton.UseVisualStyleBackColor = true;
            this.AnyWtRadioButton.CheckedChanged += new System.EventHandler(this.AnyWtRadioButton_CheckedChanged);
            // 
            // HeavyRadioButton
            // 
            this.HeavyRadioButton.AutoSize = true;
            this.HeavyRadioButton.Location = new System.Drawing.Point(155, 20);
            this.HeavyRadioButton.Name = "HeavyRadioButton";
            this.HeavyRadioButton.Size = new System.Drawing.Size(56, 17);
            this.HeavyRadioButton.TabIndex = 6;
            this.HeavyRadioButton.Text = "Heavy";
            this.toolTip1.SetToolTip(this.HeavyRadioButton, "Selects a heavy aircraft");
            this.HeavyRadioButton.UseVisualStyleBackColor = true;
            this.HeavyRadioButton.CheckedChanged += new System.EventHandler(this.HeavyRadioButton_CheckedChanged);
            // 
            // LargeRadioButton
            // 
            this.LargeRadioButton.AutoSize = true;
            this.LargeRadioButton.Location = new System.Drawing.Point(111, 20);
            this.LargeRadioButton.Name = "LargeRadioButton";
            this.LargeRadioButton.Size = new System.Drawing.Size(40, 17);
            this.LargeRadioButton.TabIndex = 5;
            this.LargeRadioButton.Text = "Lrg";
            this.toolTip1.SetToolTip(this.LargeRadioButton, "Selects a large aircraft");
            this.LargeRadioButton.UseVisualStyleBackColor = true;
            this.LargeRadioButton.CheckedChanged += new System.EventHandler(this.LargeRadioButton_CheckedChanged);
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(63, 20);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(46, 17);
            this.MediumRadioButton.TabIndex = 4;
            this.MediumRadioButton.Text = "Med";
            this.toolTip1.SetToolTip(this.MediumRadioButton, "Selects a medium aircraft");
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            this.MediumRadioButton.CheckedChanged += new System.EventHandler(this.MediumRadioButton_CheckedChanged);
            // 
            // SmallRadioButton
            // 
            this.SmallRadioButton.AutoSize = true;
            this.SmallRadioButton.Location = new System.Drawing.Point(7, 20);
            this.SmallRadioButton.Name = "SmallRadioButton";
            this.SmallRadioButton.Size = new System.Drawing.Size(50, 17);
            this.SmallRadioButton.TabIndex = 0;
            this.SmallRadioButton.Text = "Small";
            this.toolTip1.SetToolTip(this.SmallRadioButton, "Selects a small aircraft");
            this.SmallRadioButton.UseVisualStyleBackColor = true;
            this.SmallRadioButton.CheckedChanged += new System.EventHandler(this.SmallRadioButton_CheckedChanged);
            // 
            // EngineGroupBox
            // 
            this.EngineGroupBox.Controls.Add(this.AnyEngineRadioButton);
            this.EngineGroupBox.Controls.Add(this.HeloRadioButton);
            this.EngineGroupBox.Controls.Add(this.JetRadioButton);
            this.EngineGroupBox.Controls.Add(this.TurboRadioButton);
            this.EngineGroupBox.Controls.Add(this.PropRadioButton);
            this.EngineGroupBox.Location = new System.Drawing.Point(17, 206);
            this.EngineGroupBox.Name = "EngineGroupBox";
            this.EngineGroupBox.Size = new System.Drawing.Size(298, 45);
            this.EngineGroupBox.TabIndex = 4;
            this.EngineGroupBox.TabStop = false;
            this.EngineGroupBox.Text = "Engine";
            this.toolTip1.SetToolTip(this.EngineGroupBox, "Select power plant type or allow TT_Assist to choose.");
            // 
            // AnyEngineRadioButton
            // 
            this.AnyEngineRadioButton.AutoSize = true;
            this.AnyEngineRadioButton.Checked = true;
            this.AnyEngineRadioButton.Location = new System.Drawing.Point(227, 20);
            this.AnyEngineRadioButton.Name = "AnyEngineRadioButton";
            this.AnyEngineRadioButton.Size = new System.Drawing.Size(65, 17);
            this.AnyEngineRadioButton.TabIndex = 8;
            this.AnyEngineRadioButton.TabStop = true;
            this.AnyEngineRadioButton.Text = "Random";
            this.toolTip1.SetToolTip(this.AnyEngineRadioButton, "Randomly selects an engine type");
            this.AnyEngineRadioButton.UseVisualStyleBackColor = true;
            this.AnyEngineRadioButton.CheckedChanged += new System.EventHandler(this.AnyEngineRadioButton_CheckedChanged);
            // 
            // HeloRadioButton
            // 
            this.HeloRadioButton.AutoSize = true;
            this.HeloRadioButton.Location = new System.Drawing.Point(177, 20);
            this.HeloRadioButton.Name = "HeloRadioButton";
            this.HeloRadioButton.Size = new System.Drawing.Size(47, 17);
            this.HeloRadioButton.TabIndex = 6;
            this.HeloRadioButton.Text = "Helo";
            this.toolTip1.SetToolTip(this.HeloRadioButton, "Selects a rotary aircraft");
            this.HeloRadioButton.UseVisualStyleBackColor = true;
            this.HeloRadioButton.CheckedChanged += new System.EventHandler(this.HeloRadioButton_CheckedChanged);
            // 
            // JetRadioButton
            // 
            this.JetRadioButton.AutoSize = true;
            this.JetRadioButton.Location = new System.Drawing.Point(134, 20);
            this.JetRadioButton.Name = "JetRadioButton";
            this.JetRadioButton.Size = new System.Drawing.Size(39, 17);
            this.JetRadioButton.TabIndex = 5;
            this.JetRadioButton.Text = "Jet";
            this.toolTip1.SetToolTip(this.JetRadioButton, "Selects a turbine aircraft");
            this.JetRadioButton.UseVisualStyleBackColor = true;
            this.JetRadioButton.CheckedChanged += new System.EventHandler(this.JetRadioButton_CheckedChanged);
            // 
            // TurboRadioButton
            // 
            this.TurboRadioButton.AutoSize = true;
            this.TurboRadioButton.Location = new System.Drawing.Point(57, 20);
            this.TurboRadioButton.Name = "TurboRadioButton";
            this.TurboRadioButton.Size = new System.Drawing.Size(75, 17);
            this.TurboRadioButton.TabIndex = 4;
            this.TurboRadioButton.Text = "TurboProp";
            this.toolTip1.SetToolTip(this.TurboRadioButton, "Selects a turbopropl aircraft");
            this.TurboRadioButton.UseVisualStyleBackColor = true;
            this.TurboRadioButton.CheckedChanged += new System.EventHandler(this.TurboRadioButton_CheckedChanged);
            // 
            // PropRadioButton
            // 
            this.PropRadioButton.AutoSize = true;
            this.PropRadioButton.Location = new System.Drawing.Point(7, 20);
            this.PropRadioButton.Name = "PropRadioButton";
            this.PropRadioButton.Size = new System.Drawing.Size(47, 17);
            this.PropRadioButton.TabIndex = 0;
            this.PropRadioButton.Text = "Prop";
            this.toolTip1.SetToolTip(this.PropRadioButton, "Selects a propeller aircraft");
            this.PropRadioButton.UseVisualStyleBackColor = true;
            this.PropRadioButton.CheckedChanged += new System.EventHandler(this.PropRadioButton_CheckedChanged);
            // 
            // RWYLabel
            // 
            this.RWYLabel.AutoSize = true;
            this.RWYLabel.Location = new System.Drawing.Point(20, 258);
            this.RWYLabel.Name = "RWYLabel";
            this.RWYLabel.Size = new System.Drawing.Size(51, 13);
            this.RWYLabel.TabIndex = 5;
            this.RWYLabel.Text = "Runways";
            // 
            // RWYTextBox
            // 
            this.RWYTextBox.Location = new System.Drawing.Point(23, 275);
            this.RWYTextBox.Name = "RWYTextBox";
            this.RWYTextBox.Size = new System.Drawing.Size(51, 20);
            this.RWYTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.RWYTextBox, "Runway to be added to list. \r\nRunway must be in APT file.");
            // 
            // RWYListBox
            // 
            this.RWYListBox.FormattingEnabled = true;
            this.RWYListBox.Location = new System.Drawing.Point(80, 257);
            this.RWYListBox.Name = "RWYListBox";
            this.RWYListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.RWYListBox.Size = new System.Drawing.Size(62, 95);
            this.RWYListBox.Sorted = true;
            this.RWYListBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.RWYListBox, "Select one or more RWYs to be randomly chosen.\r\nIf no runways selected, all will " +
        "be used.\r\n");
            this.RWYListBox.SelectedIndexChanged += new System.EventHandler(this.RWYListBox_SelectedIndexChanged);
            // 
            // AddRWYButton
            // 
            this.AddRWYButton.Location = new System.Drawing.Point(24, 301);
            this.AddRWYButton.Name = "AddRWYButton";
            this.AddRWYButton.Size = new System.Drawing.Size(50, 23);
            this.AddRWYButton.TabIndex = 8;
            this.AddRWYButton.Text = "Add";
            this.toolTip1.SetToolTip(this.AddRWYButton, "Add a runway to the list. \r\nMust be in APT file");
            this.AddRWYButton.UseVisualStyleBackColor = true;
            this.AddRWYButton.Click += new System.EventHandler(this.AddRWYButton_Click);
            // 
            // DelRWYButton
            // 
            this.DelRWYButton.Location = new System.Drawing.Point(24, 329);
            this.DelRWYButton.Name = "DelRWYButton";
            this.DelRWYButton.Size = new System.Drawing.Size(50, 23);
            this.DelRWYButton.TabIndex = 9;
            this.DelRWYButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.DelRWYButton, "Remove selected runway from list");
            this.DelRWYButton.UseVisualStyleBackColor = true;
            this.DelRWYButton.Click += new System.EventHandler(this.DelRWYButton_Click);
            // 
            // AddApprButton
            // 
            this.AddApprButton.Location = new System.Drawing.Point(21, 389);
            this.AddApprButton.Name = "AddApprButton";
            this.AddApprButton.Size = new System.Drawing.Size(78, 23);
            this.AddApprButton.TabIndex = 10;
            this.AddApprButton.Text = "On Approach";
            this.toolTip1.SetToolTip(this.AddApprButton, "Create the add AC to approach command.\r\nThis is automatically copied to clipboard" +
        ".");
            this.AddApprButton.UseVisualStyleBackColor = true;
            this.AddApprButton.Click += new System.EventHandler(this.AddApprButton_Click);
            // 
            // AddParkedButton
            // 
            this.AddParkedButton.Location = new System.Drawing.Point(19, 418);
            this.AddParkedButton.Name = "AddParkedButton";
            this.AddParkedButton.Size = new System.Drawing.Size(78, 23);
            this.AddParkedButton.TabIndex = 11;
            this.AddParkedButton.Text = "Parked";
            this.AddParkedButton.UseVisualStyleBackColor = true;
            this.AddParkedButton.Click += new System.EventHandler(this.AddParkedButton_Click);
            // 
            // DelGateButton
            // 
            this.DelGateButton.Location = new System.Drawing.Point(150, 333);
            this.DelGateButton.Name = "DelGateButton";
            this.DelGateButton.Size = new System.Drawing.Size(50, 23);
            this.DelGateButton.TabIndex = 16;
            this.DelGateButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.DelGateButton, "Remove selected gate from list");
            this.DelGateButton.UseVisualStyleBackColor = true;
            this.DelGateButton.Click += new System.EventHandler(this.DelGateButton_Click);
            // 
            // GateAddButton
            // 
            this.GateAddButton.Location = new System.Drawing.Point(150, 304);
            this.GateAddButton.Name = "GateAddButton";
            this.GateAddButton.Size = new System.Drawing.Size(50, 23);
            this.GateAddButton.TabIndex = 15;
            this.GateAddButton.Text = "Add";
            this.toolTip1.SetToolTip(this.GateAddButton, "Add a gate to list \r\n(Must be in APT file)");
            this.GateAddButton.UseVisualStyleBackColor = true;
            this.GateAddButton.Click += new System.EventHandler(this.GateAddButton_Click);
            // 
            // GatesListBox
            // 
            this.GatesListBox.FormattingEnabled = true;
            this.GatesListBox.Location = new System.Drawing.Point(206, 259);
            this.GatesListBox.Name = "GatesListBox";
            this.GatesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.GatesListBox.Size = new System.Drawing.Size(62, 95);
            this.GatesListBox.Sorted = true;
            this.GatesListBox.TabIndex = 14;
            this.toolTip1.SetToolTip(this.GatesListBox, "Select one or more gates to be randomly selected.\r\nIf no gates selected, entire l" +
        "ist will be used.");
            // 
            // GatesTextBox
            // 
            this.GatesTextBox.Location = new System.Drawing.Point(152, 275);
            this.GatesTextBox.Name = "GatesTextBox";
            this.GatesTextBox.Size = new System.Drawing.Size(51, 20);
            this.GatesTextBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.GatesTextBox, "Gate to be added to list.\r\nDo not use \'@\' sign.\r\nGate must be in APT file.");
            // 
            // GatesLabel
            // 
            this.GatesLabel.AutoSize = true;
            this.GatesLabel.Location = new System.Drawing.Point(163, 260);
            this.GatesLabel.Name = "GatesLabel";
            this.GatesLabel.Size = new System.Drawing.Size(35, 13);
            this.GatesLabel.TabIndex = 12;
            this.GatesLabel.Text = "Gates";
            // 
            // ACTypeLabel
            // 
            this.ACTypeLabel.AutoSize = true;
            this.ACTypeLabel.Location = new System.Drawing.Point(155, 363);
            this.ACTypeLabel.Name = "ACTypeLabel";
            this.ACTypeLabel.Size = new System.Drawing.Size(48, 13);
            this.ACTypeLabel.TabIndex = 17;
            this.ACTypeLabel.Text = "AC Type";
            // 
            // ACTypeTextBox
            // 
            this.ACTypeTextBox.Location = new System.Drawing.Point(214, 360);
            this.ACTypeTextBox.Name = "ACTypeTextBox";
            this.ACTypeTextBox.Size = new System.Drawing.Size(48, 20);
            this.ACTypeTextBox.TabIndex = 18;
            this.toolTip1.SetToolTip(this.ACTypeTextBox, "IF blank, TwrTrainer will create a random AC type.");
            this.ACTypeTextBox.Validated += new System.EventHandler(this.ACTypeTextBox_Validated);
            // 
            // GetAPTButton
            // 
            this.GetAPTButton.Location = new System.Drawing.Point(233, 25);
            this.GetAPTButton.Name = "GetAPTButton";
            this.GetAPTButton.Size = new System.Drawing.Size(75, 42);
            this.GetAPTButton.TabIndex = 21;
            this.GetAPTButton.Text = "Read APT file";
            this.toolTip1.SetToolTip(this.GetAPTButton, "Inputs data from APT file");
            this.GetAPTButton.UseVisualStyleBackColor = true;
            this.GetAPTButton.Click += new System.EventHandler(this.GetAPTButton_Click);
            // 
            // AddParkedTextBox
            // 
            this.AddParkedTextBox.Location = new System.Drawing.Point(105, 421);
            this.AddParkedTextBox.Name = "AddParkedTextBox";
            this.AddParkedTextBox.Size = new System.Drawing.Size(133, 20);
            this.AddParkedTextBox.TabIndex = 20;
            this.toolTip1.SetToolTip(this.AddParkedTextBox, "Create the add parked AC command.\r\nThis is automatically copied to clipboard.");
            // 
            // DistanceNumericUpDown
            // 
            this.DistanceNumericUpDown.Location = new System.Drawing.Point(80, 363);
            this.DistanceNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DistanceNumericUpDown.Name = "DistanceNumericUpDown";
            this.DistanceNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.DistanceNumericUpDown.TabIndex = 25;
            this.toolTip1.SetToolTip(this.DistanceNumericUpDown, "Approach distance from runway threshold.\r\nAllowable zero to 100 nautical miles.\r\n" +
        "Must be changed using up/down buttons.");
            this.DistanceNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DistanceNumericUpDown.ValueChanged += new System.EventHandler(this.DistanceNumericUpDown_ValueChanged);
            // 
            // AddApprTextBox
            // 
            this.AddApprTextBox.Location = new System.Drawing.Point(104, 391);
            this.AddApprTextBox.Name = "AddApprTextBox";
            this.AddApprTextBox.Size = new System.Drawing.Size(134, 20);
            this.AddApprTextBox.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "\"C:\\My Documents\"";
            this.openFileDialog1.Title = "Open the TwrTrainer APT file in use";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(26, 363);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(49, 13);
            this.DistanceLabel.TabIndex = 22;
            this.DistanceLabel.Text = "Distance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "VFR/IFR rule probability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 60);
            this.label2.TabIndex = 26;
            this.label2.Text = "1. Open VRC, log into sweatbox and\r\n    prime your trainer position/freq.\r\n2. Ope" +
    "n Tower Trainer and files. \r\n3. Read the same .apt file here ->\r\n";
            // 
            // ShowAppHxCheckBox
            // 
            this.ShowAppHxCheckBox.AutoSize = true;
            this.ShowAppHxCheckBox.Location = new System.Drawing.Point(242, 391);
            this.ShowAppHxCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowAppHxCheckBox.Name = "ShowAppHxCheckBox";
            this.ShowAppHxCheckBox.Size = new System.Drawing.Size(69, 17);
            this.ShowAppHxCheckBox.TabIndex = 27;
            this.ShowAppHxCheckBox.Text = "Show Hx";
            this.ShowAppHxCheckBox.UseVisualStyleBackColor = true;
            this.ShowAppHxCheckBox.CheckedChanged += new System.EventHandler(this.ShowAppHxCheckBox_CheckedChanged);
            // 
            // ShowParkHxCheckBox
            // 
            this.ShowParkHxCheckBox.AutoSize = true;
            this.ShowParkHxCheckBox.Location = new System.Drawing.Point(242, 421);
            this.ShowParkHxCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowParkHxCheckBox.Name = "ShowParkHxCheckBox";
            this.ShowParkHxCheckBox.Size = new System.Drawing.Size(69, 17);
            this.ShowParkHxCheckBox.TabIndex = 28;
            this.ShowParkHxCheckBox.Text = "Show Hx";
            this.ShowParkHxCheckBox.UseVisualStyleBackColor = true;
            this.ShowParkHxCheckBox.CheckedChanged += new System.EventHandler(this.ShowParkHxCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "4. Use the options below to create aircraft.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(38, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "------------------------------------------------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 26);
            this.label5.TabIndex = 31;
            this.label5.Text = "IFR or VFR \r\nprobability";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 460);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowParkHxCheckBox);
            this.Controls.Add(this.ShowAppHxCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DistanceNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.GetAPTButton);
            this.Controls.Add(this.AddParkedTextBox);
            this.Controls.Add(this.AddApprTextBox);
            this.Controls.Add(this.ACTypeTextBox);
            this.Controls.Add(this.ACTypeLabel);
            this.Controls.Add(this.DelGateButton);
            this.Controls.Add(this.GateAddButton);
            this.Controls.Add(this.GatesListBox);
            this.Controls.Add(this.GatesTextBox);
            this.Controls.Add(this.GatesLabel);
            this.Controls.Add(this.AddParkedButton);
            this.Controls.Add(this.AddApprButton);
            this.Controls.Add(this.DelRWYButton);
            this.Controls.Add(this.AddRWYButton);
            this.Controls.Add(this.RWYListBox);
            this.Controls.Add(this.RWYTextBox);
            this.Controls.Add(this.RWYLabel);
            this.Controls.Add(this.EngineGroupBox);
            this.Controls.Add(this.WeightGroupBox);
            this.Controls.Add(this.IFRLabel);
            this.Controls.Add(this.VFRlabel);
            this.Controls.Add(this.RulesTrackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tower Trainer Ass\'t";
            ((System.ComponentModel.ISupportInitialize)(this.RulesTrackBar)).EndInit();
            this.WeightGroupBox.ResumeLayout(false);
            this.WeightGroupBox.PerformLayout();
            this.EngineGroupBox.ResumeLayout(false);
            this.EngineGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar RulesTrackBar;
        private System.Windows.Forms.Label VFRlabel;
        private System.Windows.Forms.Label IFRLabel;
        private System.Windows.Forms.GroupBox WeightGroupBox;
        private System.Windows.Forms.RadioButton HeavyRadioButton;
        private System.Windows.Forms.RadioButton LargeRadioButton;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton SmallRadioButton;
        private System.Windows.Forms.GroupBox EngineGroupBox;
        private System.Windows.Forms.RadioButton HeloRadioButton;
        private System.Windows.Forms.RadioButton JetRadioButton;
        private System.Windows.Forms.RadioButton TurboRadioButton;
        private System.Windows.Forms.RadioButton PropRadioButton;
        private System.Windows.Forms.Label RWYLabel;
        private System.Windows.Forms.TextBox RWYTextBox;
        private System.Windows.Forms.ListBox RWYListBox;
        private System.Windows.Forms.Button AddRWYButton;
        private System.Windows.Forms.Button DelRWYButton;
        private System.Windows.Forms.Button AddApprButton;
        private System.Windows.Forms.Button AddParkedButton;
        private System.Windows.Forms.Button DelGateButton;
        private System.Windows.Forms.Button GateAddButton;
        private System.Windows.Forms.ListBox GatesListBox;
        private System.Windows.Forms.TextBox GatesTextBox;
        private System.Windows.Forms.Label GatesLabel;
        private System.Windows.Forms.Label ACTypeLabel;
        private System.Windows.Forms.TextBox ACTypeTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox AddApprTextBox;
        private System.Windows.Forms.TextBox AddParkedTextBox;
        private System.Windows.Forms.Button GetAPTButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton AnyWtRadioButton;
        private System.Windows.Forms.RadioButton AnyEngineRadioButton;
        private System.Windows.Forms.NumericUpDown DistanceNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ShowAppHxCheckBox;
        private System.Windows.Forms.CheckBox ShowParkHxCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

