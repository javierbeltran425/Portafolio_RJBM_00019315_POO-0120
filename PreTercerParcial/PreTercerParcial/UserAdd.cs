using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PreSegundoParcial
{
    public partial class UserAdd : UserControl
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo = "";
            try
            {
                if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                {
                 MessageBox.Show("No se pueden dejar campos vacíos");
                }
                else
                {
                
                    if (radioButton1.Checked)
                    {
                        tipo = "usuario";
                    }else if (radioButton2.Checked)
                    {
                        tipo = "administrador";
                    }
                    
                    ConexionDB.ExecuteNonQuery($"INSERT INTO public.usuario(nombre, contrasena, tipo)" +
                                               $"VALUES ('{textBox1.Text}', '{textBox2.Text}', '{tipo}');");
                    
                    MessageBox.Show("Se ha registrado al usuario");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}