using System;
using System.Windows.Forms;

namespace PreSegundoParcial
{
    public partial class ModifyUser : UserControl
    {
        public ModifyUser()
        {
            InitializeComponent();
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            poblarControles();
        }
        
        private void poblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idUsuario";
            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = ConsultaUsuario.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo = "";
            try
            {
                if (radioButton1.Checked) { tipo = "usuario"; }
                if (radioButton2.Checked) { tipo = "administrador"; }
                
                if (textBox2.Text.Equals(""))
                {
                    ConexionDB.ExecuteNonQuery($"UPDATE usuario SET " +
                                               $"tipo='{tipo}' WHERE idUsuario={comboBox1.SelectedValue};");
                    
                    MessageBox.Show("Datos actualizados");
                }
                else
                {
                    ConexionDB.ExecuteNonQuery($"UPDATE usuario SET contrasena='{textBox2.Text}', " +
                                               $"tipo='{tipo}' WHERE idUsuario ={comboBox1.SelectedValue};");
                    
                    MessageBox.Show("Datos actualizados");
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}