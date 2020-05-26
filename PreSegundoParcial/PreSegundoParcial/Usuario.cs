namespace PreSegundoParcial
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string contrasena;
        private string tipo;

        public Usuario()
        {
        }

        public int IdUsuario
        {
            get => idUsuario;
            set => idUsuario = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Contrasena
        {
            get => contrasena;
            set => contrasena = value;
        }

        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }
    }
}