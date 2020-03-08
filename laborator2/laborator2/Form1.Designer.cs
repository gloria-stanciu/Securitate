namespace laborator2
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
            this.comboBoxCipher = new System.Windows.Forms.ComboBox();
            this.generateKey = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelEnc = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPlainHex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCipherHex = new System.Windows.Forms.TextBox();
            this.labelEncTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCipher
            // 
            this.comboBoxCipher.FormattingEnabled = true;
            this.comboBoxCipher.Items.AddRange(new object[] {
            "DES",
            "3DES",
            "Rijndael"});
            this.comboBoxCipher.Location = new System.Drawing.Point(33, 12);
            this.comboBoxCipher.Name = "comboBoxCipher";
            this.comboBoxCipher.Size = new System.Drawing.Size(168, 21);
            this.comboBoxCipher.TabIndex = 0;
            this.comboBoxCipher.SelectedIndexChanged += new System.EventHandler(this.cipher_SelectedIndexChanged);
            // 
            // generateKey
            // 
            this.generateKey.Location = new System.Drawing.Point(33, 39);
            this.generateKey.Name = "generateKey";
            this.generateKey.Size = new System.Drawing.Size(168, 59);
            this.generateKey.TabIndex = 1;
            this.generateKey.Text = "Generate Key and IV";
            this.generateKey.UseVisualStyleBackColor = true;
            this.generateKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(33, 144);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(168, 55);
            this.Encrypt.TabIndex = 2;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Decrypt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelEnc
            // 
            this.labelEnc.Location = new System.Drawing.Point(33, 369);
            this.labelEnc.Name = "labelEnc";
            this.labelEnc.Size = new System.Drawing.Size(168, 55);
            this.labelEnc.TabIndex = 4;
            this.labelEnc.Text = "Get Encrypt Time";
            this.labelEnc.UseVisualStyleBackColor = true;
            this.labelEnc.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 481);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 56);
            this.button5.TabIndex = 5;
            this.button5.Text = "Get Decrypt Time";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(518, 39);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(379, 20);
            this.textBoxKey.TabIndex = 6;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // textBoxIV
            // 
            this.textBoxIV.Location = new System.Drawing.Point(518, 78);
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(379, 20);
            this.textBoxIV.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "IV";
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(518, 162);
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.Size = new System.Drawing.Size(379, 20);
            this.textBoxPlain.TabIndex = 10;
            this.textBoxPlain.TextChanged += new System.EventHandler(this.textBoxPlain_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Plain Text";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ASCII";
            // 
            // textBoxPlainHex
            // 
            this.textBoxPlainHex.Location = new System.Drawing.Point(518, 188);
            this.textBoxPlainHex.Name = "textBoxPlainHex";
            this.textBoxPlainHex.Size = new System.Drawing.Size(379, 20);
            this.textBoxPlainHex.TabIndex = 13;
            this.textBoxPlainHex.TextChanged += new System.EventHandler(this.textBoxPlainHex_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "HEX";
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Location = new System.Drawing.Point(518, 266);
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.Size = new System.Drawing.Size(379, 20);
            this.textBoxCipher.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cipher Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "ASCII";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "HEX";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxCipherHex
            // 
            this.textBoxCipherHex.Location = new System.Drawing.Point(518, 295);
            this.textBoxCipherHex.Name = "textBoxCipherHex";
            this.textBoxCipherHex.Size = new System.Drawing.Size(379, 20);
            this.textBoxCipherHex.TabIndex = 19;
            this.textBoxCipherHex.TextChanged += new System.EventHandler(this.textBoxCipherHex_TextChanged);
            // 
            // labelEncTime
            // 
            this.labelEncTime.AutoSize = true;
            this.labelEncTime.Location = new System.Drawing.Point(483, 390);
            this.labelEncTime.Name = "labelEncTime";
            this.labelEncTime.Size = new System.Drawing.Size(144, 13);
            this.labelEncTime.TabIndex = 20;
            this.labelEncTime.Text = "Time/message at encryption:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(483, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Time/message at decryption:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 596);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelEncTime);
            this.Controls.Add(this.textBoxCipherHex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCipher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPlainHex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPlain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelEnc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.generateKey);
            this.Controls.Add(this.comboBoxCipher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCipher;
        private System.Windows.Forms.Button generateKey;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button labelEnc;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPlainHex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCipherHex;
        private System.Windows.Forms.Label labelEncTime;
        private System.Windows.Forms.Label label10;
    }
}

