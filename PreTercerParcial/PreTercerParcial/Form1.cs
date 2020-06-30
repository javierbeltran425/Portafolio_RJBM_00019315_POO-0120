using System;
using System.Windows.Forms;

namespace PreSegundoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

        public void poblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "contrasena";
            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = ConsultaUsuario.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usu = (Usuario) comboBox1.SelectedItem;
            string password = comboBox1.SelectedValue.ToString();
            string passIn = textBox1.Text;

            Proxy.IClient Prox = new Proxy.MyProxy();
            Prox.Petition(usu, this, password, passIn);
            
            textBox1.Text = "";
        }
    }
}