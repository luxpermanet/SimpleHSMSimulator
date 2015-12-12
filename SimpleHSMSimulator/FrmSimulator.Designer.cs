namespace SimpleHSMSimulator
{
    partial class FrmSimulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZmkComp1 = new System.Windows.Forms.TextBox();
            this.txtZmkComp1KCV = new System.Windows.Forms.TextBox();
            this.txtZmkComp2 = new System.Windows.Forms.TextBox();
            this.txtZmkComp2KCV = new System.Windows.Forms.TextBox();
            this.txtZmkComp3 = new System.Windows.Forms.TextBox();
            this.txtZmkComp3KCV = new System.Windows.Forms.TextBox();
            this.txtZmkCombined = new System.Windows.Forms.TextBox();
            this.txtZmkCombinedKCV = new System.Windows.Forms.TextBox();
            this.txtEncryptedKey = new System.Windows.Forms.TextBox();
            this.txtEncryptedKeyKCV = new System.Windows.Forms.TextBox();
            this.txtClearKey = new System.Windows.Forms.TextBox();
            this.txtClearKeyKCV = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZMK Component Part1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Key Check Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ZMK Component Part2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ZMK Component Part3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ZMK Combined";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Encrypted Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Clear Key";
            // 
            // txtZmkComp1
            // 
            this.txtZmkComp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZmkComp1.Location = new System.Drawing.Point(12, 25);
            this.txtZmkComp1.Name = "txtZmkComp1";
            this.txtZmkComp1.Size = new System.Drawing.Size(471, 20);
            this.txtZmkComp1.TabIndex = 1;
            // 
            // txtZmkComp1KCV
            // 
            this.txtZmkComp1KCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZmkComp1KCV.Location = new System.Drawing.Point(490, 25);
            this.txtZmkComp1KCV.Name = "txtZmkComp1KCV";
            this.txtZmkComp1KCV.ReadOnly = true;
            this.txtZmkComp1KCV.Size = new System.Drawing.Size(87, 20);
            this.txtZmkComp1KCV.TabIndex = 0;
            this.txtZmkComp1KCV.TabStop = false;
            // 
            // txtZmkComp2
            // 
            this.txtZmkComp2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZmkComp2.Location = new System.Drawing.Point(12, 67);
            this.txtZmkComp2.Name = "txtZmkComp2";
            this.txtZmkComp2.Size = new System.Drawing.Size(471, 20);
            this.txtZmkComp2.TabIndex = 2;
            // 
            // txtZmkComp2KCV
            // 
            this.txtZmkComp2KCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZmkComp2KCV.Location = new System.Drawing.Point(490, 67);
            this.txtZmkComp2KCV.Name = "txtZmkComp2KCV";
            this.txtZmkComp2KCV.ReadOnly = true;
            this.txtZmkComp2KCV.Size = new System.Drawing.Size(87, 20);
            this.txtZmkComp2KCV.TabIndex = 0;
            this.txtZmkComp2KCV.TabStop = false;
            // 
            // txtZmkComp3
            // 
            this.txtZmkComp3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZmkComp3.Location = new System.Drawing.Point(12, 106);
            this.txtZmkComp3.Name = "txtZmkComp3";
            this.txtZmkComp3.Size = new System.Drawing.Size(471, 20);
            this.txtZmkComp3.TabIndex = 3;
            // 
            // txtZmkComp3KCV
            // 
            this.txtZmkComp3KCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZmkComp3KCV.Location = new System.Drawing.Point(490, 106);
            this.txtZmkComp3KCV.Name = "txtZmkComp3KCV";
            this.txtZmkComp3KCV.ReadOnly = true;
            this.txtZmkComp3KCV.Size = new System.Drawing.Size(87, 20);
            this.txtZmkComp3KCV.TabIndex = 0;
            this.txtZmkComp3KCV.TabStop = false;
            // 
            // txtZmkCombined
            // 
            this.txtZmkCombined.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZmkCombined.Location = new System.Drawing.Point(12, 145);
            this.txtZmkCombined.Name = "txtZmkCombined";
            this.txtZmkCombined.ReadOnly = true;
            this.txtZmkCombined.Size = new System.Drawing.Size(471, 20);
            this.txtZmkCombined.TabIndex = 0;
            this.txtZmkCombined.TabStop = false;
            // 
            // txtZmkCombinedKCV
            // 
            this.txtZmkCombinedKCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZmkCombinedKCV.Location = new System.Drawing.Point(490, 145);
            this.txtZmkCombinedKCV.Name = "txtZmkCombinedKCV";
            this.txtZmkCombinedKCV.ReadOnly = true;
            this.txtZmkCombinedKCV.Size = new System.Drawing.Size(87, 20);
            this.txtZmkCombinedKCV.TabIndex = 0;
            this.txtZmkCombinedKCV.TabStop = false;
            // 
            // txtEncryptedKey
            // 
            this.txtEncryptedKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncryptedKey.Location = new System.Drawing.Point(12, 184);
            this.txtEncryptedKey.Name = "txtEncryptedKey";
            this.txtEncryptedKey.Size = new System.Drawing.Size(471, 20);
            this.txtEncryptedKey.TabIndex = 4;
            // 
            // txtEncryptedKeyKCV
            // 
            this.txtEncryptedKeyKCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncryptedKeyKCV.Location = new System.Drawing.Point(490, 184);
            this.txtEncryptedKeyKCV.Name = "txtEncryptedKeyKCV";
            this.txtEncryptedKeyKCV.ReadOnly = true;
            this.txtEncryptedKeyKCV.Size = new System.Drawing.Size(87, 20);
            this.txtEncryptedKeyKCV.TabIndex = 0;
            this.txtEncryptedKeyKCV.TabStop = false;
            // 
            // txtClearKey
            // 
            this.txtClearKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClearKey.Location = new System.Drawing.Point(12, 223);
            this.txtClearKey.Name = "txtClearKey";
            this.txtClearKey.ReadOnly = true;
            this.txtClearKey.Size = new System.Drawing.Size(471, 20);
            this.txtClearKey.TabIndex = 0;
            this.txtClearKey.TabStop = false;
            // 
            // txtClearKeyKCV
            // 
            this.txtClearKeyKCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClearKeyKCV.Location = new System.Drawing.Point(490, 223);
            this.txtClearKeyKCV.Name = "txtClearKeyKCV";
            this.txtClearKeyKCV.ReadOnly = true;
            this.txtClearKeyKCV.Size = new System.Drawing.Size(87, 20);
            this.txtClearKeyKCV.TabIndex = 0;
            this.txtClearKeyKCV.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 249);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(565, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate Clear Key";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // FrmSimulator
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 280);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtClearKeyKCV);
            this.Controls.Add(this.txtClearKey);
            this.Controls.Add(this.txtEncryptedKeyKCV);
            this.Controls.Add(this.txtEncryptedKey);
            this.Controls.Add(this.txtZmkCombinedKCV);
            this.Controls.Add(this.txtZmkCombined);
            this.Controls.Add(this.txtZmkComp3KCV);
            this.Controls.Add(this.txtZmkComp3);
            this.Controls.Add(this.txtZmkComp2KCV);
            this.Controls.Add(this.txtZmkComp2);
            this.Controls.Add(this.txtZmkComp1KCV);
            this.Controls.Add(this.txtZmkComp1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "FrmSimulator";
            this.Text = "Simple HSM Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZmkComp1;
        private System.Windows.Forms.TextBox txtZmkComp1KCV;
        private System.Windows.Forms.TextBox txtZmkComp2;
        private System.Windows.Forms.TextBox txtZmkComp2KCV;
        private System.Windows.Forms.TextBox txtZmkComp3;
        private System.Windows.Forms.TextBox txtZmkComp3KCV;
        private System.Windows.Forms.TextBox txtZmkCombined;
        private System.Windows.Forms.TextBox txtZmkCombinedKCV;
        private System.Windows.Forms.TextBox txtEncryptedKey;
        private System.Windows.Forms.TextBox txtEncryptedKeyKCV;
        private System.Windows.Forms.TextBox txtClearKey;
        private System.Windows.Forms.TextBox txtClearKeyKCV;
        private System.Windows.Forms.Button btnGenerate;
    }
}

