namespace assment5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGN = new System.Windows.Forms.TextBox();
            this.textGA = new System.Windows.Forms.TextBox();
            this.textNOFN = new System.Windows.Forms.TextBox();
            this.textNOFG = new System.Windows.Forms.TextBox();
            this.lablgn = new System.Windows.Forms.Label();
            this.lblgA = new System.Windows.Forms.Label();
            this.lblnofg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxRTYPE = new System.Windows.Forms.GroupBox();
            this.rstandard = new System.Windows.Forms.RadioButton();
            this.rnormal = new System.Windows.Forms.RadioButton();
            this.rhight = new System.Windows.Forms.RadioButton();
            this.groupBoxaditianlop = new System.Windows.Forms.GroupBox();
            this.checkedBfast = new System.Windows.Forms.CheckBox();
            this.calculate = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.listoutput = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxRTYPE.SuspendLayout();
            this.groupBoxaditianlop.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblnofg);
            this.groupBox1.Controls.Add(this.lblgA);
            this.groupBox1.Controls.Add(this.lablgn);
            this.groupBox1.Controls.Add(this.textNOFG);
            this.groupBox1.Controls.Add(this.textNOFN);
            this.groupBox1.Controls.Add(this.textGA);
            this.groupBox1.Controls.Add(this.txtGN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal informatiom";
            // 
            // txtGN
            // 
            this.txtGN.Location = new System.Drawing.Point(292, 44);
            this.txtGN.Name = "txtGN";
            this.txtGN.Size = new System.Drawing.Size(165, 28);
            this.txtGN.TabIndex = 1;
            // 
            // textGA
            // 
            this.textGA.Location = new System.Drawing.Point(292, 86);
            this.textGA.Name = "textGA";
            this.textGA.Size = new System.Drawing.Size(165, 28);
            this.textGA.TabIndex = 2;
            // 
            // textNOFN
            // 
            this.textNOFN.Location = new System.Drawing.Point(292, 138);
            this.textNOFN.Name = "textNOFN";
            this.textNOFN.Size = new System.Drawing.Size(165, 28);
            this.textNOFN.TabIndex = 3;
            // 
            // textNOFG
            // 
            this.textNOFG.Location = new System.Drawing.Point(292, 199);
            this.textNOFG.Name = "textNOFG";
            this.textNOFG.Size = new System.Drawing.Size(165, 28);
            this.textNOFG.TabIndex = 4;
            // 
            // lablgn
            // 
            this.lablgn.Location = new System.Drawing.Point(52, 41);
            this.lablgn.Name = "lablgn";
            this.lablgn.Size = new System.Drawing.Size(172, 29);
            this.lablgn.TabIndex = 5;
            this.lablgn.Text = "Guest Name";
            // 
            // lblgA
            // 
            this.lblgA.Location = new System.Drawing.Point(52, 86);
            this.lblgA.Name = "lblgA";
            this.lblgA.Size = new System.Drawing.Size(183, 28);
            this.lblgA.TabIndex = 6;
            this.lblgA.Text = "Guest Age";
            // 
            // lblnofg
            // 
            this.lblnofg.Location = new System.Drawing.Point(21, 141);
            this.lblnofg.Name = "lblnofg";
            this.lblnofg.Size = new System.Drawing.Size(200, 33);
            this.lblnofg.TabIndex = 7;
            this.lblnofg.Text = "Number Of Night";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number Of Guest";
            // 
            // groupBoxRTYPE
            // 
            this.groupBoxRTYPE.Controls.Add(this.rhight);
            this.groupBoxRTYPE.Controls.Add(this.rnormal);
            this.groupBoxRTYPE.Controls.Add(this.rstandard);
            this.groupBoxRTYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRTYPE.Location = new System.Drawing.Point(12, 266);
            this.groupBoxRTYPE.Name = "groupBoxRTYPE";
            this.groupBoxRTYPE.Size = new System.Drawing.Size(542, 100);
            this.groupBoxRTYPE.TabIndex = 1;
            this.groupBoxRTYPE.TabStop = false;
            this.groupBoxRTYPE.Text = "Room Type";
            // 
            // rstandard
            // 
            this.rstandard.AutoSize = true;
            this.rstandard.Location = new System.Drawing.Point(21, 44);
            this.rstandard.Name = "rstandard";
            this.rstandard.Size = new System.Drawing.Size(116, 26);
            this.rstandard.TabIndex = 0;
            this.rstandard.TabStop = true;
            this.rstandard.Text = "Standard";
            this.rstandard.UseVisualStyleBackColor = true;
            // 
            // rnormal
            // 
            this.rnormal.AutoSize = true;
            this.rnormal.Location = new System.Drawing.Point(179, 44);
            this.rnormal.Name = "rnormal";
            this.rnormal.Size = new System.Drawing.Size(98, 26);
            this.rnormal.TabIndex = 1;
            this.rnormal.TabStop = true;
            this.rnormal.Text = "Normal";
            this.rnormal.UseVisualStyleBackColor = true;
            // 
            // rhight
            // 
            this.rhight.AutoSize = true;
            this.rhight.Location = new System.Drawing.Point(345, 44);
            this.rhight.Name = "rhight";
            this.rhight.Size = new System.Drawing.Size(79, 26);
            this.rhight.TabIndex = 2;
            this.rhight.TabStop = true;
            this.rhight.Text = "hight";
            this.rhight.UseVisualStyleBackColor = true;
            // 
            // groupBoxaditianlop
            // 
            this.groupBoxaditianlop.Controls.Add(this.checkedBfast);
            this.groupBoxaditianlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxaditianlop.Location = new System.Drawing.Point(12, 372);
            this.groupBoxaditianlop.Name = "groupBoxaditianlop";
            this.groupBoxaditianlop.Size = new System.Drawing.Size(542, 100);
            this.groupBoxaditianlop.TabIndex = 2;
            this.groupBoxaditianlop.TabStop = false;
            this.groupBoxaditianlop.Text = " aditional Opttion";
            // 
            // checkedBfast
            // 
            this.checkedBfast.AutoSize = true;
            this.checkedBfast.Location = new System.Drawing.Point(52, 27);
            this.checkedBfast.Name = "checkedBfast";
            this.checkedBfast.Size = new System.Drawing.Size(342, 48);
            this.checkedBfast.TabIndex = 0;
            this.checkedBfast.Text = "breakfast (10 per guest  per night)\r\n\r\n";
            this.checkedBfast.UseVisualStyleBackColor = true;
            this.checkedBfast.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(48, 504);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(113, 42);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // bclear
            // 
            this.bclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bclear.Location = new System.Drawing.Point(216, 509);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(94, 33);
            this.bclear.TabIndex = 4;
            this.bclear.Text = "Clear";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Location = new System.Drawing.Point(371, 509);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(117, 37);
            this.bexit.TabIndex = 5;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = true;
            // 
            // listoutput
            // 
            this.listoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listoutput.FormattingEnabled = true;
            this.listoutput.ItemHeight = 22;
            this.listoutput.Location = new System.Drawing.Point(600, 41);
            this.listoutput.Name = "listoutput";
            this.listoutput.Size = new System.Drawing.Size(324, 422);
            this.listoutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 597);
            this.Controls.Add(this.listoutput);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.groupBoxaditianlop);
            this.Controls.Add(this.groupBoxRTYPE);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRTYPE.ResumeLayout(false);
            this.groupBoxRTYPE.PerformLayout();
            this.groupBoxaditianlop.ResumeLayout(false);
            this.groupBoxaditianlop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnofg;
        private System.Windows.Forms.Label lblgA;
        private System.Windows.Forms.Label lablgn;
        private System.Windows.Forms.TextBox textNOFG;
        private System.Windows.Forms.TextBox textNOFN;
        private System.Windows.Forms.TextBox textGA;
        private System.Windows.Forms.TextBox txtGN;
        private System.Windows.Forms.GroupBox groupBoxRTYPE;
        private System.Windows.Forms.RadioButton rhight;
        private System.Windows.Forms.RadioButton rnormal;
        private System.Windows.Forms.RadioButton rstandard;
        private System.Windows.Forms.GroupBox groupBoxaditianlop;
        private System.Windows.Forms.CheckBox checkedBfast;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.ListBox listoutput;
    }
}

