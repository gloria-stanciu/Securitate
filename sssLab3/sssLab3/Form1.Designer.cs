namespace sssLab3
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
            this.comboBoxMAC = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMAC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMACHEX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GetHashTime = new System.Windows.Forms.Button();
            this.GetHMACTime = new System.Windows.Forms.Button();
            this.HashTime = new System.Windows.Forms.Label();
            this.HMACTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxMAC
            // 
            this.comboBoxMAC.FormattingEnabled = true;
            this.comboBoxMAC.Items.AddRange(new object[] {
            "SHA1",
            "MD5",
            "RIPEMD",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.comboBoxMAC.Location = new System.Drawing.Point(26, 21);
            this.comboBoxMAC.Name = "comboBoxMAC";
            this.comboBoxMAC.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMAC.TabIndex = 0;
            this.comboBoxMAC.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Compute MAC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Verify MAC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(222, 21);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(148, 20);
            this.textBoxKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ASCII";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key";
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(224, 107);
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.Size = new System.Drawing.Size(146, 20);
            this.textBoxPlain.TabIndex = 6;
            this.textBoxPlain.TextChanged += new System.EventHandler(this.textBoxPlain_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ASCII";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plain Text";
            // 
            // textBoxMAC
            // 
            this.textBoxMAC.Location = new System.Drawing.Point(222, 211);
            this.textBoxMAC.Name = "textBoxMAC";
            this.textBoxMAC.Size = new System.Drawing.Size(147, 20);
            this.textBoxMAC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MAC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ASCII";
            // 
            // textBoxMACHEX
            // 
            this.textBoxMACHEX.Location = new System.Drawing.Point(222, 253);
            this.textBoxMACHEX.Name = "textBoxMACHEX";
            this.textBoxMACHEX.Size = new System.Drawing.Size(146, 20);
            this.textBoxMACHEX.TabIndex = 12;
            this.textBoxMACHEX.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "HEX";
            // 
            // GetHashTime
            // 
            this.GetHashTime.Location = new System.Drawing.Point(26, 308);
            this.GetHashTime.Name = "GetHashTime";
            this.GetHashTime.Size = new System.Drawing.Size(121, 23);
            this.GetHashTime.TabIndex = 14;
            this.GetHashTime.Text = "Get hash time";
            this.GetHashTime.UseVisualStyleBackColor = true;
            this.GetHashTime.Click += new System.EventHandler(this.GetHashTime_Click);
            // 
            // GetHMACTime
            // 
            this.GetHMACTime.Location = new System.Drawing.Point(26, 358);
            this.GetHMACTime.Name = "GetHMACTime";
            this.GetHMACTime.Size = new System.Drawing.Size(121, 30);
            this.GetHMACTime.TabIndex = 15;
            this.GetHMACTime.Text = "Get HMAC time";
            this.GetHMACTime.UseVisualStyleBackColor = true;
            // 
            // HashTime
            // 
            this.HashTime.AutoSize = true;
            this.HashTime.Location = new System.Drawing.Point(217, 313);
            this.HashTime.Name = "HashTime";
            this.HashTime.Size = new System.Drawing.Size(58, 13);
            this.HashTime.TabIndex = 16;
            this.HashTime.Text = "Hash Time";
            // 
            // HMACTime
            // 
            this.HMACTime.AutoSize = true;
            this.HMACTime.Location = new System.Drawing.Point(219, 367);
            this.HMACTime.Name = "HMACTime";
            this.HMACTime.Size = new System.Drawing.Size(64, 13);
            this.HMACTime.TabIndex = 17;
            this.HMACTime.Text = "HMAC Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 400);
            this.Controls.Add(this.HMACTime);
            this.Controls.Add(this.HashTime);
            this.Controls.Add(this.GetHMACTime);
            this.Controls.Add(this.GetHashTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMACHEX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMAC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPlain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxMAC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMAC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMAC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMACHEX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GetHashTime;
        private System.Windows.Forms.Button GetHMACTime;
        private System.Windows.Forms.Label HashTime;
        private System.Windows.Forms.Label HMACTime;
    }
}

