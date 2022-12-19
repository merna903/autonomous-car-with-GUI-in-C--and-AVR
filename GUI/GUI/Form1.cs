using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            Refresh();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void arrowButton4_Click(object sender, EventArgs e)
        {

        }
    }
}