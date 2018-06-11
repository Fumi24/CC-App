namespace CC_App
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
            this.txtboxfile1 = new System.Windows.Forms.TextBox();
            this.txtboxfile2 = new System.Windows.Forms.TextBox();
            this.btnfileload1 = new System.Windows.Forms.Button();
            this.btnloadfile2 = new System.Windows.Forms.Button();
            this.btnCC = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnopencc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxfile1
            // 
            this.txtboxfile1.Location = new System.Drawing.Point(13, 13);
            this.txtboxfile1.Name = "txtboxfile1";
            this.txtboxfile1.ReadOnly = true;
            this.txtboxfile1.Size = new System.Drawing.Size(377, 20);
            this.txtboxfile1.TabIndex = 0;
            // 
            // txtboxfile2
            // 
            this.txtboxfile2.Location = new System.Drawing.Point(13, 40);
            this.txtboxfile2.Name = "txtboxfile2";
            this.txtboxfile2.ReadOnly = true;
            this.txtboxfile2.Size = new System.Drawing.Size(377, 20);
            this.txtboxfile2.TabIndex = 1;
            // 
            // btnfileload1
            // 
            this.btnfileload1.Location = new System.Drawing.Point(397, 9);
            this.btnfileload1.Name = "btnfileload1";
            this.btnfileload1.Size = new System.Drawing.Size(75, 23);
            this.btnfileload1.TabIndex = 2;
            this.btnfileload1.Text = "Load file 1";
            this.btnfileload1.UseVisualStyleBackColor = true;
            this.btnfileload1.Click += new System.EventHandler(this.btnfileload1_Click);
            // 
            // btnloadfile2
            // 
            this.btnloadfile2.Location = new System.Drawing.Point(396, 38);
            this.btnloadfile2.Name = "btnloadfile2";
            this.btnloadfile2.Size = new System.Drawing.Size(75, 23);
            this.btnloadfile2.TabIndex = 3;
            this.btnloadfile2.Text = "Load file 2";
            this.btnloadfile2.UseVisualStyleBackColor = true;
            this.btnloadfile2.Click += new System.EventHandler(this.btnloadfile2_Click);
            // 
            // btnCC
            // 
            this.btnCC.Location = new System.Drawing.Point(396, 67);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(75, 23);
            this.btnCC.TabIndex = 4;
            this.btnCC.Text = "Do Magic";
            this.btnCC.UseVisualStyleBackColor = true;
            this.btnCC.Click += new System.EventHandler(this.btnCC_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PLY Files (*.ply)|*.ply";
            // 
            // btnopencc
            // 
            this.btnopencc.Location = new System.Drawing.Point(12, 67);
            this.btnopencc.Name = "btnopencc";
            this.btnopencc.Size = new System.Drawing.Size(123, 23);
            this.btnopencc.TabIndex = 6;
            this.btnopencc.Text = "Open CloudCompare";
            this.btnopencc.UseVisualStyleBackColor = true;
            this.btnopencc.Click += new System.EventHandler(this.btnbinopen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 104);
            this.Controls.Add(this.btnopencc);
            this.Controls.Add(this.btnCC);
            this.Controls.Add(this.btnloadfile2);
            this.Controls.Add(this.btnfileload1);
            this.Controls.Add(this.txtboxfile2);
            this.Controls.Add(this.txtboxfile1);
            this.Name = "Form1";
            this.Text = "CC App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxfile1;
        private System.Windows.Forms.TextBox txtboxfile2;
        private System.Windows.Forms.Button btnfileload1;
        private System.Windows.Forms.Button btnloadfile2;
        private System.Windows.Forms.Button btnCC;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnopencc;
    }
}

