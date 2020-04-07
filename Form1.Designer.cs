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
            ((System.ComponentModel.ISupportInitialize)(this.RulesTrackBar)).BeginInit();
            this.WeightGroupBox.SuspendLayout();
            this.EngineGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RulesTrackBar
            // 
            this.RulesTrackBar.Location = new System.Drawing.Point(76, 94);
            this.RulesTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RulesTrackBar.Maximum = 100;
            this.RulesTrackBar.Name = "RulesTrackBar";
            this.RulesTrackBar.Size = new System.Drawing.Size(156, 69);
            this.RulesTrackBar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.RulesTrackBar, "Slide shifter to change probablility of VFR or IFR");
            this.RulesTrackBar.Value = 50;
            // 
            // VFRlabel
            // 
            this.VFRlabel.AutoSize = true;
            this.VFRlabel.Location = new System.Drawing.Point(26, 94);
            this.VFRlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VFRlabel.Name = "VFRlabel";
            this.VFRlabel.Size = new System.Drawing.Size(42, 20);
            this.VFRlabel.TabIndex = 1;
            this.VFRlabel.Text = "VFR";
            // 
            // IFRLabel
            // 
            this.IFRLabel.AutoSize = true;
            this.IFRLabel.Location = new System.Drawing.Point(242, 94);
            this.IFRLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IFRLabel.Name = "IFRLabel";
            this.IFRLabel.Size = new System.Drawing.Size(36, 20);
            this.IFRLabel.TabIndex = 2;
            this.IFRLabel.Text = "IFR";
            // 
            // WeightGroupBox
            // 
            this.WeightGroupBox.Controls.Add(this.AnyWtRadioButton);
            this.WeightGroupBox.Controls.Add(this.HeavyRadioButton);
            this.WeightGroupBox.Controls.Add(this.LargeRadioButton);
            this.WeightGroupBox.Controls.Add(this.MediumRadioButton);
            this.WeightGroupBox.Controls.Add(this.SmallRadioButton);
            this.WeightGroupBox.Location = new System.Drawing.Point(15, 155);
            this.WeightGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WeightGroupBox.Name = "WeightGroupBox";
            this.WeightGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WeightGroupBox.Size = new System.Drawing.Size(447, 69);
            this.WeightGroupBox.TabIndex = 3;
            this.WeightGroupBox.TabStop = false;
            this.WeightGroupBox.Text = "Weight";
            // 
            // AnyWtRadioButton
            // 
            this.AnyWtRadioButton.AutoSize = true;
            this.AnyWtRadioButton.Checked = true;
            this.AnyWtRadioButton.Location = new System.Drawing.Point(318, 31);
            this.AnyWtRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnyWtRadioButton.Name = "AnyWtRadioButton";
            this.AnyWtRadioButton.Size = new System.Drawing.Size(95, 24);
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
            this.HeavyRadioButton.Location = new System.Drawing.Point(232, 31);
            this.HeavyRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeavyRadioButton.Name = "HeavyRadioButton";
            this.HeavyRadioButton.Size = new System.Drawing.Size(78, 24);
            this.HeavyRadioButton.TabIndex = 6;
            this.HeavyRadioButton.Text = "Heavy";
            this.toolTip1.SetToolTip(this.HeavyRadioButton, "Selects a heavy aircraft");
            this.HeavyRadioButton.UseVisualStyleBackColor = true;
            this.HeavyRadioButton.CheckedChanged += new System.EventHandler(this.HeavyRadioButton_CheckedChanged);
            // 
            // LargeRadioButton
            // 
            this.LargeRadioButton.AutoSize = true;
            this.LargeRadioButton.Location = new System.Drawing.Point(167, 31);
            this.LargeRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LargeRadioButton.Name = "LargeRadioButton";
            this.LargeRadioButton.Size = new System.Drawing.Size(57, 24);
            this.LargeRadioButton.TabIndex = 5;
            this.LargeRadioButton.Text = "Lrg";
            this.toolTip1.SetToolTip(this.LargeRadioButton, "Selects a large aircraft");
            this.LargeRadioButton.UseVisualStyleBackColor = true;
            this.LargeRadioButton.CheckedChanged += new System.EventHandler(this.LargeRadioButton_CheckedChanged);
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(94, 31);
            this.MediumRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(65, 24);
            this.MediumRadioButton.TabIndex = 4;
            this.MediumRadioButton.Text = "Med";
            this.toolTip1.SetToolTip(this.MediumRadioButton, "Selects a medium aircraft");
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            this.MediumRadioButton.CheckedChanged += new System.EventHandler(this.MediumRadioButton_CheckedChanged);
            // 
            // SmallRadioButton
            // 
            this.SmallRadioButton.AutoSize = true;
            this.SmallRadioButton.Location = new System.Drawing.Point(10, 31);
            this.SmallRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SmallRadioButton.Name = "SmallRadioButton";
            this.SmallRadioButton.Size = new System.Drawing.Size(73, 24);
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
            this.EngineGroupBox.Location = new System.Drawing.Point(15, 234);
            this.EngineGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EngineGroupBox.Name = "EngineGroupBox";
            this.EngineGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EngineGroupBox.Size = new System.Drawing.Size(447, 69);
            this.EngineGroupBox.TabIndex = 4;
            this.EngineGroupBox.TabStop = false;
            this.EngineGroupBox.Text = "Engine";
            // 
            // AnyEngineRadioButton
            // 
            this.AnyEngineRadioButton.AutoSize = true;
            this.AnyEngineRadioButton.Checked = true;
            this.AnyEngineRadioButton.Location = new System.Drawing.Point(340, 31);
            this.AnyEngineRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnyEngineRadioButton.Name = "AnyEngineRadioButton";
            this.AnyEngineRadioButton.Size = new System.Drawing.Size(95, 24);
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
            this.HeloRadioButton.Location = new System.Drawing.Point(265, 31);
            this.HeloRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeloRadioButton.Name = "HeloRadioButton";
            this.HeloRadioButton.Size = new System.Drawing.Size(67, 24);
            this.HeloRadioButton.TabIndex = 6;
            this.HeloRadioButton.Text = "Helo";
            this.toolTip1.SetToolTip(this.HeloRadioButton, "Selects a rotary aircraft");
            this.HeloRadioButton.UseVisualStyleBackColor = true;
            this.HeloRadioButton.CheckedChanged += new System.EventHandler(this.HeloRadioButton_CheckedChanged);
            // 
            // JetRadioButton
            // 
            this.JetRadioButton.AutoSize = true;
            this.JetRadioButton.Location = new System.Drawing.Point(201, 31);
            this.JetRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JetRadioButton.Name = "JetRadioButton";
            this.JetRadioButton.Size = new System.Drawing.Size(56, 24);
            this.JetRadioButton.TabIndex = 5;
            this.JetRadioButton.Text = "Jet";
            this.toolTip1.SetToolTip(this.JetRadioButton, "Selects a turbine aircraft");
            this.JetRadioButton.UseVisualStyleBackColor = true;
            this.JetRadioButton.CheckedChanged += new System.EventHandler(this.JetRadioButton_CheckedChanged);
            // 
            // TurboRadioButton
            // 
            this.TurboRadioButton.AutoSize = true;
            this.TurboRadioButton.Location = new System.Drawing.Point(85, 31);
            this.TurboRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TurboRadioButton.Name = "TurboRadioButton";
            this.TurboRadioButton.Size = new System.Drawing.Size(108, 24);
            this.TurboRadioButton.TabIndex = 4;
            this.TurboRadioButton.Text = "TurboProp";
            this.toolTip1.SetToolTip(this.TurboRadioButton, "Selects a turbopropl aircraft");
            this.TurboRadioButton.UseVisualStyleBackColor = true;
            this.TurboRadioButton.CheckedChanged += new System.EventHandler(this.TurboRadioButton_CheckedChanged);
            // 
            // PropRadioButton
            // 
            this.PropRadioButton.AutoSize = true;
            this.PropRadioButton.Location = new System.Drawing.Point(10, 31);
            this.PropRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PropRadioButton.Name = "PropRadioButton";
            this.PropRadioButton.Size = new System.Drawing.Size(67, 24);
            this.PropRadioButton.TabIndex = 0;
            this.PropRadioButton.Text = "Prop";
            this.toolTip1.SetToolTip(this.PropRadioButton, "Selects a propeller aircraft");
            this.PropRadioButton.UseVisualStyleBackColor = true;
            this.PropRadioButton.CheckedChanged += new System.EventHandler(this.PropRadioButton_CheckedChanged);
            // 
            // RWYLabel
            // 
            this.RWYLabel.AutoSize = true;
            this.RWYLabel.Location = new System.Drawing.Point(20, 314);
            this.RWYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RWYLabel.Name = "RWYLabel";
            this.RWYLabel.Size = new System.Drawing.Size(74, 20);
            this.RWYLabel.TabIndex = 5;
            this.RWYLabel.Text = "Runways";
            // 
            // RWYTextBox
            // 
            this.RWYTextBox.Location = new System.Drawing.Point(24, 340);
            this.RWYTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RWYTextBox.Name = "RWYTextBox";
            this.RWYTextBox.Size = new System.Drawing.Size(74, 26);
            this.RWYTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.RWYTextBox, "Runway to be added to list.\r\nRunway must be in APT file.");
            // 
            // RWYListBox
            // 
            this.RWYListBox.FormattingEnabled = true;
            this.RWYListBox.ItemHeight = 20;
            this.RWYListBox.Location = new System.Drawing.Point(110, 312);
            this.RWYListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RWYListBox.Name = "RWYListBox";
            this.RWYListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.RWYListBox.Size = new System.Drawing.Size(91, 144);
            this.RWYListBox.Sorted = true;
            this.RWYListBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.RWYListBox, "Select one or more RWYs to be randomly chosen.\r\nIf no runways selected, all will " +
        "be used.\r\n");
            // 
            // AddRWYButton
            // 
            this.AddRWYButton.Location = new System.Drawing.Point(26, 380);
            this.AddRWYButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddRWYButton.Name = "AddRWYButton";
            this.AddRWYButton.Size = new System.Drawing.Size(75, 35);
            this.AddRWYButton.TabIndex = 8;
            this.AddRWYButton.Text = "Add";
            this.toolTip1.SetToolTip(this.AddRWYButton, "Add a runway to the list.\r\n(Must be in APT file)");
            this.AddRWYButton.UseVisualStyleBackColor = true;
            this.AddRWYButton.Click += new System.EventHandler(this.AddRWYButton_Click);
            // 
            // DelRWYButton
            // 
            this.DelRWYButton.Location = new System.Drawing.Point(26, 423);
            this.DelRWYButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DelRWYButton.Name = "DelRWYButton";
            this.DelRWYButton.Size = new System.Drawing.Size(75, 35);
            this.DelRWYButton.TabIndex = 9;
            this.DelRWYButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.DelRWYButton, "Remove selected runway from list");
            this.DelRWYButton.UseVisualStyleBackColor = true;
            this.DelRWYButton.Click += new System.EventHandler(this.DelRWYButton_Click);
            // 
            // AddApprButton
            // 
            this.AddApprButton.Location = new System.Drawing.Point(21, 515);
            this.AddApprButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddApprButton.Name = "AddApprButton";
            this.AddApprButton.Size = new System.Drawing.Size(117, 35);
            this.AddApprButton.TabIndex = 10;
            this.AddApprButton.Text = "On Approach";
            this.toolTip1.SetToolTip(this.AddApprButton, "Create the add AC to approach command.\r\nThis is automatically copied to clipboard" +
        ".");
            this.AddApprButton.UseVisualStyleBackColor = true;
            this.AddApprButton.Click += new System.EventHandler(this.AddApprButton_Click);
            // 
            // AddParkedButton
            // 
            this.AddParkedButton.Location = new System.Drawing.Point(18, 560);
            this.AddParkedButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddParkedButton.Name = "AddParkedButton";
            this.AddParkedButton.Size = new System.Drawing.Size(117, 35);
            this.AddParkedButton.TabIndex = 11;
            this.AddParkedButton.Text = "Parked";
            this.AddParkedButton.UseVisualStyleBackColor = true;
            this.AddParkedButton.Click += new System.EventHandler(this.AddParkedButton_Click);
            // 
            // DelGateButton
            // 
            this.DelGateButton.Location = new System.Drawing.Point(214, 429);
            this.DelGateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DelGateButton.Name = "DelGateButton";
            this.DelGateButton.Size = new System.Drawing.Size(75, 35);
            this.DelGateButton.TabIndex = 16;
            this.DelGateButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.DelGateButton, "Remove selected gate from list");
            this.DelGateButton.UseVisualStyleBackColor = true;
            this.DelGateButton.Click += new System.EventHandler(this.DelGateButton_Click);
            // 
            // GateAddButton
            // 
            this.GateAddButton.Location = new System.Drawing.Point(214, 385);
            this.GateAddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GateAddButton.Name = "GateAddButton";
            this.GateAddButton.Size = new System.Drawing.Size(75, 35);
            this.GateAddButton.TabIndex = 15;
            this.GateAddButton.Text = "Add";
            this.toolTip1.SetToolTip(this.GateAddButton, "Add a gate to list \r\n(Must be in APT file)");
            this.GateAddButton.UseVisualStyleBackColor = true;
            this.GateAddButton.Click += new System.EventHandler(this.GateAddButton_Click);
            // 
            // GatesListBox
            // 
            this.GatesListBox.FormattingEnabled = true;
            this.GatesListBox.ItemHeight = 20;
            this.GatesListBox.Location = new System.Drawing.Point(298, 315);
            this.GatesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GatesListBox.Name = "GatesListBox";
            this.GatesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.GatesListBox.Size = new System.Drawing.Size(91, 144);
            this.GatesListBox.Sorted = true;
            this.GatesListBox.TabIndex = 14;
            this.toolTip1.SetToolTip(this.GatesListBox, "Select one or more gates to be randomly selected.\r\nIf no gates selected, entire l" +
        "ist will be used.");
            // 
            // GatesTextBox
            // 
            this.GatesTextBox.Location = new System.Drawing.Point(217, 340);
            this.GatesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GatesTextBox.Name = "GatesTextBox";
            this.GatesTextBox.Size = new System.Drawing.Size(74, 26);
            this.GatesTextBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.GatesTextBox, "Gate to be added to list.\r\nDo not use \'@\' sign.\r\nGate must be in APT file.");
            // 
            // GatesLabel
            // 
            this.GatesLabel.AutoSize = true;
            this.GatesLabel.Location = new System.Drawing.Point(234, 317);
            this.GatesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GatesLabel.Name = "GatesLabel";
            this.GatesLabel.Size = new System.Drawing.Size(53, 20);
            this.GatesLabel.TabIndex = 12;
            this.GatesLabel.Text = "Gates";
            // 
            // ACTypeLabel
            // 
            this.ACTypeLabel.AutoSize = true;
            this.ACTypeLabel.Location = new System.Drawing.Point(222, 475);
            this.ACTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ACTypeLabel.Name = "ACTypeLabel";
            this.ACTypeLabel.Size = new System.Drawing.Size(69, 20);
            this.ACTypeLabel.TabIndex = 17;
            this.ACTypeLabel.Text = "AC Type";
            // 
            // ACTypeTextBox
            // 
            this.ACTypeTextBox.Location = new System.Drawing.Point(310, 471);
            this.ACTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ACTypeTextBox.Name = "ACTypeTextBox";
            this.ACTypeTextBox.Size = new System.Drawing.Size(70, 26);
            this.ACTypeTextBox.TabIndex = 18;
            this.toolTip1.SetToolTip(this.ACTypeTextBox, "IF blank, TwrTrainer will create a random AC type.");
            this.ACTypeTextBox.Validated += new System.EventHandler(this.ACTypeTextBox_Validated);
            // 
            // GetAPTButton
            // 
            this.GetAPTButton.Location = new System.Drawing.Point(340, 72);
            this.GetAPTButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetAPTButton.Name = "GetAPTButton";
            this.GetAPTButton.Size = new System.Drawing.Size(112, 65);
            this.GetAPTButton.TabIndex = 21;
            this.GetAPTButton.Text = "Read APT file";
            this.toolTip1.SetToolTip(this.GetAPTButton, "Inputs data from APT file");
            this.GetAPTButton.UseVisualStyleBackColor = true;
            this.GetAPTButton.Click += new System.EventHandler(this.GetAPTButton_Click);
            // 
            // AddParkedTextBox
            // 
            this.AddParkedTextBox.Location = new System.Drawing.Point(147, 565);
            this.AddParkedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddParkedTextBox.Name = "AddParkedTextBox";
            this.AddParkedTextBox.Size = new System.Drawing.Size(198, 26);
            this.AddParkedTextBox.TabIndex = 20;
            this.toolTip1.SetToolTip(this.AddParkedTextBox, "Create the add parked AC command.\r\nThis is automatically copied to clipboard.");
            // 
            // DistanceNumericUpDown
            // 
            this.DistanceNumericUpDown.Location = new System.Drawing.Point(110, 475);
            this.DistanceNumericUpDown.Name = "DistanceNumericUpDown";
            this.DistanceNumericUpDown.Size = new System.Drawing.Size(91, 26);
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
            this.AddApprTextBox.Location = new System.Drawing.Point(146, 519);
            this.AddApprTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddApprTextBox.Name = "AddApprTextBox";
            this.AddApprTextBox.Size = new System.Drawing.Size(199, 26);
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
            this.DistanceLabel.Location = new System.Drawing.Point(28, 475);
            this.DistanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(72, 20);
            this.DistanceLabel.TabIndex = 22;
            this.DistanceLabel.Text = "Distance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "VFR/IFR rule probability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 44);
            this.label2.TabIndex = 26;
            this.label2.Text = "Open APT file you are using, then select options.  \r\nText command is automaticall" +
    "y copied to clipboard.";
            // 
            // ShowAppHxCheckBox
            // 
            this.ShowAppHxCheckBox.AutoSize = true;
            this.ShowAppHxCheckBox.Location = new System.Drawing.Point(352, 519);
            this.ShowAppHxCheckBox.Name = "ShowAppHxCheckBox";
            this.ShowAppHxCheckBox.Size = new System.Drawing.Size(98, 24);
            this.ShowAppHxCheckBox.TabIndex = 27;
            this.ShowAppHxCheckBox.Text = "Show Hx";
            this.ShowAppHxCheckBox.UseVisualStyleBackColor = true;
            this.ShowAppHxCheckBox.CheckedChanged += new System.EventHandler(this.ShowAppHxCheckBox_CheckedChanged);
            // 
            // ShowParkHxCheckBox
            // 
            this.ShowParkHxCheckBox.AutoSize = true;
            this.ShowParkHxCheckBox.Location = new System.Drawing.Point(352, 564);
            this.ShowParkHxCheckBox.Name = "ShowParkHxCheckBox";
            this.ShowParkHxCheckBox.Size = new System.Drawing.Size(98, 24);
            this.ShowParkHxCheckBox.TabIndex = 28;
            this.ShowParkHxCheckBox.Text = "Show Hx";
            this.ShowParkHxCheckBox.UseVisualStyleBackColor = true;
            this.ShowParkHxCheckBox.CheckedChanged += new System.EventHandler(this.ShowParkHxCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 621);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

