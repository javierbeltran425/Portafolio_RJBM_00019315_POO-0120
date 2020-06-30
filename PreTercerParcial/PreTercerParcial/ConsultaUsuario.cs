using System;
using System.Collections.Generic;
using System.Data;

namespace PreSegundoParcial
{
    public static class ConsultaUsuario
    {
        public static List<Usuario> getLista()
        {
            string sql = "SELECT * FROM USUARIO";

            DataTable dt = ConexionDB.ExecuteQuery(sql);

            List<Usuario> lista = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario usaurio = new Usuario();
                usaurio.IdUsuario = Convert.ToInt32(fila[0].ToString());
                usaurio.Nombre = fila[1].ToString();
                usaurio.Contrasena = fila[2].ToString();
                usaurio.Tipo = fila[3].ToString();
                
                lista.Add(usaurio);
            }

            return lista;
        }
    }
}