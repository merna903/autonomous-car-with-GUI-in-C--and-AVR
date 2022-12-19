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
            this.button3.BackColor = System.Drawing.Color.FromArgb(136, 14, 79);
            Refresh();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.FromArgb(194, 24, 91);
            Refresh();
        }


        private void arrowButton4_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.FromArgb(136, 14, 79);
            Refresh();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.FromArgb(194, 24, 91);
            Refresh();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.FromArgb(136, 14, 79);
            Refresh();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.FromArgb(194, 24, 91);
            Refresh();
        }
    }
}