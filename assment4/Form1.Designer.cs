namespace assment4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.lblcn = new System.Windows.Forms.Label();
            this.lblPR = new System.Windows.Forms.Label();
            this.lblCR = new System.Windows.Forms.Label();
            this.lblPPU = new System.Windows.Forms.Label();
            this.electiacl = new System.Windows.Forms.Label();
            this.taxamount = new System.Windows.Forms.Label();
            this.totalbill = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblUsage = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // txtcustomer
            // 
            this.txtcustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcustomer.Location = new System.Drawing.Point(509, 39);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(164, 26);
            this.txtcustomer.TabIndex = 5;
            // 
            // txtprevious
            // 
            this.txtprevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprevious.Location = new System.Drawing.Point(509, 87);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(164, 26);
            this.txtprevious.TabIndex = 6;
            // 
            // txtunitprice
            // 
            this.txtunitprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtunitprice.Location = new System.Drawing.Point(509, 202);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(164, 26);
            this.txtunitprice.TabIndex = 7;
            // 
            // txtcurrent
            // 
            this.txtcurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcurrent.Location = new System.Drawing.Point(509, 141);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(164, 26);
            this.txtcurrent.TabIndex = 8;
            // 
            // lblcn
            // 
            this.lblcn.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcn.Location = new System.Drawing.Point(280, 45);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(202, 32);
            this.lblcn.TabIndex = 9;
            this.lblcn.Text = " Enter Costomer Name";
            this.lblcn.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPR
            // 
            this.lblPR.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPR.Location = new System.Drawing.Point(280, 89);
            this.lblPR.Name = "lblPR";
            this.lblPR.Size = new System.Drawing.Size(190, 24);
            this.lblPR.TabIndex = 10;
            this.lblPR.Text = "Enter Previous Reading";
            // 
            // lblCR
            // 
            this.lblCR.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCR.Location = new System.Drawing.Point(280, 141);
            this.lblCR.Name = "lblCR";
            this.lblCR.Size = new System.Drawing.Size(190, 26);
            this.lblCR.TabIndex = 11;
            this.lblCR.Text = " Enter Current Reading";
            // 
            // lblPPU
            // 
            this.lblPPU.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPU.Location = new System.Drawing.Point(280, 192);
            this.lblPPU.Name = "lblPPU";
            this.lblPPU.Size = new System.Drawing.Size(179, 36);
            this.lblPPU.TabIndex = 12;
            this.lblPPU.Text = " Enter Price Per Unit";
            this.lblPPU.Click += new System.EventHandler(this.label4_Click);
            // 
            // electiacl
            // 
            this.electiacl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electiacl.Location = new System.Drawing.Point(130, 277);
            this.electiacl.Name = "electiacl";
            this.electiacl.Size = new System.Drawing.Size(200, 28);
            this.electiacl.TabIndex = 13;
            this.electiacl.Text = "Electricity Usage(Unit)   :";
            // 
            // taxamount
            // 
            this.taxamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxamount.Location = new System.Drawing.Point(130, 333);
            this.taxamount.Name = "taxamount";
            this.taxamount.Size = new System.Drawing.Size(200, 37);
            this.taxamount.TabIndex = 14;
            this.taxamount.Text = "Tax Amount(7) :";
            this.taxamount.Click += new System.EventHandler(this.label6_Click);
            // 
            // totalbill
            // 
            this.totalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbill.Location = new System.Drawing.Point(130, 383);
            this.totalbill.Name = "totalbill";
            this.totalbill.Size = new System.Drawing.Size(188, 37);
            this.totalbill.TabIndex = 15;
            this.totalbill.Text = "Total Bill (Including) :";
            this.totalbill.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(318, 240);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(175, 34);
            this.btncalculate.TabIndex = 16;
            this.btncalculate.Text = "Calculate Bill";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblUsage
            // 
            this.lblUsage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsage.Location = new System.Drawing.Point(375, 290);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(265, 28);
            this.lblUsage.TabIndex = 17;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Location = new System.Drawing.Point(374, 333);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(266, 37);
            this.lblTax.TabIndex = 18;
            this.lblTax.Click += new System.EventHandler(this.TAX_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(374, 382);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(266, 37);
            this.lblTotal.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblUsage);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.totalbill);
            this.Controls.Add(this.taxamount);
            this.Controls.Add(this.electiacl);
            this.Controls.Add(this.lblPPU);
            this.Controls.Add(this.lblCR);
            this.Controls.Add(this.lblPR);
            this.Controls.Add(this.lblcn);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtprevious);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.Label lblPR;
        private System.Windows.Forms.Label lblCR;
        private System.Windows.Forms.Label lblPPU;
        private System.Windows.Forms.Label electiacl;
        private System.Windows.Forms.Label taxamount;
        private System.Windows.Forms.Label totalbill;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
    }
}

