using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PreSegundoParcial
{
    public partial class UserView : Form
    {
        
        
        Usuario usuarioLogeado = new Usuario();
        Form1 princial = new Form1();
        public UserView(Usuario usu, Form1 form1)
        {
            InitializeComponent();
            usuarioLogeado = usu;
            princial = form1;
        }
        
        private void UserView_Load(object sender, EventArgs e)
        {
            poblarControles();
            ActGrid();
        }
        
        private void poblarControles()
        {
            listBox1.DataSource = null;
            listBox1.ValueMember = "idproducto";
            listBox1.DisplayMember = "nombreproducto";
            listBox1.DataSource = ConsultaInventario.getLista();
        }
        
        public void ActGrid()
        {
            double suma = 0;
            double multiplicacion = 0;
            
            var dt = ConexionDB.ExecuteQuery($"SELECT	ped.idpedido, ped.cantproducto, " +
                                             $"inv.nombreproducto, inv.precio AS PrecioUnidad, " +
                                             $"ped.fecha FROM PEDIDO ped, USUARIO usu, " +
                                             $"INVENTARIO inv WHERE usu.idusuario = {usuarioLogeado.IdUsuario} AND " +
                                             $"ped.idusuario = usu.idusuario AND ped.idproducto = inv.idproducto " +
                                             $"AND ped.idproducto = inv.idproducto");
            dataGridView1.DataSource = dt;
            
            foreach (DataRow fila in dt.Rows)
            {
                
                multiplicacion = Convert.ToInt32(fila[1].ToString()) * Convert.ToDouble(fila[3].ToString());
                suma = suma + multiplicacion;
                
            }

            label1.Text = "$" + suma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cant = 0;
            int stock = 0;
            int resta = 0;

            try
            {
                DataTable dt1 = new DataTable();
                dt1 = ConexionDB.ExecuteQuery($"SELECT stock FROM INVENTARIO WHERE idproducto = {listBox1.SelectedValue} ");
                foreach (DataRow fila in dt1.Rows)
                {
                    stock = Convert.ToInt32(fila[0].ToString());
                }

                if (stock != 0)
                {
                    stock = 0;
                    ConexionDB.ExecuteNonQuery($"INSERT INTO PEDIDO (cantproducto, idproducto, idusuario) " +
                                               $"VALUES ({numericUpDown1.Value}, {listBox1.SelectedValue}, " +
                                               $"{usuarioLogeado.IdUsuario})");
                    ActGrid();
            
                    DataTable dt = new DataTable();
                    dt = ConexionDB.ExecuteQuery($"SELECT stock FROM INVENTARIO WHERE idproducto = {listBox1.SelectedValue} ");
                
                    foreach (DataRow fila in dt.Rows)
                    {
                        stock = Convert.ToInt32(fila[0].ToString());
                    }

                    cant = Convert.ToInt32(numericUpDown1.Text);
                    resta = stock - cant;

                    ConexionDB.ExecuteNonQuery($"UPDATE public.inventario " +
                                               $"SET stock={resta} " +
                                               $"WHERE idproducto = {listBox1.SelectedValue};");    
                }
                else
                {
                    MessageBox.Show("Este producto se ha agotado");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("No se ha podido procesar su compra");
            }
        }

        private void UserView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            princial.poblarControles();
            princial.Show();
        }
        
    }
}