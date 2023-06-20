using System.CodeDom;

namespace Fraction_GUI
{
    public partial class Form1 : Form
    {
        int FirstTop;
        int FirstBottom;
        int SecondTop;
        int SecondBottom;
        int NewTop;
        int NewBottom;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             NewTop = (FirstTop * SecondBottom) + (FirstBottom * SecondTop);
             NewBottom = FirstBottom * SecondBottom;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            NewTop = FirstTop * SecondBottom - FirstBottom * SecondTop;
            NewBottom = FirstBottom * SecondBottom;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            NewTop = FirstTop * SecondTop;
            NewBottom = FirstBottom * SecondBottom;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            NewTop = FirstTop * SecondBottom;
            NewBottom = FirstBottom * SecondTop;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FirstTop = Convert.ToInt32(textBox1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SecondTop = Convert.ToInt32(textBox4.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FirstBottom = Convert.ToInt32(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SecondBottom = Convert.ToInt32(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = NewTop.ToString();
            textBox6.Text = NewBottom.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "hello";
        }
    }
}