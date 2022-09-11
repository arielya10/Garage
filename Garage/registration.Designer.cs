using System;

namespace Final
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.label1 = new System.Windows.Forms.Label();
            this.selection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wheelSize = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.TextBox();
            this.km_passed = new System.Windows.Forms.TextBox();
            this.max_speed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.l12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.l11 = new System.Windows.Forms.Label();
            this.uBox = new System.Windows.Forms.TextBox();
            this.uKM = new System.Windows.Forms.Button();
            this.uerror = new System.Windows.Forms.Button();
            this.l9 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year:";
            // 
            // selection
            // 
            this.selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selection.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selection.FormattingEnabled = true;
            this.selection.Items.AddRange(new object[] {
            "Airplane",
            "Boat",
            "Vehicle",
            "Car",
            "Motorcycle"});
            this.selection.Location = new System.Drawing.Point(135, 10);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(190, 36);
            this.selection.TabIndex = 1;
            this.selection.SelectedIndexChanged += new System.EventHandler(this.selection_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 36);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manufacturer:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wheelSize);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.clear_button);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.km_passed);
            this.panel1.Controls.Add(this.max_speed);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.selection);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(162, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 421);
            this.panel1.TabIndex = 5;
            // 
            // wheelSize
            // 
            this.wheelSize.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheelSize.Location = new System.Drawing.Point(504, 314);
            this.wheelSize.Name = "wheelSize";
            this.wheelSize.Size = new System.Drawing.Size(94, 34);
            this.wheelSize.TabIndex = 24;
            this.wheelSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wheelSize_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label24.Location = new System.Drawing.Point(389, 314);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(142, 32);
            this.label24.TabIndex = 23;
            this.label24.Text = "Wheel size:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(135, 380);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(205, 34);
            this.textName.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(3, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 32);
            this.label10.TabIndex = 21;
            this.label10.Text = "Owner Name:";
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.ForeColor = System.Drawing.Color.White;
            this.clear_button.Location = new System.Drawing.Point(511, 380);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(120, 38);
            this.clear_button.TabIndex = 20;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(135, 272);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 34);
            this.textBox2.TabIndex = 19;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(3, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Horse Power:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(276, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 34);
            this.panel2.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton1.Location = new System.Drawing.Point(119, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 36);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "10 m\'";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton2.Location = new System.Drawing.Point(361, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 36);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "30 m\'";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(394, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 34);
            this.textBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(390, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "Wings Size:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(390, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Maximum People:";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(637, 380);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(120, 38);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // error
            // 
            this.error.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.Location = new System.Drawing.Point(395, 38);
            this.error.Multiline = true;
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(340, 131);
            this.error.TabIndex = 10;
            // 
            // km_passed
            // 
            this.km_passed.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.km_passed.Location = new System.Drawing.Point(120, 222);
            this.km_passed.Name = "km_passed";
            this.km_passed.Size = new System.Drawing.Size(109, 34);
            this.km_passed.TabIndex = 9;
            this.km_passed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.km_passed_KeyPress);
            // 
            // max_speed
            // 
            this.max_speed.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_speed.Location = new System.Drawing.Point(176, 171);
            this.max_speed.Name = "max_speed";
            this.max_speed.Size = new System.Drawing.Size(109, 34);
            this.max_speed.TabIndex = 9;
            this.max_speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.max_speed_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(542, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Error:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(3, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "KM Passed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(3, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maximum Speed:";
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(65, 117);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 34);
            this.year.TabIndex = 6;
            this.year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.year_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.l12);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.l11);
            this.panel3.Controls.Add(this.uBox);
            this.panel3.Controls.Add(this.uKM);
            this.panel3.Controls.Add(this.uerror);
            this.panel3.Controls.Add(this.l9);
            this.panel3.Controls.Add(this.l8);
            this.panel3.Controls.Add(this.l7);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.l6);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.removeButton);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.l5);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.l4);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.l3);
            this.panel3.Controls.Add(this.l1);
            this.panel3.Controls.Add(this.l2);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Location = new System.Drawing.Point(162, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 418);
            this.panel3.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(3, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(212, 32);
            this.label17.TabIndex = 8;
            this.label17.Text = "Maximum Speed:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(18, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 62);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label23.Location = new System.Drawing.Point(4, 272);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(144, 32);
            this.label23.TabIndex = 41;
            this.label23.Text = "Wheel Size:";
            // 
            // l12
            // 
            this.l12.AutoSize = true;
            this.l12.ForeColor = System.Drawing.Color.IndianRed;
            this.l12.Location = new System.Drawing.Point(583, 352);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(0, 32);
            this.l12.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label22.Location = new System.Drawing.Point(578, 327);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 32);
            this.label22.TabIndex = 38;
            this.label22.Text = "Next Visit:";
            // 
            // l11
            // 
            this.l11.AutoSize = true;
            this.l11.ForeColor = System.Drawing.Color.IndianRed;
            this.l11.Location = new System.Drawing.Point(318, 389);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(118, 32);
            this.l11.TabIndex = 36;
            this.l11.Text = "New KM:";
            // 
            // uBox
            // 
            this.uBox.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.uBox.Location = new System.Drawing.Point(406, 389);
            this.uBox.Name = "uBox";
            this.uBox.Size = new System.Drawing.Size(171, 34);
            this.uBox.TabIndex = 35;
            // 
            // uKM
            // 
            this.uKM.BackColor = System.Drawing.SystemColors.HotTrack;
            this.uKM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uKM.BackgroundImage")));
            this.uKM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uKM.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uKM.ForeColor = System.Drawing.Color.White;
            this.uKM.Location = new System.Drawing.Point(9, 173);
            this.uKM.Name = "uKM";
            this.uKM.Size = new System.Drawing.Size(18, 22);
            this.uKM.TabIndex = 34;
            this.uKM.UseVisualStyleBackColor = false;
            this.uKM.Click += new System.EventHandler(this.uKM_Click);
            // 
            // uerror
            // 
            this.uerror.BackColor = System.Drawing.SystemColors.HotTrack;
            this.uerror.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uerror.BackgroundImage")));
            this.uerror.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uerror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uerror.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uerror.ForeColor = System.Drawing.Color.White;
            this.uerror.Location = new System.Drawing.Point(337, 38);
            this.uerror.Name = "uerror";
            this.uerror.Size = new System.Drawing.Size(18, 20);
            this.uerror.TabIndex = 33;
            this.uerror.UseVisualStyleBackColor = false;
            this.uerror.Click += new System.EventHandler(this.uerror_Click);
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.ForeColor = System.Drawing.Color.IndianRed;
            this.l9.Location = new System.Drawing.Point(129, 384);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(0, 32);
            this.l9.TabIndex = 30;
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.ForeColor = System.Drawing.Color.IndianRed;
            this.l8.Location = new System.Drawing.Point(142, 203);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(0, 32);
            this.l8.TabIndex = 29;
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.ForeColor = System.Drawing.Color.IndianRed;
            this.l7.Location = new System.Drawing.Point(409, 235);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(0, 32);
            this.l7.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(4, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "Horse Power:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(409, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 32);
            this.label13.TabIndex = 12;
            this.label13.Text = "Wings Size:";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.ForeColor = System.Drawing.Color.IndianRed;
            this.l6.Location = new System.Drawing.Point(409, 166);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(0, 32);
            this.l6.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(409, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 32);
            this.label14.TabIndex = 11;
            this.label14.Text = "Maximum People:";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(583, 380);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(171, 38);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Press To Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(414, 7);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(340, 131);
            this.textBox6.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(331, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 32);
            this.label15.TabIndex = 8;
            this.label15.Text = "Error:";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.ForeColor = System.Drawing.Color.IndianRed;
            this.l5.Location = new System.Drawing.Point(112, 144);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(0, 32);
            this.l5.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(3, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 32);
            this.label16.TabIndex = 8;
            this.label16.Text = "KM Passed:";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.ForeColor = System.Drawing.Color.IndianRed;
            this.l4.Location = new System.Drawing.Point(171, 113);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(0, 32);
            this.l4.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(3, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 32);
            this.label18.TabIndex = 0;
            this.label18.Text = "Year:";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.ForeColor = System.Drawing.Color.IndianRed;
            this.l3.Location = new System.Drawing.Point(60, 78);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(0, 32);
            this.l3.TabIndex = 22;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.ForeColor = System.Drawing.Color.IndianRed;
            this.l1.Location = new System.Drawing.Point(129, 9);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 32);
            this.l1.TabIndex = 23;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.ForeColor = System.Drawing.Color.IndianRed;
            this.l2.Location = new System.Drawing.Point(142, 44);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 32);
            this.l2.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label19.Location = new System.Drawing.Point(3, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(179, 32);
            this.label19.TabIndex = 4;
            this.label19.Text = "Manufacturer:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(3, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(162, 32);
            this.label20.TabIndex = 2;
            this.label20.Text = "Vehicle Type:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(4, 384);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(170, 32);
            this.label21.TabIndex = 30;
            this.label21.Text = "Owner Name:";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(9, 15);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(144, 38);
            this.menuButton.TabIndex = 23;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "New Vehicle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(9, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 36);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.saveButton.Location = new System.Drawing.Point(9, 138);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(144, 44);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.loadButton.Location = new System.Drawing.Point(9, 186);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(144, 46);
            this.loadButton.TabIndex = 32;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Final.Properties.Resources.car_park;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(162, 439);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(757, 175);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "registration";
            this.Text = "Garage";
            this.Load += new System.EventHandler(this.registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox max_speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox km_passed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox error;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button uKM;
        private System.Windows.Forms.Button uerror;
        private System.Windows.Forms.TextBox uBox;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.Label l12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox wheelSize;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}