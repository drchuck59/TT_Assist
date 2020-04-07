using System;
using System.Windows.Forms;
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
            RWYListBox.Items.Add(RWYTextBox.Text);
        }

        private void DelRWYButton_Click(object sender, EventArgs e)
        {
            if (RWYListBox.SelectedIndex != -1)
                RWYListBox.Items.RemoveAt(RWYListBox.SelectedIndex);
        }

        private void GateAddButton_Click(object sender, EventArgs e)
        {
            GatesListBox.Items.Add(GatesTextBox.Text);
        }

        private void DelGateButton_Click(object sender, EventArgs e)
        {
            if (GatesListBox.SelectedIndex != -1)
                GatesListBox.Items.RemoveAt(GatesListBox.SelectedIndex);
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
            if (LargeRadioButton.Checked) wt = "l";
        }

        private void HeavyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HeavyRadioButton.Checked) wt = "h";
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
            string weight; string engine;
            string rule = SelectRule();
            if (wt == "?") weight = SelectWt(); else weight = wt;
            if (eng == "?") engine = SelectEngine(); else engine = eng;
            AddParkedTextBox.Text = "add " + rule + " " + weight + " " + engine + " @" + gate;
            if (ACType.Length != 0) AddParkedTextBox.Text += " " + ACType;
            Clipboard.SetText(AddParkedTextBox.Text);
        }

        private void AddApprButton_Click(object sender, EventArgs e)
        {
            string runway = SelectItem(RWYListBox);
            string weight; string engine;
            string rule = SelectRule();
            if (wt == "?") weight = SelectWt(); else weight = wt;
            if (eng == "?") engine = SelectEngine(); else engine = eng;
            AddApprTextBox.Text = "add " + rule + " " + weight + " " + engine + " " + runway + " " + distance;
            if (ACType.Length != 0) AddApprTextBox.Text += " " + ACType;
            Clipboard.SetText(AddApprTextBox.Text);
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
                int test = RandomNumber(); int i = 0; int incr = 0;
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
            else MessageBox.Show("You need at least one runway in list box to create a valid command.");
            return result;
        }


        private void DistanceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            distance = DistanceNumericUpDown.Value.ToString();
        }
    }
}
