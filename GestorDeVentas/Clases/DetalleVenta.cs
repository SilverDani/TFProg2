namespace GestorDeVentas.Clases
{
    using System;

    public class DetalleVenta
    {
        private int idVenta, idArticulo;
        private decimal cantidad, precio, subTotal;

        public int IdVenta
        {
            get { return idVenta; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("ID de venta inválido.");

                idVenta = value;
            }//set
        }//idventa

        public int IdArticulo
        {
            get { return idArticulo; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Seleccione un artículo válido.");

                idArticulo = value;
            }//set
        }//idArticulo

        public decimal Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La cantidad debe ser mayor que cero.");

                cantidad = value;
                CalcularSubTotal();
            }//set
        }//Cantidad

        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio no puede ser negativo.");

                precio = value;
                CalcularSubTotal();
            }//set
        }//Precio

        public decimal SubTotal
        {
            get { return subTotal; }
        }//SubTotal

        private void CalcularSubTotal()
        {
            subTotal = Math.Round(cantidad * precio, 2);
        }//CalcularSubTotal

        public DetalleVenta(int idVenta, int idArticulo, decimal cantidad, decimal precio)
        {
            IdVenta = idVenta;
            IdArticulo = idArticulo;
            Cantidad = cantidad;
            Precio = precio;
        }//Constructor
    }//class
}//Namespace