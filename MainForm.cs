using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace VsiteSeminar
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStartPingMeasurement_Click(object sender, EventArgs e)
        {

            try
            {
                //string IPAddress;
                //IPAddress = textBoxIPAdress.Text;
                var sender1 = sender;
                var e1 = e;
                textBoxIPAddress.Enabled = false;
                if (string.IsNullOrWhiteSpace(textBoxPingPeriod.Text))
                    pingPeriodTimer.Interval = 1000;
                else
                    pingPeriodTimer.Interval = int.Parse(textBoxPingPeriod.Text) * 1000;

                pingPeriodTimer.Enabled = true;
                MeasurePing(sender1, e1);
            }
            catch (FormatException)
            {
                textBoxOutput.Text = "Check your Ping period format, it must be a number! Enter a valid ping period and start measurement again";
                pingPeriodTimer.Enabled = false;
                textBoxIPAddress.Enabled = true;
                textBoxPingPeriod.Text = "1";
            }




        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIPAddress.Text) || textBoxIPAddress.Text == "")
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
                IPAddress = textBoxIPAddress.Text;
                string PingPeriod;
                PingPeriod = textBoxPingPeriod.Text;

                r = p.Send(IPAddress);

                if (r.Status == IPStatus.Success)
                {
                    textBoxOutput.Text = "Ping to " + IPAddress.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                       + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n" + "Ping period (s) = " + (pingPeriodTimer.Interval / 1000).ToString();
                }
            }
            catch (PingException ex)
            {
                textBoxOutput.Text = ex.Message + "Check your IP Address / URL";
                pingPeriodTimer.Enabled = false;
            }
            catch (ArgumentNullException ex)
            {
                textBoxOutput.Text = ex.Message + ". Enter a valid URL / IP Address!";
                pingPeriodTimer.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
            


        }

        private void textBoxPingPeriod_TextChanged(object sender, EventArgs e)
        {
           // if (textBoxPingPeriod.Text == "")
                
           //     timer1.Interval = int.Parse(textBoxPingPeriod.Text) * 1000;
        }

        private void timerPingPeriod_Tick(object sender, EventArgs e)
        {
            var send = sender;
            var eventArgument = e;
            MeasurePing(send, eventArgument);
        }

        private void buttonStopPingMeasurement_click(object sender, EventArgs e)
        {
            pingPeriodTimer.Enabled = false;
            textBoxIPAddress.Enabled = true;
            textBoxOutput.Text = "Ping measurement stopped! Enter an URL / IP Address and start measurement again!";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

