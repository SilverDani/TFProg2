using System;

namespace GestorDeVentas.Clases
{
    public class Articulo
    {

        private int idArticulo, idProveedor;
        private string nombre;
        private decimal stock, precio;

        public int IdArticulo
        {
            get { return idArticulo; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("ID de artículo inválido.");

                idArticulo = value;
            }//set
        }//IdArticulo

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ingrese un nombre para el artículo.");

                nombre = value.Trim();
            }//set
        }//Nombre

        public decimal Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El stock no puede ser negativo.");

                stock = value;
            }//set
        }//Stock

        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio no puede ser negativo.");

                precio = value;
            }//set
        }//Precio

        public int IdProveedor
        {
            get { return idProveedor; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Seleccione un proveedor válido.");

                idProveedor = value;
            }//set
        }//IdProveedor

        public Articulo(int idArticulo, string nombre, decimal stock, decimal precio, int idProveedor)
        {
            IdArticulo = idArticulo;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
            IdProveedor = idProveedor;
        }//Cosntructor

    }//Class
}//Namespace