using System;
using System.Windows.Forms;

namespace PreSegundoParcial
{
    public partial class ModifyInventory : UserControl
    {
        public ModifyInventory()
        {
            InitializeComponent();
        }
        
        private void ModifyInventory_Load(object sender, EventArgs e)
        {
            poblarControles();
        }
        
        private void poblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idproducto";
            comboBox1.DisplayMember = "nombreproducto";
            comboBox1.DataSource = ConsultaInventario.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text.Equals("") && numericUpDown2.Value.Equals(0))
                {
                    ConexionDB.ExecuteNonQuery($"UPDATE INVENTARIO " +
                                               $"SET stock= {numericUpDown1.Value} " +
                                               $"WHERE idproducto = {comboBox1.SelectedValue}; ");

                    MessageBox.Show("Datos actualizados");
                }
                else if (numericUpDown2.Value.Equals(0))
                {
                    ConexionDB.ExecuteNonQuery($"UPDATE INVENTARIO " +
                                               $"SET stock= {numericUpDown1.Value}, descripcion = '{richTextBox1.Text}' " +
                                               $"WHERE idproducto = {comboBox1.SelectedValue}; ");

                    MessageBox.Show("Datos actualizados");
                }
                else if(richTextBox1.Text.Equals(""))
                {
                    ConexionDB.ExecuteNonQuery($"UPDATE INVENTARIO " +
                                               $"SET stock= {numericUpDown1.Value}, " +
                                               $"precio = {numericUpDown2.Value} " +
                                               $"WHERE idproducto = {comboBox1.SelectedValue}; ");

                    MessageBox.Show("Datos actualizados");
                }
                else
                {
                    ConexionDB.ExecuteNonQuery($"UPDATE INVENTARIO " +
                                               $"SET stock= {numericUpDown1.Value}, descripcion = '{richTextBox1.Text}', " +
                                               $"precio = {numericUpDown2.Value} " +
                                               $"WHERE idproducto = {comboBox1.SelectedValue}; ");

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