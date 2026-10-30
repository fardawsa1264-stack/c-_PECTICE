namespace AssEmnt7
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
            this.bwriteline = new System.Windows.Forms.Button();
            this.bReadline = new System.Windows.Forms.Button();
            this.bReadALLline = new System.Windows.Forms.Button();
            this.bDeletfile = new System.Windows.Forms.Button();
            this.bDeletitem = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bwriteline
            // 
            this.bwriteline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bwriteline.Location = new System.Drawing.Point(240, 22);
            this.bwriteline.Name = "bwriteline";
            this.bwriteline.Size = new System.Drawing.Size(97, 38);
            this.bwriteline.TabIndex = 0;
            this.bwriteline.Text = "Write Line";
            this.bwriteline.UseVisualStyleBackColor = true;
            this.bwriteline.Click += new System.EventHandler(this.bwriteline_Click);
            // 
            // bReadline
            // 
            this.bReadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReadline.Location = new System.Drawing.Point(240, 86);
            this.bReadline.Name = "bReadline";
            this.bReadline.Size = new System.Drawing.Size(116, 40);
            this.bReadline.TabIndex = 1;
            this.bReadline.Text = "Read line";
            this.bReadline.UseVisualStyleBackColor = true;
            this.bReadline.Click += new System.EventHandler(this.bReadline_Click);
            // 
            // bReadALLline
            // 
            this.bReadALLline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReadALLline.Location = new System.Drawing.Point(217, 158);
            this.bReadALLline.Name = "bReadALLline";
            this.bReadALLline.Size = new System.Drawing.Size(157, 41);
            this.bReadALLline.TabIndex = 2;
            this.bReadALLline.Text = "Read  ALL Line";
            this.bReadALLline.UseVisualStyleBackColor = true;
            this.bReadALLline.Click += new System.EventHandler(this.bReadALLline_Click);
            // 
            // bDeletfile
            // 
            this.bDeletfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeletfile.Location = new System.Drawing.Point(240, 242);
            this.bDeletfile.Name = "bDeletfile";
            this.bDeletfile.Size = new System.Drawing.Size(148, 46);
            this.bDeletfile.TabIndex = 3;
            this.bDeletfile.Text = "Delet file";
            this.bDeletfile.UseVisualStyleBackColor = true;
            this.bDeletfile.Click += new System.EventHandler(this.bDeletfile_Click);
            // 
            // bDeletitem
            // 
            this.bDeletitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeletitem.Location = new System.Drawing.Point(240, 324);
            this.bDeletitem.Name = "bDeletitem";
            this.bDeletitem.Size = new System.Drawing.Size(165, 60);
            this.bDeletitem.TabIndex = 4;
            this.bDeletitem.Text = "Delet item";
            this.bDeletitem.UseVisualStyleBackColor = true;
            this.bDeletitem.Click += new System.EventHandler(this.bDeletitem_Click);
            // 
            // lResult
            // 
            this.lResult.FormattingEnabled = true;
            this.lResult.ItemHeight = 20;
            this.lResult.Location = new System.Drawing.Point(475, 40);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(238, 344);
            this.lResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.bDeletitem);
            this.Controls.Add(this.bDeletfile);
            this.Controls.Add(this.bReadALLline);
            this.Controls.Add(this.bReadline);
            this.Controls.Add(this.bwriteline);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bwriteline;
        private System.Windows.Forms.Button bReadline;
        private System.Windows.Forms.Button bReadALLline;
        private System.Windows.Forms.Button bDeletfile;
        private System.Windows.Forms.Button bDeletitem;
        private System.Windows.Forms.ListBox lResult;
    }
}

