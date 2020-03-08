using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace laborator2
{
    public partial class Form1 : Form
    {
        ConversionHandler myConverter = new ConversionHandler();
        SymmetricAlgorithm mySymmetricAlg;

        public Form1()
        {
            InitializeComponent();
        }
        public void Generate(string cipher)
        {
            switch (cipher)
            {
                case "DES":
                    mySymmetricAlg = DES.Create();
                    break;
                case "3DES":
                    mySymmetricAlg = TripleDES.Create();
                    break;
                case "Rijndael":
                    mySymmetricAlg = Rijndael.Create();
                    break;
            }
            mySymmetricAlg.GenerateIV();
            mySymmetricAlg.GenerateKey();
        }
        public byte[] EncryptCode(byte[] mess, byte[] key, byte[] iv)
        {
            mySymmetricAlg.Key = key;
            mySymmetricAlg.IV = iv;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(mess, 0, mess.Length);
            cs.Close();
            return ms.ToArray();
        }

        public byte[] Decrypt(byte[] mess, byte[] key, byte[] iv)
        {
            byte[] plaintext = new byte[mess.Length];
            mySymmetricAlg.Key = key;
            mySymmetricAlg.IV = iv;
            MemoryStream ms = new MemoryStream(mess);
            CryptoStream cs = new CryptoStream(ms,mySymmetricAlg.CreateDecryptor(),CryptoStreamMode.Read);
            cs.Read(plaintext, 0, mess.Length);
            cs.Close();
            return plaintext;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Generate(comboBoxCipher.Text);
            textBoxKey.Text = myConverter.ByteArrayToHexString(mySymmetricAlg.Key);
            textBoxIV.Text = myConverter.ByteArrayToHexString(mySymmetricAlg.IV);
        }

        private void cipher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] ciphertext =  EncryptCode(myConverter.StringToByteArray(textBoxPlain.Text), myConverter.HexStringToByteArray(textBoxKey.Text), myConverter.HexStringToByteArray(textBoxIV.Text));
            textBoxCipher.Text = myConverter.ByteArrayToString(ciphertext);
            textBoxCipherHex.Text = myConverter.ByteArrayToHexString(ciphertext);
            textBoxPlainHex.Text = myConverter.ByteArrayToHexString(myConverter.StringToByteArray(textBoxPlain.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] plaintext = Decrypt(myConverter.HexStringToByteArray(textBoxCipherHex.Text), myConverter.HexStringToByteArray(textBoxKey.Text), myConverter.HexStringToByteArray(textBoxIV.Text));
            textBoxPlain.Text = myConverter.ByteArrayToString(plaintext);
            textBoxPlainHex.Text = myConverter.ByteArrayToHexString(plaintext);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mySymmetricAlg.GenerateIV(); // generates a fresh IV
            mySymmetricAlg.GenerateKey(); // generates a fresh Key
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] mes_block = new byte[8];
            long start_time = DateTime.Now.Ticks;
            int count = 10000000;
            for (int i = 0; i < count; i++)
            {
                cs.Write(mes_block, 0, mes_block.Length);
            }
            cs.Close();
            double operation_time = (DateTime.Now.Ticks - start_time);
            operation_time = operation_time / (10 * count); // 1 tick is 100 ns, i.e., 1 / 10 of 1 us
            labelEncTime.Text = "Time for encryption of a message block: " + operation_time.ToString() + " us";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPlain_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPlainHex_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*mySymmetricAlg.IV = myConverter.HexStringToByteArray(textBoxIV.Text);
            mySymmetricAlg.Key = myConverter.HexStringToByteArray(textBoxKey.Text);
            byte[] cipher = myConverter.HexStringToByteArray(textBoxCipherHex.Text);
            byte[] plaintext = new byte[cipher.Length];
            long startTime = DateTime.Now.Ticks;
            MemoryStream ms = new MemoryStream(cipher);
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateDecryptor(), CryptoStreamMode.Read);
            int count = 10000000;
            for (int i = 0; i < count; i++)
            {
                cs.Read(plaintext, 0, cipher.Length);
            }
            cs.Close();
            double operationTime = (DateTime.Now.Ticks - startTime);
            operationTime = operationTime / (10 * count); //1 tick is 100 ns
            label10.Text = "Time for decryption of a message block: " + operationTime.ToString() + " us";*/

        }

        private void textBoxCipherHex_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
