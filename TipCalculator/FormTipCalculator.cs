using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator {
    public partial class FormTipCalculator : Form {
        public FormTipCalculator() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            var billAmount = Convert.ToDecimal(txtBillAmt.Text);

            var tipPercent = 0.2m;
            txtTipPercent.Text = tipPercent.ToString("p0");

            var tipAmount = billAmount * tipPercent;
            txtTipAmt.Text = tipAmount.ToString("c");
        }

        private void txtBillAmt_TextChanged(object sender, EventArgs e) {

        }
    }
}
