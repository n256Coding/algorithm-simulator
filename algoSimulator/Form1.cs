using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace algoSimulator
{
    public partial class Form1 : Form
    {
        int simulatorSpeed = 3000;
        int selectionSortSpeed = 100;
        TextBox[] selectedBox = new TextBox[2];
        int selectedItem;

        int seleSortTickCount = 0;
        bool doTimer = false;
        int[] box1Location = new int[2];
        int[] box2Location = new int[2];
        ToolTip tt = new ToolTip();


        Thread insSortThread;
        Thread selSortThread;
        TextBox[] textBox;
        int key, i, j;
        //Stopwatch watch = new Stopwatch();
        int[] a;
        //a[] = {10, 20, 5, 2, 80, 30, 60, 40, 70, 10};

        public Form1()
        {
            InitializeComponent();
            textBox = new TextBox[8];
        }
        public Form1(String s)
        {
            InitializeComponent();
            textBox = new TextBox[8];
            panelSelectionSort.Visible = true;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            ListViewItem li = new ListViewItem();
            if (e.KeyCode == Keys.Enter)
            {
                int integer;
                bool isNumeric = int.TryParse(txtInput.Text, out integer);
                if(txtInput.Text != "" && isNumeric)
                    lvInput.Items.Add(txtInput.Text); 
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (lvInput.Items.Count != 0)
            {
                a = new int[lvInput.Items.Count];
                for (int b = 0; b < lvInput.Items.Count; b++)
                    a[b] = Convert.ToInt32(lvInput.Items[b].Text);
                gbSimulatorAction.Enabled = true;
                gbOutput.Enabled = true;
                insSortThread = new Thread(delegate ()
                {
                    insertionSort(a);
                });
                selectedItem = 0;
                insSortThread.Start();
                timer1.Enabled = true;
                timer1.Start();
                btnSort.Enabled = false;
                txtInput.Enabled = false;
            }
            else
            {
                MessageBox.Show("You must enter values to sort");
            }
        }

        private void tbSlide_ValueChanged(object sender, EventArgs e)
        {
            lblSimulatorSpeed.Text = Convert.ToString(tbSlide.Value);
            simulatorSpeed = tbSlide.Value;
            timer1.Interval = simulatorSpeed;
        }

        private void insertionSort(int[] A)
        {
            for (j = 1; j < A.Length; j++)
            {
                selectedItem = 1;
                Thread.Sleep(simulatorSpeed);

                selectedItem = 3;
                Thread.Sleep(simulatorSpeed);
                key = A[j];

                selectedItem = 4;
                Thread.Sleep(simulatorSpeed);
                i = j - 1;

                selectedItem = 5;
                Thread.Sleep(simulatorSpeed);
                while (i >= 0 && A[i] > key)
                {

                    selectedItem = 7;
                    Thread.Sleep(simulatorSpeed);
                    A[i + 1] = A[i];

                    selectedItem = 8;
                    Thread.Sleep(simulatorSpeed);
                    i = i - 1;
                    
                }

                selectedItem = 10;
                Thread.Sleep(simulatorSpeed);
                A[i + 1] = key;
                
            }
            selectedItem = 11;
            a = A;
        }

        private void selectionSort(int[] A)
        {
            int n = A.Length;
            int smallest = 0, temp=0;
            for (j = 0; j < n; j++)
            {
                smallest = j;
                selectedItem = 1;
                Thread.Sleep(selectionSortSpeed);
                for (i = j + 1; i < n; i++)
                {
                    if (A[i] < A[smallest])
                    {
                        smallest = i;
                        selectedItem = 2;
                        Thread.Sleep(selectionSortSpeed);
                    }
                }
                selectedItem = 0;
                if (smallest != j)
                {
                    selectedBox[0] = textBox[j];
                    selectedBox[1] = textBox[smallest];
                    box1Location[0] = textBox[j].Left;
                    box1Location[1] = textBox[j].Top;
                    box2Location[0] = textBox[smallest].Left;
                    box2Location[1] = textBox[smallest].Top;

                    doTimer = true;
                    while (doTimer == true)
                        Thread.Sleep(selectionSortSpeed);

                    TextBox tempBox = textBox[j];
                    textBox[smallest] = tempBox;
                    tempBox = textBox[smallest];
                }
                temp = A[j];
                A[j] = A[smallest];
                A[smallest] = temp;

                selectedItem = 3;
                Thread.Sleep(selectionSortSpeed);
            }
            MessageBox.Show("Sorted succesfully using selection sort!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvAlgo.Items.Add("int key, i;");                            // (0
            lvAlgo.Items.Add("for (int j = 1; j < A.Length; j++)");     // (1
            lvAlgo.Items.Add("{");                                      // (2
            lvAlgo.Items.Add("      key = A[j];");                      // (3
            lvAlgo.Items.Add("      i = j - 1;");                       // (4
            lvAlgo.Items.Add("      while (i >= 0 && A[i] > key)");     // (5
            lvAlgo.Items.Add("      {");                                // (6
            lvAlgo.Items.Add("          A[i + 1] = A[i];");             // (7
            lvAlgo.Items.Add("          i = i - 1;");                   // (8
            lvAlgo.Items.Add("      }");                                // (9
            lvAlgo.Items.Add("      A[i + 1] = key;");                  // (10
            lvAlgo.Items.Add("}");                                      // (11
            txtInput.Focus();
            textBox[0] = txtArr0;
            textBox[1] = txtArr1;
            textBox[2] = txtArr2;
            textBox[3] = txtArr3;
            textBox[4] = txtArr4;
            textBox[5] = txtArr5;
            textBox[6] = txtArr6;
            textBox[7] = txtArr7;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clearColorLvAlgo();
            lvAlgo.Items[selectedItem].BackColor = Color.LightPink;
            if (selectedItem == 1)
            {
                lblExec.Text = "for (int j = " + j + "; j < " + a.Length + "; j++)";
                if (j < a.Length)
                    lblExec.Text = lblExec.Text + " - True";
                else
                    lblExec.Text = lblExec.Text + " - False";
                lblJ.Text = j.ToString();
                lbOutput.Items.Add(lblExec.Text);
            }
            else if (selectedItem == 3)
            {
                clearColorLvInput(1);
                lvInput.Items[j].Text = "";
                lblKeyValue.Text = a[j].ToString();
                lblCurrentExec.Text = "      key = A[" + j + "]";
                lblKey.Text = a[j].ToString();
                lbOutput.Items.Add(lblCurrentExec.Text);
            }
            else if (selectedItem == 4)
            {
                lblI.Text = (j - 1).ToString();
            }
            else if (selectedItem == 7 && (i >= 0 && a[i] > key))
            {
                lblExec.Text = "      while (" + i + " >= 0 && " + a[i] + " > " + key + ") - True";
                lbOutput.Items.Add(lblExec.Text);
                clearColorLvInput(2);
                lvInput.Items[i].BackColor = Color.LightBlue;
                lvInput.Items[i + 1].Text = lvInput.Items[i].Text;
                lvInput.Items[i].Text = "";
                lvInput.Items[i + 1].BackColor = Color.LightBlue;
                lbOutput.Items.Add("            A[" + (i + 1) + "] = A[" + i + "];");
            }
            else if (selectedItem == 8)
            {
                clearColorLvInput(2);
                if ((i - 1) >= 0)
                    lvInput.Items[i - 1].BackColor = Color.LightBlue;
                lblI.Text = (i - 1).ToString();
                lbOutput.Items.Add("            i = "+(i-1));
            }
            else if (selectedItem == 10)
            {
                if (i == -1)
                    lbOutput.Items.Add("      while (" + i + " >= 0 && " + a[0] + " > " + key + ") - False");
                else
                    lbOutput.Items.Add("      while (" + i + " >= 0 && " + a[i] + " > " + key + ") - False");
                lbOutput.Items.Add("            x");
                lbOutput.Items.Add("            x");
                clearColorLvInput(1);
                lvInput.Items[i + 1].Text = key.ToString();
                lvInput.Items[i + 1].BackColor = Color.Yellow;
                lblKeyValue.Text = "";
                lbOutput.Items.Add("      A[" + (i + 1) + "] = " + key);
            }
            else if (selectedItem == 11)
            {
                lbOutput.Items.Add("for (int j = " + j + "; j < " + a.Length + "; j++) - False");
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("Sorting Compleated According to Insertion Sort Algorithm", "Done!   :-)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lbOutput.TopIndex = lbOutput.Items.Count - 9;
        }

        private void clearColorLvAlgo()
        {
            for (int i = 0; i < lvAlgo.Items.Count; i++)
                lvAlgo.Items[i].BackColor = Color.White;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void timer_selectionSort_Tick(object sender, EventArgs e)
        {
            if (panelSelectionSort.Visible == true)
            {
                if (selectedItem == 1)
                {
                    clearColorBoxes();
                    textBox[j].BackColor = Color.LightPink;
                }
                if (doTimer)
                {
                    if (seleSortTickCount == 0)
                    {
                        selectedBox[0].Top += 1;
                        selectedBox[1].Top -= 1;
                    }
                    if (selectedBox[0].Top < 154 && selectedBox[0].Left <= box1Location[0])
                    {
                        selectedBox[0].Top += 1;
                        selectedBox[1].Top -= 1;
                    }
                    else if (selectedBox[0].Top >= 154 && selectedBox[0].Left <= box2Location[0])
                    {
                        selectedBox[0].Left += 1;
                        selectedBox[1].Left -= 1;
                    }
                    else if (selectedBox[0].Left >= box2Location[0] && selectedBox[0].Top >= box2Location[1])
                    {
                        selectedBox[0].Top -= 1;
                        selectedBox[1].Top += 1;
                    }
                    else
                    {
                        doTimer = false;
                        selectedBox[1].BackColor = Color.LightGreen;
                        seleSortTickCount = 0;
                        clearColorLvInput(4);
                        alignBoxes();
                    }
                    seleSortTickCount++;
                }
            }
        }

        private void clearColorLvInput(int param)
        {
            if (param == 1)
            {
                for (int i = 0; i < lvInput.Items.Count; i++)
                    if (lvInput.Items[i].BackColor == Color.Yellow)
                        lvInput.Items[i].BackColor = Color.White;
            }
            else if (param == 2)
            {
                for (int i = 0; i < lvInput.Items.Count; i++)
                    if (lvInput.Items[i].BackColor == Color.LightBlue)
                        lvInput.Items[i].BackColor = Color.White;
            }
            else if (param == 3)
            {
                for (int i = 0; i < lvInput.Items.Count; i++)
                    if (lvInput.Items[i].BackColor == Color.LightGreen)
                        lvInput.Items[i].BackColor = Color.White;
            }
            else if(param == 4)
            {
                for (int i = 0; i < 8; i++)
                    if (textBox[i].BackColor == Color.LightPink)
                        textBox[i].BackColor = Color.White;
            }
        }

        private void btnSelSort_Click(object sender, EventArgs e)
        {
            panelSelectionSort.Visible = true;
            tt.InitialDelay = 0;
            tt.IsBalloon = false;
            txtArr0.Focus();
            tt.Show("Enter First Number Here", txtArr0, 0);
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            panelSelectionSort.Visible = false;
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            int[] A = new int[8];
            if (checkBoxesFilled())
            {
                if (checkIsNumericForEachBox())
                {
                    for (int i = 0; i < 8; i++)
                        A[i] = Convert.ToInt32(textBox[i].Text);
                    selSortThread = new Thread(delegate ()
                    {
                        selectionSort(A);
                    });
                    selSortThread.Start();
                    btnSelectionSort.Enabled = false;
                }
                else
                    MessageBox.Show("One or More Textboxes have Non-Numeric values, Make them numeric to sort", "Watch It!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("One or More Textbox not filled", "Watch It!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtArr5_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            selectionSortSpeed = trackBarSelectionSort.Value/50;
            lblSelectionSortSpeed.Text = selectionSortSpeed.ToString();
            timer_selectionSort.Interval = selectionSortSpeed;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
            txtInput.Enabled = true;
            btnSort.Enabled = true;
            lvInput.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Length; i++)
                lbOutput.Items.Add(a[i].ToString());
        }

        private void alignBoxes()
        {
            for (int i = 0; i < 8; i++)
                textBox[i].Top = 86;
        }

        private void btnResetSelectionSort_Click(object sender, EventArgs e)
        {
            doTimer = false;
            for (int z = 0; z < 8; z++)
            {
                textBox[z].Text = "";
            }
            btnSelectionSort.Enabled = true;
        }

        private void txtArr0_Leave(object sender, EventArgs e)
        {
            tt.Hide(txtArr0);
        }

        private bool checkBoxesFilled()
        {
            for (int z = 0; z < 8; z++)
            {
                if (textBox[z].Text == "")
                    return false;
            }
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Form1("").Show();
            this.Dispose(false); 
        }

        private bool checkIsNumericForEachBox()
        {
            int checkInt;
            bool isNumeric;
            for (int z = 0; z < 8; z++)
            {
                isNumeric = int.TryParse(textBox[z].Text, out checkInt);
                if (!isNumeric)
                    return false;
            }
            return true;
        }

        private void clearColorBoxes()
        {
            if(txtArr0.BackColor == Color.LightPink)
                txtArr0.BackColor = Color.White;
            if (txtArr1.BackColor == Color.LightPink)
                txtArr1.BackColor = Color.White;
            if (txtArr2.BackColor == Color.LightPink)
                txtArr2.BackColor = Color.White;
            if (txtArr3.BackColor == Color.LightPink)
                txtArr3.BackColor = Color.White;
            if (txtArr4.BackColor == Color.LightPink)
                txtArr4.BackColor = Color.White;
            if (txtArr5.BackColor == Color.LightPink)
                txtArr5.BackColor = Color.White;
            if (txtArr6.BackColor == Color.LightPink)
                txtArr6.BackColor = Color.White;
            if (txtArr7.BackColor == Color.LightPink)
                txtArr7.BackColor = Color.White;
        }
    }
}
