using System;
using System.Windows.Forms;
using System.Globalization;
using System.IO;


namespace TT_Assist
{
    public partial class Form1 : Form
    {
        public string wt = "?";
        public string eng = "?";
        public string distance = "10";
        public string ACType = string.Empty;

        public Form1()
        {
            InitializeComponent();
            SelectWt();
            SelectEngine();
        }

        private void AddRWYButton_Click(object sender, EventArgs e)
        {
            bool RWYfound = false;
            if (RWYTextBox.TextLength != 0)
            {
                foreach (string item in RWYListBox.Items)
                {
                    if (item == RWYTextBox.Text) RWYfound = true;
                }
                if (RWYfound)
                    MessageBox.Show("That runway is already in the list.");
                else
                    RWYListBox.Items.Add(RWYTextBox.Text);
            }
            else
                MessageBox.Show("Place a runway identifier in the text box first.");
        }

        private void DelRWYButton_Click(object sender, EventArgs e)
        {
            if (RWYListBox.Items.Count != 0)
            {
                if (RWYListBox.SelectedIndex != -1)
                    RWYListBox.Items.RemoveAt(RWYListBox.SelectedIndex);
                else
                    MessageBox.Show("Select a runway identifier in the runway list box to delete.");
            }
            else MessageBox.Show("There are no runways in the list to delete.");
        }

        private void GateAddButton_Click(object sender, EventArgs e)
        {
            bool Gatefound = false;
            if (GatesTextBox.TextLength != 0)
            {
                foreach(string item in GatesListBox.Items)
                {
                    if (item == GatesTextBox.Text) Gatefound = true;
                }
                if (Gatefound)
                    MessageBox.Show("That gate is already in the list.");
                else
                    GatesListBox.Items.Add(GatesTextBox.Text);
            }
            else
                MessageBox.Show("Place a gate in the text box first.");
        }

        private void DelGateButton_Click(object sender, EventArgs e)
        {
            if (GatesListBox.Items.Count != 0)
            {
                if (GatesListBox.SelectedIndex != -1)
                    GatesListBox.Items.RemoveAt(GatesListBox.SelectedIndex);
                else
                    MessageBox.Show("Select a gate in the gate list box to delete.");
            }
            else MessageBox.Show("There are no gates in the list to delete.");
        }

