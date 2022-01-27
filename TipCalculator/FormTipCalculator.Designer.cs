
namespace TipCalculator {
    partial class FormTipCalculator {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillAmt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTipPercent = new System.Windows.Forms.TextBox();
            this.txtTipAmt = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Amount:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBillAmt
            // 
            this.txtBillAmt.Location = new System.Drawing.Point(222, 71);
            this.txtBillAmt.Name = "txtBillAmt";
            this.txtBillAmt.Size = new System.Drawing.Size(150, 31);
            this.txtBillAmt.TabIndex = 1;
            this.txtBillAmt.TextChanged += new System.EventHandler(this.txtBillAmt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip Percent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tip Amount:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(61, 304);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 34);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Tip";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTipPercent
            // 
            this.txtTipPercent.Location = new System.Drawing.Point(222, 149);
            this.txtTipPercent.Name = "txtTipPercent";
            this.txtTipPercent.ReadOnly = true;
            this.txtTipPercent.Size = new System.Drawing.Size(150, 31);
            this.txtTipPercent.TabIndex = 5;
            // 
            // txtTipAmt
            // 
            this.txtTipAmt.Location = new System.Drawing.Point(222, 221);
            this.txtTipAmt.Name = "txtTipAmt";
            this.txtTipAmt.ReadOnly = true;
            this.txtTipAmt.Size = new System.Drawing.Size(150, 31);
            this.txtTipAmt.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(243, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormTipCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(449, 381);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTipAmt);
            this.Controls.Add(this.txtTipPercent);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBillAmt);
            this.Controls.Add(this.label1);
            this.Name = "FormTipCalculator";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBillAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTipPercent;
        private System.Windows.Forms.TextBox txtTipAmt;
        private System.Windows.Forms.Button btnExit;
    }
}

