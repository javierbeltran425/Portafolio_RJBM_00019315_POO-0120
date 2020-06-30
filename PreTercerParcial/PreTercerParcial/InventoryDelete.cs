using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PreSegundoParcial
{
    public partial class InventoryDelete : UserControl
    {
        public InventoryDelete()
        {
            InitializeComponent();
        }
        
        private void InventoryDelete_Load(object sender, EventArgs e)
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
            int stock = 0;
            try
            {
                DataTable dt = new DataTable();
                dt = ConexionDB.ExecuteQuery($"SELECT stock FROM INVENTARIO " +
                                             $"WHERE idproducto = {comboBox1.SelectedValue} ");
                
                foreach (DataRow fila in dt.Rows)
                {
                    stock = Convert.ToInt32(fila[0].ToString());

                }
                
                
                if ( stock == 0 )
                {
                    
                    ConexionDB.ExecuteNonQuery($"DELETE FROM INVENTARIO " +
                                               $"WHERE idproducto = {comboBox1.SelectedValue}");
                
                    MessageBox.Show("Producto eliminado correctamente");    
                }
                else
                {
                    MessageBox.Show("No puede eliminar si hay en stock");
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Se generó una excepción" + exception.Message);
            }
        }
    }
}