namespace Contatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //METODO CRIADO QUANDO CLICA-SE NO LOGOTIPO
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de contatos V1.0 \ncriado por: Rafael A. Facchin", "Sobre");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}