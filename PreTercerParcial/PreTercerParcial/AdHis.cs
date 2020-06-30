using System;
using System.Windows.Forms;

namespace PreSegundoParcial
{
    public partial class AdHis : UserControl
    {
        public AdHis()
        {
            InitializeComponent();
        }

        private void AdHis_Load(object sender, EventArgs e)
        {
            ActGrid();
        }
        
        public void ActGrid()
        {

            try
            {
                var dt = ConexionDB.ExecuteQuery("SELECT pedido.idpedido, pedido.fecha, pedido.cantproducto, " +
                                                 "pedido.idproducto, inventario.nombreproducto, usuario.idusuario, " +
                                                 "usuario.nombre " +
                                                 "FROM PEDIDO, USUARIO, INVENTARIO " +
                                                 "WHERE pedido.idusuario = usuario.idusuario " +
                                                 "AND pedido.idproducto = inventario.idproducto ORDER BY idpedido ASC");
                dataGridView1.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("No ha sido posible actualizar el historial de ventas");
            }
            
        }
    }
}