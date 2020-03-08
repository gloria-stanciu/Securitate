using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace sssLab3
{

    public partial class Form1 : Form
    {
        ConversionHandler myConverter = new ConversionHandler();

        public Form1()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(comboBoxMAC.Text);
            byte[] mac = mh.ComputeMAC(myConverter.StringToByteArray(textBoxPlain.Text), myConverter.StringToByteArray(textBoxKey.Text));
            textBoxMAC.Text = myConverter.ByteArrayToString(mac);
            textBoxMACHEX.Text = myConverter.ByteArrayToHexString(mac);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(comboBoxMAC.Text);
            if(mh.CheckAuthenticity(myConverter.StringToByteArray(textBoxPlain.Text),myConverter.HexStringToByteArray(textBoxMACHEX.Text),myConverter.StringToByteArray(textBoxKey.Text)) == true)
            {
                System.Windows.Forms.MessageBox.Show("MAC OK !!!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("MAC NOT OK !!!");
            }
        }

        private void textBoxPlain_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetHashTime_Click(object sender, EventArgs e)
        {
            MACHandler myMAC = new MACHandler(comboBoxMAC.Text);
            long startTime = DateTime.Now.Ticks;
            int count = 10000000;
            byte[] hashValue = myMAC.ComputeMAC(myConverter.StringToByteArray(textBoxPlain.Text), myConverter.StringToByteArray(textBoxKey.Text));
            textBoxMAC.Text = myConverter.ByteArrayToString(hashValue);
            textBoxMACHEX.Text = myConverter.ByteArrayToHexString(hashValue);
            double operationTime = (DateTime.Now.Ticks - startTime);
            operationTime = operationTime / (10 * count);
            HashTime.Text = "Hash time: " + operationTime.ToString() + " us";
        }
    }
}