        private void GetAPTButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\My Documents",
                Title = "Browse Tower Trainer Apt Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "apt",
                Filter = "apt files (*.apt)|*.apt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Line; int Loc1; int Loc2; 
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    Line = reader.ReadLine();
                    while ((Line = reader.ReadLine()) != null)
                    {
                        if (Line.IndexOf("[PARKING") != -1)
                        {
                            GatesListBox.Items.Add(Line.Substring(Line.IndexOf(" ") + 1, Line.IndexOf("]") - Line.IndexOf(" ")-1));
                        }
                        if (Line.IndexOf("RUNWAY") != -1)
                        {
                            Loc1 = Line.IndexOf(" ");
                            Loc2 = Line.IndexOf("/");
                            RWYListBox.Items.Add(Line.Substring(Loc1 + 1, Loc2 - Loc1-1));
                            RWYListBox.Items.Add(Line.Substring(Loc2 + 1, Line.IndexOf("]") - Loc2-1));
                        }
                    }
                }
            }
        }
        private int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 100);
        }

        private void SmallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SmallRadioButton.Checked) wt = "s";
        }

        private void MediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MediumRadioButton.Checked) wt = "m";
        }

        private void LargeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LargeRadioButton.Checked)
            {
                wt = "l";
                RulesTrackBar.Value = 100;
            }

        }

        private void HeavyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HeavyRadioButton.Checked)
            {
                wt = "h";
                RulesTrackBar.Value = 100;
            }
        }

        private void PropRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PropRadioButton.Checked) eng = "p";
        }

        private void TurboRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TurboRadioButton.Checked) eng = "t";
        }

        private void JetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (JetRadioButton.Checked) eng = "j";
        }

        private void HeloRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HeloRadioButton.Checked) eng = "h";
        }

        private void ACTypeTextBox_Validated(object sender, EventArgs e)
        {
            ACType = ACTypeTextBox.Text;
        }

        private void AddParkedButton_Click(object sender, EventArgs e)
        {
            string gate = SelectItem(GatesListBox);
            if (gate.Length != 0)
            {
                string weight; string engine;
                string rule = SelectRule();
                string cr = Environment.NewLine;
                if (wt == "?") weight = SelectWt(); else weight = wt;
                if (eng == "?") engine = SelectEngine(); else engine = eng;
                string command = "add " + rule + " " + weight + " " + engine + " @" + gate + " ";
                if (ACType.Length != 0) command += " " + ACType;
                if ((ShowParkHxCheckBox.Checked) && (AddParkedButton.Text.Length != 0))
                    AddParkedTextBox.Text += cr + command;
                else
                    AddParkedTextBox.Text = command;
                Clipboard.SetText(command);
            }
            else MessageBox.Show("You need at least one gate in list box to create a valid command.");
        }

        private void AddApprButton_Click(object sender, EventArgs e)
        {
            string runway = SelectItem(RWYListBox);
            if (runway.Length != 0)
            {
                string weight; string engine;
                string rule = SelectRule();
                string cr = Environment.NewLine;
                if (wt == "?") weight = SelectWt(); else weight = wt;
                if (eng == "?") engine = SelectEngine(); else engine = eng;
                string command = "add " + rule + " " + weight + " " + engine + " " + runway + " " + distance;
                if (ACType.Length != 0) command += " " + ACType;
                if ((ShowAppHxCheckBox.Checked) && (AddApprTextBox.Text.Length != 0))
                    AddApprTextBox.Text += cr + command;
                else
                    AddApprTextBox.Text = command;
                Clipboard.SetText(command);
            }
            else MessageBox.Show("You need at least one runway in list box to create a valid command.");
        }

        private void AnyWtRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            wt = "?";
        }

        private void AnyEngineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            eng = "?";
        }

        private string SelectEngine()
        {
            int test = RandomNumber();
            string result = string.Empty;
            if (test <= 25) result = "p";
            if (test > 25) result = "t";
            if (test > 50) result = "j";
            if (test > 75) result = "h";
            return result;
        }

        private string SelectWt()
        {
            int test = RandomNumber();
            string result = string.Empty;
            if (test > 25) result = "s";
            if (test > 25) result = "m";
            if (test > 50) result = "l";
            if (test > 75) result = "h";
            return result;
        }

        private string SelectRule()
        {
            if (RandomNumber() <= RulesTrackBar.Value) return "i"; else return "v";
        }

        private string SelectItem(ListBox listBox)
        {
            int listCount = listBox.Items.Count;
            string result = string.Empty;
            if (listCount != 0)
            {
                int selectedCount = listBox.SelectedItems.Count;
                int test = RandomNumber(); int i = 0; int incr;
                bool itemFound = false; 
                switch (selectedCount)
                {
                    case 1:
                        result = listBox.SelectedItem.ToString();
                        break;
                    case 0:
                        incr = 100 / listCount;
                        foreach (string sItem in listBox.Items)
                        {
                            i += incr;
                            if ((i > test) & !itemFound)
                            {
                                result = sItem.ToString();
                                itemFound = true;
                            }
                        }
                        break;
                    default:
                        incr = 100 / selectedCount;
                        foreach (string sItem in listBox.SelectedItems)
                        {
                            i += incr;
                            if ((i > test) & !itemFound)
                            {
                                result = sItem.ToString();
                                itemFound = true;
                            }
                        }
                        break;
                }
            }
            return result;
        }


        private void DistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            distance = DistanceNumericUpDown.Value.ToString();
            if (distance.Length == 0)
            {
                MessageBox.Show("This entry cannot be blank.");
                distance = "10";
                DistanceNumericUpDown.Value = 10;
            }
        }

        private void ShowAppHxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string cr = Environment.NewLine;
            if (ShowAppHxCheckBox.Checked)
            {
                AddApprTextBox.Multiline = true;
                AddApprTextBox.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                AddApprTextBox.Multiline = false;
                AddApprTextBox.ScrollBars = ScrollBars.None;
                int Loc1 = AddApprTextBox.Text.LastIndexOf(cr);
                if (Loc1 != -1)
                {
                    Loc1 += cr.Length;
                    AddApprTextBox.Text = AddApprTextBox.Text.Substring(Loc1, AddApprTextBox.TextLength - Loc1);
                }
            }
        }

        private void ShowParkHxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string cr = Environment.NewLine;
            if (ShowParkHxCheckBox.Checked)
            {
                AddParkedTextBox.Multiline = true;
                AddParkedTextBox.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                AddParkedTextBox.Multiline = false;
                AddParkedTextBox.ScrollBars = ScrollBars.None;
                int Loc1 = AddParkedTextBox.Text.LastIndexOf(cr);
                if (Loc1 != -1)
                {
                    Loc1 += cr.Length;
                    AddParkedTextBox.Text = AddParkedTextBox.Text.Substring(Loc1, AddParkedTextBox.TextLength - Loc1);
                }
            }
        }
    }
}
