namespace CRUDTutorialUsingLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProgramingClassDataContext db = new ProgramingClassDataContext();
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prodid = int.Parse(textBox1.Text);
            string itemame = textBox2.Text, design = textBox3.Text, color = comboBox.Text;

        }
    }
}
