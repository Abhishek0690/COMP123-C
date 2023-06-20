namespace Week10_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1;
        int num2;
        int clicks = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 1;
            clicks++;
            switch(clicks)
            {
                case 1:
                    textBox1.Text = num1.ToString();
                    break;
                case 2:
                    textBox3.Text = num1.ToString();
                    break ;
            }
            int num2 = Convert.ToInt32(textBox3.Text);
            clicks = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = 2;
            clicks++;
            switch (clicks)
            {
                case 1:
                    textBox1.Text = num1.ToString();
                    break;
                case 2:
                    textBox3.Text = num1.ToString();
                    break;
            }
            int num2 = Convert.ToInt32(textBox3.Text);
            clicks = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = 3;
            switch (clicks)
            {
                case 1:
                    textBox1.Text = num1.ToString();
                    break;
                case 2:
                    textBox3.Text = num1.ToString();
                    break;
            }
            int num2 = Convert.ToInt32(textBox3.Text);
            clicks = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = 4;
            switch (clicks)
            {
                case 1:
                    textBox1.Text = num1.ToString();
                    break;
                case 2:
                    textBox3.Text = num1.ToString();
                    break;
            }
            int num2 = Convert.ToInt32(textBox3.Text);
            clicks = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = 5;
            switch (clicks)
            {
                case 1:
                    textBox1.Text = num1.ToString();
                    break;
                case 2:
                    textBox3.Text = num1.ToString();
                    break;
            }
            int num2 = Convert.ToInt32(textBox3.Text);
            clicks = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num1 = 6;
            switch (clicks)
            {
                case 1:
                    textBox1.Text = num1.ToString();
                    break;
                case 2:
                    textBox3.Text = num1.ToString();
                    break;
            }
            int num2 = Convert.ToInt32(textBox3.Text);
            clicks = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num1 = 7;
            switch (clicks)
            {
                case 1:
                    textBox1.Text = num1.ToString();
                    break;
                case 2:
                    textBox3.Text = num1.ToString();
                    break;
            }
            int num2 = Convert.ToInt32(textBox3.Text);
            clicks = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int num1 = 8;
            switch (clicks)
            {
                case 1:
                    textBox1.Text = num1.ToString();
                    break;
                case 2:
                    textBox3.Text = num1.ToString();
                    break;
            }
            int num2 = Convert.ToInt32(textBox3.Text);
            clicks = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int num1 = 9;
            switch (clicks)
            {
                case 1:
                    textBox1.Text = num1.ToString();
                    break;
                case 2:
                    textBox3.Text = num1.ToString();
                    break;
            }
            int num2 = Convert.ToInt32(textBox3.Text);
            clicks = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            switch (clicks)
            {
                case 1:
                    textBox1.Text = num1.ToString();
                    break;
                case 2:
                    textBox3.Text = num1.ToString();
                    break;
            }
            int num2 = Convert.ToInt32(textBox3.Text);
            clicks = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            clicks = 0;
        }
    }
}