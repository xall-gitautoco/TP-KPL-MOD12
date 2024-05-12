using System.Runtime.ConstrainedExecution;

namespace tpmodul12_1302220093
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = CekInput.CariTandaBilangan(Convert.ToInt32(textBox1.Text));
            }
            catch
            {
                label1.Text = "Input bukan angka!";
            }
        }

    }
}
