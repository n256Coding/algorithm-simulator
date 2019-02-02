namespace algoSimulator
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
            this.lvInput = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.tbSlide = new System.Windows.Forms.TrackBar();
            this.gbSimulatorInput = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbSimulatorAction = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExec = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblJ = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentExec = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKeyValue = new System.Windows.Forms.Label();
            this.lvAlgo = new System.Windows.Forms.ListView();
            this.lblSimulatorSpeed = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelSelectionSort = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSelectionSortSpeed = new System.Windows.Forms.Label();
            this.trackBarSelectionSort = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.txtArr7 = new System.Windows.Forms.TextBox();
            this.txtArr6 = new System.Windows.Forms.TextBox();
            this.txtArr5 = new System.Windows.Forms.TextBox();
            this.txtArr4 = new System.Windows.Forms.TextBox();
            this.txtArr3 = new System.Windows.Forms.TextBox();
            this.txtArr2 = new System.Windows.Forms.TextBox();
            this.txtArr1 = new System.Windows.Forms.TextBox();
            this.txtArr0 = new System.Windows.Forms.TextBox();
            this.timer_selectionSort = new System.Windows.Forms.Timer(this.components);
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnSelSort = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlide)).BeginInit();
            this.gbSimulatorInput.SuspendLayout();
            this.gbSimulatorAction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.panelSelectionSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSelectionSort)).BeginInit();
            this.SuspendLayout();
            // 
            // lvInput
            // 
            this.lvInput.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInput.Location = new System.Drawing.Point(12, 43);
            this.lvInput.Name = "lvInput";
            this.lvInput.Size = new System.Drawing.Size(792, 122);
            this.lvInput.TabIndex = 0;
            this.lvInput.TileSize = new System.Drawing.Size(60, 20);
            this.lvInput.UseCompatibleStateImageBehavior = false;
            this.lvInput.View = System.Windows.Forms.View.Tile;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key: ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(17, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(166, 20);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(205, 18);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(87, 41);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // tbSlide
            // 
            this.tbSlide.Location = new System.Drawing.Point(19, 203);
            this.tbSlide.Maximum = 10000;
            this.tbSlide.Minimum = 450;
            this.tbSlide.Name = "tbSlide";
            this.tbSlide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSlide.RightToLeftLayout = true;
            this.tbSlide.Size = new System.Drawing.Size(170, 45);
            this.tbSlide.TabIndex = 5;
            this.tbSlide.TickFrequency = 1000;
            this.tbSlide.Value = 1000;
            this.tbSlide.ValueChanged += new System.EventHandler(this.tbSlide_ValueChanged);
            // 
            // gbSimulatorInput
            // 
            this.gbSimulatorInput.Controls.Add(this.btnReset);
            this.gbSimulatorInput.Controls.Add(this.txtInput);
            this.gbSimulatorInput.Controls.Add(this.btnSort);
            this.gbSimulatorInput.Location = new System.Drawing.Point(217, 23);
            this.gbSimulatorInput.Name = "gbSimulatorInput";
            this.gbSimulatorInput.Size = new System.Drawing.Size(804, 89);
            this.gbSimulatorInput.TabIndex = 6;
            this.gbSimulatorInput.TabStop = false;
            this.gbSimulatorInput.Text = "Simulator Input";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(713, 36);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 42);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbSimulatorAction
            // 
            this.gbSimulatorAction.Controls.Add(this.label8);
            this.gbSimulatorAction.Controls.Add(this.label6);
            this.gbSimulatorAction.Controls.Add(this.label4);
            this.gbSimulatorAction.Controls.Add(this.groupBox1);
            this.gbSimulatorAction.Controls.Add(this.lblCurrentExec);
            this.gbSimulatorAction.Controls.Add(this.label2);
            this.gbSimulatorAction.Controls.Add(this.lblKeyValue);
            this.gbSimulatorAction.Controls.Add(this.lvAlgo);
            this.gbSimulatorAction.Controls.Add(this.lblSimulatorSpeed);
            this.gbSimulatorAction.Controls.Add(this.lvInput);
            this.gbSimulatorAction.Controls.Add(this.tbSlide);
            this.gbSimulatorAction.Controls.Add(this.label1);
            this.gbSimulatorAction.Enabled = false;
            this.gbSimulatorAction.Location = new System.Drawing.Point(217, 118);
            this.gbSimulatorAction.Name = "gbSimulatorAction";
            this.gbSimulatorAction.Size = new System.Drawing.Size(1092, 318);
            this.gbSimulatorAction.TabIndex = 7;
            this.gbSimulatorAction.TabStop = false;
            this.gbSimulatorAction.Text = "Simulator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(925, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Algorithm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Slow";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fast";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblExec);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblI);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblJ);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(495, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 134);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // lblExec
            // 
            this.lblExec.AutoSize = true;
            this.lblExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExec.Location = new System.Drawing.Point(58, 102);
            this.lblExec.Name = "lblExec";
            this.lblExec.Size = new System.Drawing.Size(14, 20);
            this.lblExec.TabIndex = 7;
            this.lblExec.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "exec :";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.Location = new System.Drawing.Point(58, 75);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(14, 20);
            this.lblI.TabIndex = 5;
            this.lblI.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "i :";
            // 
            // lblJ
            // 
            this.lblJ.AutoSize = true;
            this.lblJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ.Location = new System.Drawing.Point(58, 48);
            this.lblJ.Name = "lblJ";
            this.lblJ.Size = new System.Drawing.Size(14, 20);
            this.lblJ.TabIndex = 3;
            this.lblJ.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "j :";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(58, 20);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(14, 20);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "key :";
            // 
            // lblCurrentExec
            // 
            this.lblCurrentExec.AutoSize = true;
            this.lblCurrentExec.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentExec.Location = new System.Drawing.Point(245, 18);
            this.lblCurrentExec.Name = "lblCurrentExec";
            this.lblCurrentExec.Size = new System.Drawing.Size(54, 22);
            this.lblCurrentExec.TabIndex = 11;
            this.lblCurrentExec.Text = "Key: ";
            this.lblCurrentExec.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Key: ";
            this.label2.Visible = false;
            // 
            // lblKeyValue
            // 
            this.lblKeyValue.AutoSize = true;
            this.lblKeyValue.BackColor = System.Drawing.Color.Yellow;
            this.lblKeyValue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyValue.Location = new System.Drawing.Point(109, 18);
            this.lblKeyValue.Name = "lblKeyValue";
            this.lblKeyValue.Size = new System.Drawing.Size(16, 22);
            this.lblKeyValue.TabIndex = 9;
            this.lblKeyValue.Text = "-";
            // 
            // lvAlgo
            // 
            this.lvAlgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAlgo.Location = new System.Drawing.Point(815, 51);
            this.lvAlgo.Name = "lvAlgo";
            this.lvAlgo.Size = new System.Drawing.Size(264, 261);
            this.lvAlgo.TabIndex = 7;
            this.lvAlgo.UseCompatibleStateImageBehavior = false;
            this.lvAlgo.View = System.Windows.Forms.View.List;
            // 
            // lblSimulatorSpeed
            // 
            this.lblSimulatorSpeed.AutoSize = true;
            this.lblSimulatorSpeed.Location = new System.Drawing.Point(80, 178);
            this.lblSimulatorSpeed.Name = "lblSimulatorSpeed";
            this.lblSimulatorSpeed.Size = new System.Drawing.Size(31, 13);
            this.lblSimulatorSpeed.TabIndex = 6;
            this.lblSimulatorSpeed.Text = "1000";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.lbOutput);
            this.gbOutput.Enabled = false;
            this.gbOutput.Location = new System.Drawing.Point(217, 442);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(1092, 196);
            this.gbOutput.TabIndex = 8;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // lbOutput
            // 
            this.lbOutput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 18;
            this.lbOutput.Location = new System.Drawing.Point(19, 19);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(555, 166);
            this.lbOutput.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1072, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 27);
            this.label10.TabIndex = 16;
            this.label10.Text = "Insertion Sort Simulator";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panelSelectionSort
            // 
            this.panelSelectionSort.Controls.Add(this.button1);
            this.panelSelectionSort.Controls.Add(this.label12);
            this.panelSelectionSort.Controls.Add(this.label13);
            this.panelSelectionSort.Controls.Add(this.lblSelectionSortSpeed);
            this.panelSelectionSort.Controls.Add(this.trackBarSelectionSort);
            this.panelSelectionSort.Controls.Add(this.label11);
            this.panelSelectionSort.Controls.Add(this.btnSelectionSort);
            this.panelSelectionSort.Controls.Add(this.txtArr7);
            this.panelSelectionSort.Controls.Add(this.txtArr6);
            this.panelSelectionSort.Controls.Add(this.txtArr5);
            this.panelSelectionSort.Controls.Add(this.txtArr4);
            this.panelSelectionSort.Controls.Add(this.txtArr3);
            this.panelSelectionSort.Controls.Add(this.txtArr2);
            this.panelSelectionSort.Controls.Add(this.txtArr1);
            this.panelSelectionSort.Controls.Add(this.txtArr0);
            this.panelSelectionSort.Location = new System.Drawing.Point(217, 23);
            this.panelSelectionSort.Name = "panelSelectionSort";
            this.panelSelectionSort.Size = new System.Drawing.Size(1092, 615);
            this.panelSelectionSort.TabIndex = 17;
            this.panelSelectionSort.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Slow";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(380, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Fast";
            // 
            // lblSelectionSortSpeed
            // 
            this.lblSelectionSortSpeed.AutoSize = true;
            this.lblSelectionSortSpeed.Location = new System.Drawing.Point(305, 216);
            this.lblSelectionSortSpeed.Name = "lblSelectionSortSpeed";
            this.lblSelectionSortSpeed.Size = new System.Drawing.Size(25, 13);
            this.lblSelectionSortSpeed.TabIndex = 19;
            this.lblSelectionSortSpeed.Text = "100";
            // 
            // trackBarSelectionSort
            // 
            this.trackBarSelectionSort.Location = new System.Drawing.Point(244, 241);
            this.trackBarSelectionSort.Maximum = 10000;
            this.trackBarSelectionSort.Minimum = 450;
            this.trackBarSelectionSort.Name = "trackBarSelectionSort";
            this.trackBarSelectionSort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarSelectionSort.RightToLeftLayout = true;
            this.trackBarSelectionSort.Size = new System.Drawing.Size(170, 45);
            this.trackBarSelectionSort.TabIndex = 18;
            this.trackBarSelectionSort.TickFrequency = 1000;
            this.trackBarSelectionSort.Value = 1000;
            this.trackBarSelectionSort.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(833, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 27);
            this.label11.TabIndex = 17;
            this.label11.Text = "Selection Sort Simulator";
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(440, 226);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(112, 35);
            this.btnSelectionSort.TabIndex = 8;
            this.btnSelectionSort.Text = "Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // txtArr7
            // 
            this.txtArr7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArr7.Location = new System.Drawing.Point(597, 84);
            this.txtArr7.Name = "txtArr7";
            this.txtArr7.Size = new System.Drawing.Size(53, 26);
            this.txtArr7.TabIndex = 7;
            // 
            // txtArr6
            // 
            this.txtArr6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArr6.Location = new System.Drawing.Point(538, 84);
            this.txtArr6.Name = "txtArr6";
            this.txtArr6.Size = new System.Drawing.Size(53, 26);
            this.txtArr6.TabIndex = 6;
            // 
            // txtArr5
            // 
            this.txtArr5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArr5.Location = new System.Drawing.Point(479, 84);
            this.txtArr5.Name = "txtArr5";
            this.txtArr5.Size = new System.Drawing.Size(53, 26);
            this.txtArr5.TabIndex = 5;
            this.txtArr5.TextChanged += new System.EventHandler(this.txtArr5_TextChanged);
            // 
            // txtArr4
            // 
            this.txtArr4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArr4.Location = new System.Drawing.Point(420, 84);
            this.txtArr4.Name = "txtArr4";
            this.txtArr4.Size = new System.Drawing.Size(53, 26);
            this.txtArr4.TabIndex = 4;
            // 
            // txtArr3
            // 
            this.txtArr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArr3.Location = new System.Drawing.Point(362, 84);
            this.txtArr3.Name = "txtArr3";
            this.txtArr3.Size = new System.Drawing.Size(53, 26);
            this.txtArr3.TabIndex = 3;
            // 
            // txtArr2
            // 
            this.txtArr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArr2.Location = new System.Drawing.Point(303, 84);
            this.txtArr2.Name = "txtArr2";
            this.txtArr2.Size = new System.Drawing.Size(53, 26);
            this.txtArr2.TabIndex = 2;
            // 
            // txtArr1
            // 
            this.txtArr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArr1.Location = new System.Drawing.Point(244, 84);
            this.txtArr1.Name = "txtArr1";
            this.txtArr1.Size = new System.Drawing.Size(53, 26);
            this.txtArr1.TabIndex = 1;
            // 
            // txtArr0
            // 
            this.txtArr0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArr0.Location = new System.Drawing.Point(185, 84);
            this.txtArr0.Name = "txtArr0";
            this.txtArr0.Size = new System.Drawing.Size(53, 26);
            this.txtArr0.TabIndex = 0;
            this.txtArr0.Leave += new System.EventHandler(this.txtArr0_Leave);
            // 
            // timer_selectionSort
            // 
            this.timer_selectionSort.Enabled = true;
            this.timer_selectionSort.Interval = 10;
            this.timer_selectionSort.Tick += new System.EventHandler(this.timer_selectionSort_Tick);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(27, 59);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(166, 61);
            this.btnInsertionSort.TabIndex = 18;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnSelSort
            // 
            this.btnSelSort.Location = new System.Drawing.Point(27, 146);
            this.btnSelSort.Name = "btnSelSort";
            this.btnSelSort.Size = new System.Drawing.Size(166, 61);
            this.btnSelSort.TabIndex = 19;
            this.btnSelSort.Text = "Selection Sort";
            this.btnSelSort.UseVisualStyleBackColor = true;
            this.btnSelSort.Click += new System.EventHandler(this.btnSelSort_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(15, 564);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "DIT No: IT15105226";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(15, 591);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Name: S.P.N.S. Wickramasinghe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 22);
            this.button1.TabIndex = 22;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 650);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSelSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.panelSelectionSort);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbSimulatorAction);
            this.Controls.Add(this.gbSimulatorInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAA Algorithm Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSlide)).EndInit();
            this.gbSimulatorInput.ResumeLayout(false);
            this.gbSimulatorInput.PerformLayout();
            this.gbSimulatorAction.ResumeLayout(false);
            this.gbSimulatorAction.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.panelSelectionSort.ResumeLayout(false);
            this.panelSelectionSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSelectionSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TrackBar tbSlide;
        private System.Windows.Forms.GroupBox gbSimulatorInput;
        private System.Windows.Forms.GroupBox gbSimulatorAction;
        private System.Windows.Forms.Label lblSimulatorSpeed;
        private System.Windows.Forms.ListView lvAlgo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Label lblKeyValue;
        private System.Windows.Forms.Label lblCurrentExec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblExec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelSelectionSort;
        private System.Windows.Forms.TextBox txtArr0;
        private System.Windows.Forms.Timer timer_selectionSort;
        private System.Windows.Forms.TextBox txtArr7;
        private System.Windows.Forms.TextBox txtArr6;
        private System.Windows.Forms.TextBox txtArr5;
        private System.Windows.Forms.TextBox txtArr4;
        private System.Windows.Forms.TextBox txtArr3;
        private System.Windows.Forms.TextBox txtArr2;
        private System.Windows.Forms.TextBox txtArr1;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnSelSort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSelectionSortSpeed;
        private System.Windows.Forms.TrackBar trackBarSelectionSort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
    }
}

