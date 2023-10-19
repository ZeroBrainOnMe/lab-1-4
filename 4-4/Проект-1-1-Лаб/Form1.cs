namespace Проект_1_1_Лаб
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBoxX.Text),
                   y = Convert.ToDouble(textBoxY.Text),
                   c = Convert.ToDouble(textBoxC.Text);

            double d, d1, d2;
            double total = 0;

            if ((x > 0) && (Math.Exp(-x) >= y))
            {
                d = Math.Pow(x, 3);
                d1 = Math.Exp(-x + 1);
                d2 = Math.Max(Math.Log(x), x + y);

                total = Math.Min(d, Math.Min(d1, d2));
            }
            else
            {
                if ((x <= 0) && (Math.Exp(-x) >= y))
                {
                    total = 1 - Math.Pow(x, 2);
                }
                else
                {
                    d = Math.Pow(c, 2) * x;
                    d1 = Math.Cos(x + y);
                    total = Math.Max(d, d1);
                }
            }
            textBoxD.Text = Convert.ToString(total);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}