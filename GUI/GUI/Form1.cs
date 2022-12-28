using System.IO.Ports;
using System.Drawing.Drawing2D;
namespace GUI
{
    public partial class Form1 : Form
    {
        SerialPort port = null;
        string data_rx="000";
        int distance = 0;
        int flag=0;
        public Form1()
        {
            InitializeComponent();
            Refresh();
            refresh_com();
        }

        private void refresh_com()
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
        }

        private void connect()
        {
            port = new SerialPort(comboBox1.SelectedItem.ToString());
            port.DataReceived += new SerialDataReceivedEventHandler(data_rx_handler);
            port.BaudRate = 9600;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void data_rx_handler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string tmp = sp.ReadExisting();
            data_rx = tmp;
            data_rx += "0";
        }


        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.FromArgb(136, 14, 79);
            Refresh();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.FromArgb(194, 24, 91);
            Refresh();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.Gray;
            Refresh();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            Refresh();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.Gray;
            Refresh();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            Refresh();
        }

        //connect with port
        private void button4_Click(object sender, EventArgs e)
        {
            connect();
        }

        //Auto Play send a char 1
        private void button1_Click(object sender, EventArgs e)
        {
            port.Write("1");
            Console.Write("1");
        }

        // Manual play send a char 2
        private void button2_Click(object sender, EventArgs e)
        {
            port.Write("2");
            Console.Write("2");
        }

        // up
        private void arrowButton1_Click(object sender, EventArgs e)
        {
            port.Write("3");
        }

        // down
        private void arrowButton3_Click(object sender, EventArgs e)
        {
            port.Write("4");
        }

        // right
        private void arrowButton2_Click(object sender, EventArgs e)
        {
            port.Write("5");
        }

        // left
        private void arrowButton4_Click(object sender, EventArgs e)
        {
            port.Write("6");
        }

        // stop
        private void button3_Click(object sender, EventArgs e)
        {
            port.Write("7");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = data_rx;
            distance = int.Parse(data_rx);
            label2.Text = distance < 40 ? "Obstacle in range" : "No Obstacles";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void disconnect()
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Close();
                }
            }
            catch (Exception ex) { }
        }
    }
}