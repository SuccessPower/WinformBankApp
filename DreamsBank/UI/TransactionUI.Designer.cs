namespace DreamsBank.UI
{
    partial class TransactionUI
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
            this.tabTransaction = new System.Windows.Forms.TabControl();
            this.tabDeposit = new System.Windows.Forms.TabPage();
            this.btnDepoAmt = new System.Windows.Forms.Button();
            this.amountToDepo = new System.Windows.Forms.TextBox();
            this.depositAmount = new System.Windows.Forms.Label();
            this.tabWithdraw = new System.Windows.Forms.TabPage();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.amountToWith = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTransfer = new System.Windows.Forms.TabPage();
            this.btnTrans = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.acctTranfer = new System.Windows.Forms.TextBox();
            this.amountToTrans = new System.Windows.Forms.TextBox();
            this.acctType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabBalance = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAcctNo = new System.Windows.Forms.Label();
            this.lblAccountNum = new System.Windows.Forms.Label();
            this.lblAccountBal = new System.Windows.Forms.Label();
            this.tabTransaction.SuspendLayout();
            this.tabDeposit.SuspendLayout();
            this.tabWithdraw.SuspendLayout();
            this.tabTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTransaction
            // 
            this.tabTransaction.Controls.Add(this.tabDeposit);
            this.tabTransaction.Controls.Add(this.tabWithdraw);
            this.tabTransaction.Controls.Add(this.tabTransfer);
            this.tabTransaction.Controls.Add(this.tabBalance);
            this.tabTransaction.Controls.Add(this.tabPage2);
            this.tabTransaction.Location = new System.Drawing.Point(103, 118);
            this.tabTransaction.Name = "tabTransaction";
            this.tabTransaction.SelectedIndex = 0;
            this.tabTransaction.Size = new System.Drawing.Size(882, 420);
            this.tabTransaction.TabIndex = 0;
            // 
            // tabDeposit
            // 
            this.tabDeposit.BackColor = System.Drawing.Color.Silver;
            this.tabDeposit.Controls.Add(this.btnDepoAmt);
            this.tabDeposit.Controls.Add(this.amountToDepo);
            this.tabDeposit.Controls.Add(this.depositAmount);
            this.tabDeposit.Location = new System.Drawing.Point(4, 29);
            this.tabDeposit.Name = "tabDeposit";
            this.tabDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeposit.Size = new System.Drawing.Size(874, 387);
            this.tabDeposit.TabIndex = 0;
            this.tabDeposit.Text = "Deposit";
            // 
            // btnDepoAmt
            // 
            this.btnDepoAmt.BackColor = System.Drawing.Color.Red;
            this.btnDepoAmt.ForeColor = System.Drawing.Color.White;
            this.btnDepoAmt.Location = new System.Drawing.Point(101, 62);
            this.btnDepoAmt.Name = "btnDepoAmt";
            this.btnDepoAmt.Size = new System.Drawing.Size(263, 31);
            this.btnDepoAmt.TabIndex = 2;
            this.btnDepoAmt.Text = "Deposit";
            this.btnDepoAmt.UseVisualStyleBackColor = false;
            this.btnDepoAmt.Click += new System.EventHandler(this.btnDepoAmt_Click);
            // 
            // amountToDepo
            // 
            this.amountToDepo.Location = new System.Drawing.Point(101, 26);
            this.amountToDepo.Name = "amountToDepo";
            this.amountToDepo.Size = new System.Drawing.Size(266, 26);
            this.amountToDepo.TabIndex = 1;
            this.amountToDepo.TextChanged += new System.EventHandler(this.amountToDepo_TextChanged);
            // 
            // depositAmount
            // 
            this.depositAmount.AutoSize = true;
            this.depositAmount.Location = new System.Drawing.Point(30, 29);
            this.depositAmount.Name = "depositAmount";
            this.depositAmount.Size = new System.Drawing.Size(65, 20);
            this.depositAmount.TabIndex = 0;
            this.depositAmount.Text = "Amount";
            this.depositAmount.Click += new System.EventHandler(this.depositAmount_Click);
            // 
            // tabWithdraw
            // 
            this.tabWithdraw.BackColor = System.Drawing.Color.Silver;
            this.tabWithdraw.Controls.Add(this.btnWithdraw);
            this.tabWithdraw.Controls.Add(this.amountToWith);
            this.tabWithdraw.Controls.Add(this.label1);
            this.tabWithdraw.Location = new System.Drawing.Point(4, 29);
            this.tabWithdraw.Name = "tabWithdraw";
            this.tabWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tabWithdraw.Size = new System.Drawing.Size(874, 387);
            this.tabWithdraw.TabIndex = 1;
            this.tabWithdraw.Text = "Withdraw";
            this.tabWithdraw.Click += new System.EventHandler(this.tabWithdraw_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Red;
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(105, 56);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(266, 34);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            // 
            // amountToWith
            // 
            this.amountToWith.Location = new System.Drawing.Point(105, 24);
            this.amountToWith.Name = "amountToWith";
            this.amountToWith.Size = new System.Drawing.Size(266, 26);
            this.amountToWith.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount";
            // 
            // tabTransfer
            // 
            this.tabTransfer.BackColor = System.Drawing.Color.Silver;
            this.tabTransfer.Controls.Add(this.btnTrans);
            this.tabTransfer.Controls.Add(this.comboBox1);
            this.tabTransfer.Controls.Add(this.acctTranfer);
            this.tabTransfer.Controls.Add(this.amountToTrans);
            this.tabTransfer.Controls.Add(this.acctType);
            this.tabTransfer.Controls.Add(this.label3);
            this.tabTransfer.Controls.Add(this.label2);
            this.tabTransfer.Location = new System.Drawing.Point(4, 29);
            this.tabTransfer.Name = "tabTransfer";
            this.tabTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransfer.Size = new System.Drawing.Size(874, 387);
            this.tabTransfer.TabIndex = 2;
            this.tabTransfer.Text = "Transfer";
            // 
            // btnTrans
            // 
            this.btnTrans.BackColor = System.Drawing.Color.Red;
            this.btnTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.ForeColor = System.Drawing.Color.White;
            this.btnTrans.Location = new System.Drawing.Point(45, 149);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(333, 35);
            this.btnTrans.TabIndex = 5;
            this.btnTrans.Text = "Send";
            this.btnTrans.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.comboBox1.Location = new System.Drawing.Point(158, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // acctTranfer
            // 
            this.acctTranfer.Location = new System.Drawing.Point(158, 72);
            this.acctTranfer.Name = "acctTranfer";
            this.acctTranfer.Size = new System.Drawing.Size(220, 26);
            this.acctTranfer.TabIndex = 3;
            // 
            // amountToTrans
            // 
            this.amountToTrans.Location = new System.Drawing.Point(112, 33);
            this.amountToTrans.Name = "amountToTrans";
            this.amountToTrans.Size = new System.Drawing.Size(266, 26);
            this.amountToTrans.TabIndex = 3;
            // 
            // acctType
            // 
            this.acctType.AutoSize = true;
            this.acctType.Location = new System.Drawing.Point(41, 113);
            this.acctType.Name = "acctType";
            this.acctType.Size = new System.Drawing.Size(106, 20);
            this.acctType.TabIndex = 2;
            this.acctType.Text = "Account Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account no.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // tabBalance
            // 
            this.tabBalance.BackColor = System.Drawing.Color.Silver;
            this.tabBalance.Location = new System.Drawing.Point(4, 29);
            this.tabBalance.Name = "tabBalance";
            this.tabBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tabBalance.Size = new System.Drawing.Size(874, 387);
            this.tabBalance.TabIndex = 3;
            this.tabBalance.Text = "Balance";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 387);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Statement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Account Balance: ";
            // 
            // lblAcctNo
            // 
            this.lblAcctNo.AutoSize = true;
            this.lblAcctNo.Location = new System.Drawing.Point(619, 58);
            this.lblAcctNo.Name = "lblAcctNo";
            this.lblAcctNo.Size = new System.Drawing.Size(132, 20);
            this.lblAcctNo.TabIndex = 3;
            this.lblAcctNo.Text = "Account Number:";
            this.lblAcctNo.Click += new System.EventHandler(this.lblAcctNo_Click);
            // 
            // lblAccountNum
            // 
            this.lblAccountNum.AutoSize = true;
            this.lblAccountNum.Location = new System.Drawing.Point(768, 58);
            this.lblAccountNum.Name = "lblAccountNum";
            this.lblAccountNum.Size = new System.Drawing.Size(52, 20);
            this.lblAccountNum.TabIndex = 4;
            this.lblAccountNum.Text = "accno";
            this.lblAccountNum.Click += new System.EventHandler(this.lblAccountNum_Click);
            // 
            // lblAccountBal
            // 
            this.lblAccountBal.AutoSize = true;
            this.lblAccountBal.Location = new System.Drawing.Point(764, 90);
            this.lblAccountBal.Name = "lblAccountBal";
            this.lblAccountBal.Size = new System.Drawing.Size(117, 20);
            this.lblAccountBal.TabIndex = 5;
            this.lblAccountBal.Text = "____________";
            this.lblAccountBal.Click += new System.EventHandler(this.lblAccountBal_Click);
            // 
            // TransactionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 631);
            this.Controls.Add(this.lblAccountBal);
            this.Controls.Add(this.lblAccountNum);
            this.Controls.Add(this.lblAcctNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabTransaction);
            this.Name = "TransactionUI";
            this.Text = "TransactionUI";
            this.Load += new System.EventHandler(this.TransactionUI_Load);
            this.tabTransaction.ResumeLayout(false);
            this.tabDeposit.ResumeLayout(false);
            this.tabDeposit.PerformLayout();
            this.tabWithdraw.ResumeLayout(false);
            this.tabWithdraw.PerformLayout();
            this.tabTransfer.ResumeLayout(false);
            this.tabTransfer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabTransaction;
        private System.Windows.Forms.TabPage tabDeposit;
        private System.Windows.Forms.Label depositAmount;
        private System.Windows.Forms.TabPage tabWithdraw;
        private System.Windows.Forms.TabPage tabTransfer;
        private System.Windows.Forms.TabPage tabBalance;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox amountToDepo;
        private System.Windows.Forms.TextBox amountToWith;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox acctTranfer;
        private System.Windows.Forms.TextBox amountToTrans;
        private System.Windows.Forms.Label acctType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDepoAmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAcctNo;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblAccountNum;
        private System.Windows.Forms.Label lblAccountBal;
    }
}