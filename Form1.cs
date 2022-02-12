using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

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
            //string IPAddress;
            //IPAddress = textBoxIPAdress.Text;
            var sender1 = sender;
            var e1 = e;

            if (string.IsNullOrWhiteSpace(textBoxPingPeriod.Text))
                timer1.Interval = 1000;
            else
                timer1.Interval = int.Parse(textBoxPingPeriod.Text) * 1000;

            timer1.Enabled = true;
            MeasurePing(sender1, e1);



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

        private void TextBoxIPAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MeasurePing(object sender, EventArgs e)
        {
            try
            {
                Ping p = new Ping();
                PingReply r;
                string IPAddress;
                IPAddress = textBoxIPAdress.Text;
                string PingPeriod;
                PingPeriod = textBoxPingPeriod.Text;

                r = p.Send(IPAddress);

                if (r.Status == IPStatus.Success)
                {
                    richTextBox1.Text = "Ping to " + IPAddress.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                       + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n" + "Ping period (s) = " + (timer1.Interval / 1000).ToString();
                }
            }
            catch (PingException ex)
            {
                richTextBox1.Text = "Encountered problem while pinging: " + ex.Message;
                timer1.Enabled = false;
                textBoxIPAdress.Text = "";
                textBoxPingPeriod.Text = "1";
            }



        }

        private void textBoxPingPeriod_TextChanged(object sender, EventArgs e)
        {
           // if (textBoxPingPeriod.Text == "")
                
           //     timer1.Interval = int.Parse(textBoxPingPeriod.Text) * 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var send = sender;
            var eventArgument = e;
            MeasurePing(send, eventArgument);
        }

        private void StopPingMeasurement_click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            richTextBox1.Text = "Ping measurement stopped!";
        }
    }
}

