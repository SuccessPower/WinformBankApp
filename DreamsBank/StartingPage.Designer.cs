namespace DreamsBank
{
    partial class StartingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDontHaveAcct = new System.Windows.Forms.Label();
            this.btnLoginStart = new System.Windows.Forms.Button();
            this.btnRegStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1100, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDontHaveAcct
            // 
            this.lblDontHaveAcct.AutoSize = true;
            this.lblDontHaveAcct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontHaveAcct.ForeColor = System.Drawing.Color.Gray;
            this.lblDontHaveAcct.Location = new System.Drawing.Point(348, 578);
            this.lblDontHaveAcct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDontHaveAcct.Name = "lblDontHaveAcct";
            this.lblDontHaveAcct.Size = new System.Drawing.Size(217, 25);
            this.lblDontHaveAcct.TabIndex = 2;
            this.lblDontHaveAcct.Text = "Don\'t have an account?";
            // 
            // btnLoginStart
            // 
            this.btnLoginStart.BackColor = System.Drawing.Color.Red;
            this.btnLoginStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginStart.ForeColor = System.Drawing.Color.White;
            this.btnLoginStart.Location = new System.Drawing.Point(343, 534);
            this.btnLoginStart.Name = "btnLoginStart";
            this.btnLoginStart.Size = new System.Drawing.Size(412, 41);
            this.btnLoginStart.TabIndex = 3;
            this.btnLoginStart.Text = "Login";
            this.btnLoginStart.UseVisualStyleBackColor = false;
            this.btnLoginStart.Click += new System.EventHandler(this.btnLoginStart_Click);
            // 
            // btnRegStart
            // 
            this.btnRegStart.BackColor = System.Drawing.Color.Red;
            this.btnRegStart.ForeColor = System.Drawing.Color.White;
            this.btnRegStart.Location = new System.Drawing.Point(572, 581);
            this.btnRegStart.Name = "btnRegStart";
            this.btnRegStart.Size = new System.Drawing.Size(183, 35);
            this.btnRegStart.TabIndex = 4;
            this.btnRegStart.Text = "Register";
            this.btnRegStart.UseVisualStyleBackColor = false;
            this.btnRegStart.Click += new System.EventHandler(this.btnRegStart_Click);
            // 
            // StartingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 631);
            this.Controls.Add(this.btnRegStart);
            this.Controls.Add(this.btnLoginStart);
            this.Controls.Add(this.lblDontHaveAcct);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartingPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDontHaveAcct;
        private System.Windows.Forms.Button btnLoginStart;
        private System.Windows.Forms.Button btnRegStart;
    }
}

