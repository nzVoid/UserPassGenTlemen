namespace UserPassGenTlemen
{
    public partial class Form1 : Form
    {
        private static Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Lenght(" + trackBar1.Value.ToString() + ")";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            const string number = "01234567890123456789";
            const string lowercase_char = "abcdefghigklmnopqrstuvwxyz";
            const string uppercase_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string special_chars = "!@#$%^&*/!@#$%^&*/";
            string gen_chars = " ";
            if (checkBox1.Checked)
            {
                gen_chars += special_chars;
            }
            if (checkBox2.Checked)
            {
                gen_chars += uppercase_chars;
            }
            if (checkBox3.Checked)
            {
                gen_chars += lowercase_char;
            }
            if (checkBox4.Checked)
            {
                gen_chars += number;
            }
            

            for (int i = 0; i < trackBar1.Value; i++)
            {
                textBox1.Text += gen_chars[rnd.Next(gen_chars.Length)];
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Lenght(" + trackBar1.Value.ToString() + ")";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
    }
}