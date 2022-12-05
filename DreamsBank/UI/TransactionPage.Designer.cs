namespace DreamsBank.UI
{
    partial class TransactionPage
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
            this.tbDeposit = new System.Windows.Forms.TabControl();
            this.tabDeposit = new System.Windows.Forms.TabPage();
            this.tabWidraw = new System.Windows.Forms.TabPage();
            this.tabTransfer = new System.Windows.Forms.TabPage();
            this.tabBalance = new System.Windows.Forms.TabPage();
            this.tabStatement = new System.Windows.Forms.TabPage();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbDeposit.SuspendLayout();
            this.tabDeposit.SuspendLayout();
            this.tabWidraw.SuspendLayout();
            this.tabTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDeposit
            // 
            this.tbDeposit.Controls.Add(this.tabDeposit);
            this.tbDeposit.Controls.Add(this.tabWidraw);
            this.tbDeposit.Controls.Add(this.tabTransfer);
            this.tbDeposit.Controls.Add(this.tabBalance);
            this.tbDeposit.Controls.Add(this.tabStatement);
            this.tbDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeposit.Location = new System.Drawing.Point(51, 106);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.SelectedIndex = 0;
            this.tbDeposit.Size = new System.Drawing.Size(605, 311);
            this.tbDeposit.TabIndex = 0;
            // 
            // tabDeposit
            // 
            this.tabDeposit.BackColor = System.Drawing.Color.Gainsboro;
            this.tabDeposit.Controls.Add(this.lblAmount);
            this.tabDeposit.Controls.Add(this.txtBoxAmount);
            this.tabDeposit.Location = new System.Drawing.Point(4, 25);
            this.tabDeposit.Name = "tabDeposit";
            this.tabDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeposit.Size = new System.Drawing.Size(597, 282);
            this.tabDeposit.TabIndex = 0;
            this.tabDeposit.Text = "Deposit";
            this.tabDeposit.Click += new System.EventHandler(this.tabDeposit_Click);
            // 
            // tabWidraw
            // 
            this.tabWidraw.Controls.Add(this.label1);
            this.tabWidraw.Controls.Add(this.textBox1);
            this.tabWidraw.Location = new System.Drawing.Point(4, 25);
            this.tabWidraw.Name = "tabWidraw";
            this.tabWidraw.Padding = new System.Windows.Forms.Padding(3);
            this.tabWidraw.Size = new System.Drawing.Size(597, 282);
            this.tabWidraw.TabIndex = 1;
            this.tabWidraw.Text = "Withdraw";
            this.tabWidraw.UseVisualStyleBackColor = true;
            // 
            // tabTransfer
            // 
            this.tabTransfer.Controls.Add(this.label2);
            this.tabTransfer.Controls.Add(this.textBox2);
            this.tabTransfer.Location = new System.Drawing.Point(4, 25);
            this.tabTransfer.Name = "tabTransfer";
            this.tabTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransfer.Size = new System.Drawing.Size(597, 282);
            this.tabTransfer.TabIndex = 2;
            this.tabTransfer.Text = "Transfer";
            this.tabTransfer.UseVisualStyleBackColor = true;
            // 
            // tabBalance
            // 
            this.tabBalance.Location = new System.Drawing.Point(4, 25);
            this.tabBalance.Name = "tabBalance";
            this.tabBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tabBalance.Size = new System.Drawing.Size(597, 282);
            this.tabBalance.TabIndex = 3;
            this.tabBalance.Text = "Balance";
            this.tabBalance.UseVisualStyleBackColor = true;
            this.tabBalance.Click += new System.EventHandler(this.tabBalance_Click);
            // 
            // tabStatement
            // 
            this.tabStatement.ForeColor = System.Drawing.Color.Gray;
            this.tabStatement.Location = new System.Drawing.Point(4, 25);
            this.tabStatement.Name = "tabStatement";
            this.tabStatement.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatement.Size = new System.Drawing.Size(597, 282);
            this.tabStatement.TabIndex = 5;
            this.tabStatement.Text = "Statment";
            this.tabStatement.UseVisualStyleBackColor = true;
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(123, 39);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(146, 22);
            this.txtBoxAmount.TabIndex = 0;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(52, 39);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 22);
            this.textBox2.TabIndex = 2;
            // 
            // TransactionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDeposit);
            this.Name = "TransactionPage";
            this.Text = "Transaction Page";
            this.tbDeposit.ResumeLayout(false);
            this.tabDeposit.ResumeLayout(false);
            this.tabDeposit.PerformLayout();
            this.tabWidraw.ResumeLayout(false);
            this.tabWidraw.PerformLayout();
            this.tabTransfer.ResumeLayout(false);
            this.tabTransfer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbDeposit;
        private System.Windows.Forms.TabPage tabDeposit;
        private System.Windows.Forms.TabPage tabWidraw;
        private System.Windows.Forms.TabPage tabTransfer;
        private System.Windows.Forms.TabPage tabBalance;
        private System.Windows.Forms.TabPage tabStatement;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}