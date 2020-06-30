using System;
using System.Collections.Generic;
using System.Data;

namespace PreSegundoParcial
{
    public static class ConsultaInventario
    {
        public static List<Inventario> getLista()
        {
            string sql = "SELECT * FROM INVENTARIO";

            DataTable dt = ConexionDB.ExecuteQuery(sql);

            List<Inventario> lista = new List<Inventario>();
            foreach (DataRow fila in dt.Rows)
            {
                Inventario producto = new Inventario();
                producto.Idproducto = Convert.ToInt32(fila[0].ToString());
                producto.Nombreproducto = fila[1].ToString();
                producto.Descripcion = fila[2].ToString();
                producto.Precio = Convert.ToDouble(fila[3].ToString());
                producto.Stock = Convert.ToInt32(fila[4].ToString());
                
                lista.Add(producto);
            }

            return lista;
        }
    }
}