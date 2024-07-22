namespace DominoCell
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            labelKicker1Result = new Label();
            label1 = new Label();
            pictureBoxKicker1ROI = new PictureBox();
            panel3 = new Panel();
            labelKicker2Result = new Label();
            label2 = new Label();
            pictureBoxKicker2ROI = new PictureBox();
            panel4 = new Panel();
            labelKicker3Result = new Label();
            label3 = new Label();
            pictureBoxKicker3ROI = new PictureBox();
            panel5 = new Panel();
            groupBoxCamera = new GroupBox();
            buttonRunML = new Button();
            checkBoxRunDataCollection = new CheckBox();
            checkBoxRunML = new CheckBox();
            buttonTakePhoto = new Button();
            buttonCamStart = new Button();
            comboBoxCameraSelect = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBoxRunMode = new GroupBox();
            checkBoxRunMode = new CheckBox();
            buttonRunMode = new Button();
            groupBoxKicker3 = new GroupBox();
            label7 = new Label();
            numericUpDownKickerOut3Delay = new NumericUpDown();
            checkBoxKicker3 = new CheckBox();
            buttonKicker3 = new Button();
            groupBoxKicker2 = new GroupBox();
            label6 = new Label();
            numericUpDownKickerOut2Delay = new NumericUpDown();
            checkBoxKicker2 = new CheckBox();
            buttonKicker2 = new Button();
            groupBoxKicker1 = new GroupBox();
            label5 = new Label();
            numericUpDownKickerOut1Delay = new NumericUpDown();
            checkBoxKicker1 = new CheckBox();
            buttonKicker1 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            pictureBoxLiveView = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKicker1ROI).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKicker2ROI).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKicker3ROI).BeginInit();
            groupBoxCamera.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBoxRunMode.SuspendLayout();
            groupBoxKicker3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKickerOut3Delay).BeginInit();
            groupBoxKicker2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKickerOut2Delay).BeginInit();
            groupBoxKicker1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKickerOut1Delay).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLiveView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(886, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBoxCamera, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(886, 503);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 1);
            tableLayoutPanel2.Controls.Add(panel5, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(534, 123);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(349, 377);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelKicker1Result);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBoxKicker1ROI);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 182);
            panel2.TabIndex = 0;
            // 
            // labelKicker1Result
            // 
            labelKicker1Result.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelKicker1Result.AutoSize = true;
            labelKicker1Result.BackColor = Color.Silver;
            labelKicker1Result.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelKicker1Result.Location = new Point(0, 167);
            labelKicker1Result.Name = "labelKicker1Result";
            labelKicker1Result.Size = new Size(35, 15);
            labelKicker1Result.TabIndex = 2;
            labelKicker1Result.Text = "good";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Kicker 1 ROI:";
            // 
            // pictureBoxKicker1ROI
            // 
            pictureBoxKicker1ROI.Dock = DockStyle.Fill;
            pictureBoxKicker1ROI.Location = new Point(0, 0);
            pictureBoxKicker1ROI.Name = "pictureBoxKicker1ROI";
            pictureBoxKicker1ROI.Size = new Size(168, 182);
            pictureBoxKicker1ROI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxKicker1ROI.TabIndex = 0;
            pictureBoxKicker1ROI.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelKicker2Result);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBoxKicker2ROI);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(177, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(169, 182);
            panel3.TabIndex = 1;
            // 
            // labelKicker2Result
            // 
            labelKicker2Result.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelKicker2Result.AutoSize = true;
            labelKicker2Result.BackColor = Color.Silver;
            labelKicker2Result.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelKicker2Result.Location = new Point(0, 167);
            labelKicker2Result.Name = "labelKicker2Result";
            labelKicker2Result.Size = new Size(35, 15);
            labelKicker2Result.TabIndex = 3;
            labelKicker2Result.Text = "good";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Kicker 2 ROI:";
            // 
            // pictureBoxKicker2ROI
            // 
            pictureBoxKicker2ROI.Dock = DockStyle.Fill;
            pictureBoxKicker2ROI.Location = new Point(0, 0);
            pictureBoxKicker2ROI.Name = "pictureBoxKicker2ROI";
            pictureBoxKicker2ROI.Size = new Size(169, 182);
            pictureBoxKicker2ROI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxKicker2ROI.TabIndex = 0;
            pictureBoxKicker2ROI.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(labelKicker3Result);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBoxKicker3ROI);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 191);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 183);
            panel4.TabIndex = 2;
            // 
            // labelKicker3Result
            // 
            labelKicker3Result.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelKicker3Result.AutoSize = true;
            labelKicker3Result.BackColor = Color.Silver;
            labelKicker3Result.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelKicker3Result.Location = new Point(0, 168);
            labelKicker3Result.Name = "labelKicker3Result";
            labelKicker3Result.Size = new Size(35, 15);
            labelKicker3Result.TabIndex = 4;
            labelKicker3Result.Text = "good";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 3;
            label3.Text = "Kicker 3 ROI:";
            // 
            // pictureBoxKicker3ROI
            // 
            pictureBoxKicker3ROI.Dock = DockStyle.Fill;
            pictureBoxKicker3ROI.Location = new Point(0, 0);
            pictureBoxKicker3ROI.Name = "pictureBoxKicker3ROI";
            pictureBoxKicker3ROI.Size = new Size(168, 183);
            pictureBoxKicker3ROI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxKicker3ROI.TabIndex = 0;
            pictureBoxKicker3ROI.TabStop = false;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(177, 191);
            panel5.Name = "panel5";
            panel5.Size = new Size(169, 183);
            panel5.TabIndex = 3;
            // 
            // groupBoxCamera
            // 
            groupBoxCamera.Controls.Add(buttonRunML);
            groupBoxCamera.Controls.Add(checkBoxRunDataCollection);
            groupBoxCamera.Controls.Add(checkBoxRunML);
            groupBoxCamera.Controls.Add(buttonTakePhoto);
            groupBoxCamera.Controls.Add(buttonCamStart);
            groupBoxCamera.Controls.Add(comboBoxCameraSelect);
            groupBoxCamera.Dock = DockStyle.Fill;
            groupBoxCamera.Location = new Point(534, 3);
            groupBoxCamera.Name = "groupBoxCamera";
            groupBoxCamera.Size = new Size(349, 114);
            groupBoxCamera.TabIndex = 1;
            groupBoxCamera.TabStop = false;
            groupBoxCamera.Text = "Camera";
            // 
            // buttonRunML
            // 
            buttonRunML.Location = new Point(230, 74);
            buttonRunML.Name = "buttonRunML";
            buttonRunML.Size = new Size(116, 23);
            buttonRunML.TabIndex = 5;
            buttonRunML.Text = "Run ML";
            buttonRunML.UseVisualStyleBackColor = true;
            buttonRunML.Click += buttonRunML_Click;
            // 
            // checkBoxRunDataCollection
            // 
            checkBoxRunDataCollection.AutoSize = true;
            checkBoxRunDataCollection.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxRunDataCollection.Location = new Point(83, 78);
            checkBoxRunDataCollection.Name = "checkBoxRunDataCollection";
            checkBoxRunDataCollection.Size = new Size(141, 21);
            checkBoxRunDataCollection.TabIndex = 4;
            checkBoxRunDataCollection.Text = "Run Data Collection";
            checkBoxRunDataCollection.UseVisualStyleBackColor = true;
            checkBoxRunDataCollection.CheckedChanged += checkBoxRunDataCollection_CheckedChanged;
            // 
            // checkBoxRunML
            // 
            checkBoxRunML.AutoSize = true;
            checkBoxRunML.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxRunML.Location = new Point(6, 78);
            checkBoxRunML.Name = "checkBoxRunML";
            checkBoxRunML.Size = new Size(71, 21);
            checkBoxRunML.TabIndex = 3;
            checkBoxRunML.Text = "Run ML";
            checkBoxRunML.UseVisualStyleBackColor = true;
            checkBoxRunML.CheckedChanged += checkBoxRunML_CheckedChanged;
            // 
            // buttonTakePhoto
            // 
            buttonTakePhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonTakePhoto.Location = new Point(202, 48);
            buttonTakePhoto.Name = "buttonTakePhoto";
            buttonTakePhoto.Size = new Size(144, 23);
            buttonTakePhoto.TabIndex = 2;
            buttonTakePhoto.Text = "Take Photo";
            buttonTakePhoto.UseVisualStyleBackColor = true;
            buttonTakePhoto.Click += buttonTakePhoto_Click;
            // 
            // buttonCamStart
            // 
            buttonCamStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCamStart.Location = new Point(3, 47);
            buttonCamStart.Name = "buttonCamStart";
            buttonCamStart.Size = new Size(144, 25);
            buttonCamStart.TabIndex = 1;
            buttonCamStart.Text = "Start Camera";
            buttonCamStart.UseVisualStyleBackColor = true;
            buttonCamStart.Click += buttonCamStart_Click;
            // 
            // comboBoxCameraSelect
            // 
            comboBoxCameraSelect.Dock = DockStyle.Top;
            comboBoxCameraSelect.FormattingEnabled = true;
            comboBoxCameraSelect.Location = new Point(3, 19);
            comboBoxCameraSelect.Name = "comboBoxCameraSelect";
            comboBoxCameraSelect.Size = new Size(343, 23);
            comboBoxCameraSelect.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(groupBoxRunMode, 3, 0);
            tableLayoutPanel3.Controls.Add(groupBoxKicker3, 2, 0);
            tableLayoutPanel3.Controls.Add(groupBoxKicker2, 1, 0);
            tableLayoutPanel3.Controls.Add(groupBoxKicker1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(525, 114);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBoxRunMode
            // 
            groupBoxRunMode.Controls.Add(checkBoxRunMode);
            groupBoxRunMode.Controls.Add(buttonRunMode);
            groupBoxRunMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxRunMode.Location = new Point(396, 3);
            groupBoxRunMode.Name = "groupBoxRunMode";
            groupBoxRunMode.Size = new Size(125, 100);
            groupBoxRunMode.TabIndex = 3;
            groupBoxRunMode.TabStop = false;
            groupBoxRunMode.Text = "Run Mode";
            // 
            // checkBoxRunMode
            // 
            checkBoxRunMode.AutoSize = true;
            checkBoxRunMode.Dock = DockStyle.Top;
            checkBoxRunMode.Font = new Font("Segoe UI", 9.75F);
            checkBoxRunMode.Location = new Point(3, 19);
            checkBoxRunMode.Name = "checkBoxRunMode";
            checkBoxRunMode.Size = new Size(119, 21);
            checkBoxRunMode.TabIndex = 1;
            checkBoxRunMode.Text = "State";
            checkBoxRunMode.UseVisualStyleBackColor = true;
            checkBoxRunMode.CheckedChanged += checkBoxRunMode_CheckedChanged;
            // 
            // buttonRunMode
            // 
            buttonRunMode.Dock = DockStyle.Bottom;
            buttonRunMode.Font = new Font("Segoe UI", 12F);
            buttonRunMode.Location = new Point(3, 63);
            buttonRunMode.Name = "buttonRunMode";
            buttonRunMode.Size = new Size(119, 34);
            buttonRunMode.TabIndex = 0;
            buttonRunMode.Text = "Test";
            buttonRunMode.UseVisualStyleBackColor = true;
            buttonRunMode.Click += buttonRunMode_Click;
            // 
            // groupBoxKicker3
            // 
            groupBoxKicker3.Controls.Add(label7);
            groupBoxKicker3.Controls.Add(numericUpDownKickerOut3Delay);
            groupBoxKicker3.Controls.Add(checkBoxKicker3);
            groupBoxKicker3.Controls.Add(buttonKicker3);
            groupBoxKicker3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxKicker3.Location = new Point(265, 3);
            groupBoxKicker3.Name = "groupBoxKicker3";
            groupBoxKicker3.Size = new Size(125, 100);
            groupBoxKicker3.TabIndex = 2;
            groupBoxKicker3.TabStop = false;
            groupBoxKicker3.Text = "Kicker3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 43);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 5;
            label7.Text = "Delay (ms)";
            // 
            // numericUpDownKickerOut3Delay
            // 
            numericUpDownKickerOut3Delay.Location = new Point(2, 39);
            numericUpDownKickerOut3Delay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownKickerOut3Delay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKickerOut3Delay.Name = "numericUpDownKickerOut3Delay";
            numericUpDownKickerOut3Delay.Size = new Size(55, 23);
            numericUpDownKickerOut3Delay.TabIndex = 4;
            numericUpDownKickerOut3Delay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKickerOut3Delay.ValueChanged += numericUpDownKickerOut3Delay_ValueChanged;
            // 
            // checkBoxKicker3
            // 
            checkBoxKicker3.AutoSize = true;
            checkBoxKicker3.Dock = DockStyle.Top;
            checkBoxKicker3.Font = new Font("Segoe UI", 9.75F);
            checkBoxKicker3.Location = new Point(3, 19);
            checkBoxKicker3.Name = "checkBoxKicker3";
            checkBoxKicker3.Size = new Size(119, 21);
            checkBoxKicker3.TabIndex = 1;
            checkBoxKicker3.Text = "State";
            checkBoxKicker3.UseVisualStyleBackColor = true;
            checkBoxKicker3.CheckedChanged += checkBoxKicker3_CheckedChanged;
            // 
            // buttonKicker3
            // 
            buttonKicker3.Dock = DockStyle.Bottom;
            buttonKicker3.Font = new Font("Segoe UI", 12F);
            buttonKicker3.Location = new Point(3, 63);
            buttonKicker3.Name = "buttonKicker3";
            buttonKicker3.Size = new Size(119, 34);
            buttonKicker3.TabIndex = 0;
            buttonKicker3.Text = "Test";
            buttonKicker3.UseVisualStyleBackColor = true;
            buttonKicker3.Click += buttonKicker3_Click;
            // 
            // groupBoxKicker2
            // 
            groupBoxKicker2.Controls.Add(label6);
            groupBoxKicker2.Controls.Add(numericUpDownKickerOut2Delay);
            groupBoxKicker2.Controls.Add(checkBoxKicker2);
            groupBoxKicker2.Controls.Add(buttonKicker2);
            groupBoxKicker2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxKicker2.Location = new Point(134, 3);
            groupBoxKicker2.Name = "groupBoxKicker2";
            groupBoxKicker2.Size = new Size(125, 100);
            groupBoxKicker2.TabIndex = 1;
            groupBoxKicker2.TabStop = false;
            groupBoxKicker2.Text = "Kicker2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 43);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 5;
            label6.Text = "Delay (ms)";
            // 
            // numericUpDownKickerOut2Delay
            // 
            numericUpDownKickerOut2Delay.Location = new Point(2, 39);
            numericUpDownKickerOut2Delay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownKickerOut2Delay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKickerOut2Delay.Name = "numericUpDownKickerOut2Delay";
            numericUpDownKickerOut2Delay.Size = new Size(55, 23);
            numericUpDownKickerOut2Delay.TabIndex = 4;
            numericUpDownKickerOut2Delay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKickerOut2Delay.ValueChanged += numericUpDownKickerOut2Delay_ValueChanged;
            // 
            // checkBoxKicker2
            // 
            checkBoxKicker2.AutoSize = true;
            checkBoxKicker2.Dock = DockStyle.Top;
            checkBoxKicker2.Font = new Font("Segoe UI", 9.75F);
            checkBoxKicker2.Location = new Point(3, 19);
            checkBoxKicker2.Name = "checkBoxKicker2";
            checkBoxKicker2.Size = new Size(119, 21);
            checkBoxKicker2.TabIndex = 1;
            checkBoxKicker2.Text = "State";
            checkBoxKicker2.UseVisualStyleBackColor = true;
            checkBoxKicker2.CheckedChanged += checkBoxKicker2_CheckedChanged;
            // 
            // buttonKicker2
            // 
            buttonKicker2.Dock = DockStyle.Bottom;
            buttonKicker2.Font = new Font("Segoe UI", 12F);
            buttonKicker2.Location = new Point(3, 63);
            buttonKicker2.Name = "buttonKicker2";
            buttonKicker2.Size = new Size(119, 34);
            buttonKicker2.TabIndex = 0;
            buttonKicker2.Text = "Test";
            buttonKicker2.UseVisualStyleBackColor = true;
            buttonKicker2.Click += buttonKicker2_Click;
            // 
            // groupBoxKicker1
            // 
            groupBoxKicker1.Controls.Add(label5);
            groupBoxKicker1.Controls.Add(numericUpDownKickerOut1Delay);
            groupBoxKicker1.Controls.Add(checkBoxKicker1);
            groupBoxKicker1.Controls.Add(buttonKicker1);
            groupBoxKicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxKicker1.Location = new Point(3, 3);
            groupBoxKicker1.Name = "groupBoxKicker1";
            groupBoxKicker1.Size = new Size(125, 100);
            groupBoxKicker1.TabIndex = 0;
            groupBoxKicker1.TabStop = false;
            groupBoxKicker1.Text = "Kicker1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 42);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 3;
            label5.Text = "Delay (ms)";
            // 
            // numericUpDownKickerOut1Delay
            // 
            numericUpDownKickerOut1Delay.Location = new Point(3, 38);
            numericUpDownKickerOut1Delay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownKickerOut1Delay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKickerOut1Delay.Name = "numericUpDownKickerOut1Delay";
            numericUpDownKickerOut1Delay.Size = new Size(55, 23);
            numericUpDownKickerOut1Delay.TabIndex = 2;
            numericUpDownKickerOut1Delay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKickerOut1Delay.ValueChanged += numericUpDownKickerOut1Delay_ValueChanged;
            // 
            // checkBoxKicker1
            // 
            checkBoxKicker1.AutoSize = true;
            checkBoxKicker1.Dock = DockStyle.Top;
            checkBoxKicker1.Font = new Font("Segoe UI", 9.75F);
            checkBoxKicker1.Location = new Point(3, 19);
            checkBoxKicker1.Name = "checkBoxKicker1";
            checkBoxKicker1.Size = new Size(119, 21);
            checkBoxKicker1.TabIndex = 1;
            checkBoxKicker1.Text = "State";
            checkBoxKicker1.UseVisualStyleBackColor = true;
            checkBoxKicker1.CheckedChanged += checkBoxKicker1_CheckedChanged;
            // 
            // buttonKicker1
            // 
            buttonKicker1.Dock = DockStyle.Bottom;
            buttonKicker1.Font = new Font("Segoe UI", 12F);
            buttonKicker1.Location = new Point(3, 63);
            buttonKicker1.Name = "buttonKicker1";
            buttonKicker1.Size = new Size(119, 34);
            buttonKicker1.TabIndex = 0;
            buttonKicker1.Text = "Test";
            buttonKicker1.UseVisualStyleBackColor = true;
            buttonKicker1.Click += buttonKicker1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBoxLiveView);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 377);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(-3, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Live View:";
            // 
            // pictureBoxLiveView
            // 
            pictureBoxLiveView.Dock = DockStyle.Fill;
            pictureBoxLiveView.Location = new Point(0, 0);
            pictureBoxLiveView.Name = "pictureBoxLiveView";
            pictureBoxLiveView.Size = new Size(525, 377);
            pictureBoxLiveView.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLiveView.TabIndex = 0;
            pictureBoxLiveView.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 527);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKicker1ROI).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKicker2ROI).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKicker3ROI).EndInit();
            groupBoxCamera.ResumeLayout(false);
            groupBoxCamera.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            groupBoxRunMode.ResumeLayout(false);
            groupBoxRunMode.PerformLayout();
            groupBoxKicker3.ResumeLayout(false);
            groupBoxKicker3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKickerOut3Delay).EndInit();
            groupBoxKicker2.ResumeLayout(false);
            groupBoxKicker2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKickerOut2Delay).EndInit();
            groupBoxKicker1.ResumeLayout(false);
            groupBoxKicker1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKickerOut1Delay).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLiveView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBoxCamera;
        private Button buttonTakePhoto;
        private Button buttonCamStart;
        private ComboBox comboBoxCameraSelect;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBoxKicker1;
        private CheckBox checkBoxKicker1;
        private Button buttonKicker1;
        private GroupBox groupBoxRunMode;
        private CheckBox checkBoxRunMode;
        private Button buttonRunMode;
        private GroupBox groupBoxKicker3;
        private CheckBox checkBoxKicker3;
        private Button buttonKicker3;
        private GroupBox groupBoxKicker2;
        private CheckBox checkBoxKicker2;
        private Button buttonKicker2;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBoxKicker1ROI;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBoxKicker2ROI;
        private Panel panel4;
        private Label label3;
        private PictureBox pictureBoxKicker3ROI;
        private Panel panel5;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBoxLiveView;
        private CheckBox checkBoxRunML;
        private Label labelKicker1Result;
        private Label labelKicker2Result;
        private Label labelKicker3Result;
        private Label label7;
        private NumericUpDown numericUpDownKickerOut3Delay;
        private Label label6;
        private NumericUpDown numericUpDownKickerOut2Delay;
        private Label label5;
        private NumericUpDown numericUpDownKickerOut1Delay;
        private CheckBox checkBoxRunDataCollection;
        private Button buttonRunML;
    }
}
