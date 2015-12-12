using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleHSMSimulator
{
    public partial class FrmSimulator : Form
    {
        public FrmSimulator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!this.ValidateControls())
            {
                return;
            }

            string clearKeyInString = string.Empty;
            string errMessage = string.Empty;
            bool success = Crypto.INSTANCE.Generate(txtZmkComp1.Text, txtZmkComp2.Text, txtZmkComp3.Text, txtEncryptedKey.Text, ref clearKeyInString, ref errMessage);

            if (success)
            {
                this.txtClearKey.Text = clearKeyInString;
            }
            else
            {
                this.txtClearKey.Text = string.Empty;
                MessageBox.Show(errMessage.ToString(), "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string kcvZMK1 = Crypto.INSTANCE.CalculateKCVwithDES(txtZmkComp1.Text);
                this.txtZmkComp1KCV.Text = kcvZMK1.Substring(0, 6);

                string kcvZMK2 = Crypto.INSTANCE.CalculateKCVwithDES(txtZmkComp2.Text);
                this.txtZmkComp2KCV.Text = kcvZMK2.Substring(0, 6);

                string kcvZMK3 = Crypto.INSTANCE.CalculateKCVwithDES(txtZmkComp3.Text);
                this.txtZmkComp3KCV.Text = kcvZMK3.Substring(0, 6);

                string zmkCombined = Crypto.INSTANCE.ZMKCombinedInString(txtZmkComp1.Text, txtZmkComp2.Text, txtZmkComp3.Text);
                this.txtZmkCombined.Text = zmkCombined;

                string kcvZMKCombined = Crypto.INSTANCE.CalculateKCVwithDES(zmkCombined);
                this.txtZmkCombinedKCV.Text = kcvZMKCombined.Substring(0, 6);

                string kcvEncryptedKey = Crypto.INSTANCE.CalculateKCVwithAES(txtEncryptedKey.Text);
                this.txtEncryptedKeyKCV.Text = kcvEncryptedKey.Substring(0, 6);

                string kcvClearKey = Crypto.INSTANCE.CalculateKCVwithAES(clearKeyInString);
                this.txtClearKeyKCV.Text = kcvClearKey.Substring(0, 6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on KCV Calculation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateControls()
        {
            StringBuilder errMessage = new StringBuilder();

            if (String.IsNullOrWhiteSpace(this.txtZmkComp1.Text))
                errMessage.AppendLine("Enter ZMK Component Part 1");

            if (String.IsNullOrWhiteSpace(this.txtZmkComp2.Text))
                errMessage.AppendLine("Enter ZMK Component Part 2");

            if (String.IsNullOrWhiteSpace(this.txtZmkComp3.Text))
                errMessage.AppendLine("Enter ZMK Component Part 3");

            if (String.IsNullOrWhiteSpace(this.txtEncryptedKey.Text))
                errMessage.AppendLine("Enter Encrypted Key");

            if (!String.IsNullOrWhiteSpace(errMessage.ToString()))
            {
                MessageBox.Show(errMessage.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
