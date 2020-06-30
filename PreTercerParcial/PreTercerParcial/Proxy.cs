using System;
using System.Windows.Forms;

namespace PreSegundoParcial
{
    public class Proxy
    {
        public interface IClient
        {
            void Petition(Usuario user, Form1 form1, string password, string passIn);
        }

        public class MyProxy : IClient
        {
            public void Petition(Usuario user, Form1 form1, string password, string passIn)
            {
                try
                {
                    if (password == passIn)
                    {
                        if (user.Tipo.Equals("usuario"))
                        {
                            UserView u = new UserView(user, form1);
                            u.Show();
                            form1.Hide();
                        }else if (user.Tipo.Equals("administrador"))
                        {
                            AdminView admi = new AdminView(form1);
                            admi.Show();
                            form1.Hide();
                        } 
                    }else 
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}