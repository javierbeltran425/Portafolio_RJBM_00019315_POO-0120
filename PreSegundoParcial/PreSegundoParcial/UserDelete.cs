using System;
using System.Windows.Forms;

namespace PreSegundoParcial
{
    public partial class UserDelete : UserControl
    {
        public UserDelete()
        {
            InitializeComponent();
        }

        private void UserDelete_Load(object sender, EventArgs e)
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
            try
            {
                ConexionDB.ExecuteNonQuery($"DELETE FROM USUARIO WHERE idUsuario = '{comboBox1.SelectedValue}'");
                
                MessageBox.Show("Usuario eliminado correctamente");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}