namespace gravitySimulator
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
            this.StartClick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zoomSet_button = new System.Windows.Forms.Button();
            this.zoomTextBox = new System.Windows.Forms.TextBox();
            this.zoomIn_button = new System.Windows.Forms.Button();
            this.zoomOut_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.calcSecTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stopSimulation = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBdisabled = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartClick
            // 
            this.StartClick.BackColor = System.Drawing.Color.Transparent;
            this.StartClick.FlatAppearance.BorderSize = 0;
            this.StartClick.Location = new System.Drawing.Point(8, 19);
            this.StartClick.Name = "StartClick";
            this.StartClick.Size = new System.Drawing.Size(133, 23);
            this.StartClick.TabIndex = 0;
            this.StartClick.Text = "Start Simulation";
            this.StartClick.UseVisualStyleBackColor = false;
            this.StartClick.Click += new System.EventHandler(this.StartClick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.calcSecTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stopSimulation);
            this.groupBox1.Controls.Add(this.StartClick);
            this.groupBox1.Location = new System.Drawing.Point(12, 605);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zoomSet_button);
            this.groupBox2.Controls.Add(this.zoomTextBox);
            this.groupBox2.Controls.Add(this.zoomIn_button);
            this.groupBox2.Controls.Add(this.zoomOut_button);
            this.groupBox2.Location = new System.Drawing.Point(549, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 75);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zoom";
            // 
            // zoomSet_button
            // 
            this.zoomSet_button.Location = new System.Drawing.Point(73, 16);
            this.zoomSet_button.Name = "zoomSet_button";
            this.zoomSet_button.Size = new System.Drawing.Size(61, 25);
            this.zoomSet_button.TabIndex = 9;
            this.zoomSet_button.Text = "Set Zoom";
            this.zoomSet_button.UseVisualStyleBackColor = true;
            this.zoomSet_button.Click += new System.EventHandler(this.zoomSet_button_Click);
            // 
            // zoomTextBox
            // 
            this.zoomTextBox.Location = new System.Drawing.Point(6, 19);
            this.zoomTextBox.Name = "zoomTextBox";
            this.zoomTextBox.Size = new System.Drawing.Size(61, 20);
            this.zoomTextBox.TabIndex = 8;
            this.zoomTextBox.Text = "100%";
            // 
            // zoomIn_button
            // 
            this.zoomIn_button.Location = new System.Drawing.Point(6, 45);
            this.zoomIn_button.Name = "zoomIn_button";
            this.zoomIn_button.Size = new System.Drawing.Size(61, 25);
            this.zoomIn_button.TabIndex = 6;
            this.zoomIn_button.Text = "Zoom in";
            this.zoomIn_button.UseVisualStyleBackColor = true;
            this.zoomIn_button.Click += new System.EventHandler(this.zoomIn_button_Click);
            // 
            // zoomOut_button
            // 
            this.zoomOut_button.Location = new System.Drawing.Point(73, 47);
            this.zoomOut_button.Name = "zoomOut_button";
            this.zoomOut_button.Size = new System.Drawing.Size(61, 25);
            this.zoomOut_button.TabIndex = 7;
            this.zoomOut_button.Text = "Zoom out";
            this.zoomOut_button.UseVisualStyleBackColor = true;
            this.zoomOut_button.Click += new System.EventHandler(this.zoomOut_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // calcSecTextBox
            // 
            this.calcSecTextBox.Location = new System.Drawing.Point(658, 17);
            this.calcSecTextBox.Name = "calcSecTextBox";
            this.calcSecTextBox.ReadOnly = true;
            this.calcSecTextBox.Size = new System.Drawing.Size(46, 20);
            this.calcSecTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calculations / Sec";
            // 
            // stopSimulation
            // 
            this.stopSimulation.BackColor = System.Drawing.Color.Transparent;
            this.stopSimulation.FlatAppearance.BorderSize = 0;
            this.stopSimulation.Location = new System.Drawing.Point(8, 48);
            this.stopSimulation.Name = "stopSimulation";
            this.stopSimulation.Size = new System.Drawing.Size(133, 23);
            this.stopSimulation.TabIndex = 1;
            this.stopSimulation.Text = "Pause Simulation";
            this.stopSimulation.UseVisualStyleBackColor = false;
            this.stopSimulation.Click += new System.EventHandler(this.stopSimulation_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioBdisabled);
            this.groupBox3.Location = new System.Drawing.Point(420, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 75);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Collision";
            // 
            // radioBdisabled
            // 
            this.radioBdisabled.AutoSize = true;
            this.radioBdisabled.Checked = true;
            this.radioBdisabled.Location = new System.Drawing.Point(6, 50);
            this.radioBdisabled.Name = "radioBdisabled";
            this.radioBdisabled.Size = new System.Drawing.Size(66, 17);
            this.radioBdisabled.TabIndex = 0;
            this.radioBdisabled.TabStop = true;
            this.radioBdisabled.Text = "Disabled";
            this.radioBdisabled.UseVisualStyleBackColor = true;
            this.radioBdisabled.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Enabled";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gravity Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stopSimulation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox calcSecTextBox;
        private System.Windows.Forms.Button zoomOut_button;
        private System.Windows.Forms.Button zoomIn_button;
        private System.Windows.Forms.TextBox zoomTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button zoomSet_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioBdisabled;
    }
}

