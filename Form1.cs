using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace VsiteSeminar
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartPingMeasurement_Click(object sender, EventArgs e)
        {
            Ping p = new Ping();
            PingReply r;
            string s;

            s = textBoxIPAdress.Text;
            r = p.Send(s);

            if (r.Status == IPStatus.Success)
            {
                richTextBox1.Text = "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                   + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIPAdress.Text) || textBoxIPAdress.Text == "")
            {
                MessageBox.Show("Please use valid IP or web address!!");
            }
        }
    


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}

