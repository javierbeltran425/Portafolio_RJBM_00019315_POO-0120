namespace PreSegundoParcial
{
    public class Inventario
    {
        private int idproducto;
        private string nombreproducto;
        private string descripcion;
        private double precio;
        private int stock;

        public Inventario()
        {
        }

        public int Idproducto
        {
            get => idproducto;
            set => idproducto = value;
        }

        public string Nombreproducto
        {
            get => nombreproducto;
            set => nombreproducto = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        public double Precio
        {
            get => precio;
            set => precio = value;
        }

        public int Stock
        {
            get => stock;
            set => stock = value;
        }
    }
}