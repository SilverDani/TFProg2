using System;

namespace GestorDeVentas.Clases
{
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
            }
        }

        public int IdArticulo
        {
            get { return idArticulo; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Seleccione un artículo válido.");

                idArticulo = value;
            }
        }

        public decimal Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La cantidad debe ser mayor que cero.");

                cantidad = value;
                CalcularSubTotal();
            }
        }

        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio no puede ser negativo.");

                precio = value;
                CalcularSubTotal();
            }
        }

        public decimal SubTotal
        {
            get { return subTotal; }
        }

        private void CalcularSubTotal()
        {
            subTotal = Math.Round(cantidad * precio, 2);
        }

        public DetalleVenta(int idVenta, int idArticulo, decimal cantidad, decimal precio)
        {
            IdVenta = idVenta;
            IdArticulo = idArticulo;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}