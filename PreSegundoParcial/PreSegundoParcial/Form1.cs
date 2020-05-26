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
            try
            {
                if (comboBox1.SelectedValue.Equals(textBox1.Text))
                {
                    if (usu.Tipo.Equals("usuario"))
                    {
                        UserView u = new UserView(usu, this);
                        u.Show();
                        this.Hide();
                        textBox1.Text = "";
                    }else if (usu.Tipo.Equals("administrador"))
                    {
                        AdminView admi = new AdminView(this);
                        admi.Show();
                        this.Hide();
                        textBox1.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}