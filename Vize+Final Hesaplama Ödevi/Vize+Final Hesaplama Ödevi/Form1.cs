namespace Vize_Final_Hesaplama_Ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama, vize, final;

            try
            {
                vize = Convert.ToDouble(numericUpDown1.Value);
                final = Convert.ToDouble(numericUpDown2.Value);

                ortalama = vize * 0.4 + final * 0.6;
                label3.Text = ortalama.ToString();
                if (final < 50)
                {
                    label3.Text = "FF ile dersten kaldınız.";
                    label3.ForeColor = Color.Red;
                }
                else if (ortalama >= 87)
                {
                    label3.Text = "AA ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ortalama >= 81)
                {
                    label3.Text = "BA ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ortalama >= 74)
                {
                    label3.Text = "BB ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ortalama >= 67)
                {
                    label3.Text = "CB ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ortalama >= 60)
                {
                    label3.Text = "CC ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ortalama >= 53)
                {
                    label3.Text = "DC ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ortalama >= 46)
                {
                    label3.Text = "DD ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ortalama >= 39)
                {
                    label3.Text = "FD ile dersten kaldınız.";
                    label3.ForeColor = Color.Red;
                }
                else if (ortalama >= 0)
                {
                    label3.Text = "FF ile dersten kaldınız.";
                    label3.ForeColor = Color.Red;
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}