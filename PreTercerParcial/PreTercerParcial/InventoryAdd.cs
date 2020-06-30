using System;
using System.Windows.Forms;

namespace PreSegundoParcial
{
    public partial class InventoryAdd : UserControl
    {
        public InventoryAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || numericUpDown1.Value.Equals(0) || numericUpDown2.Value.Equals(0))
            {
                MessageBox.Show("No se pueden dejar campos vacíos");
            }
            else
            {
                try
                {
                    ConexionDB.ExecuteNonQuery($"INSERT INTO INVENTARIO " +
                                               $"(nombreproducto, descripcion, precio, stock) " +
                                               $"VALUES ('{textBox1.Text}', '{richTextBox1.Text}', {numericUpDown2.Value}, " +
                                               $"{numericUpDown1.Value})");
                    
                    MessageBox.Show("Se ha registrado el producto");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}