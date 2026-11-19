using System;

namespace GestorDeVentas.Clases
{
    public class Venta
    {
        private int idVenta, idCliente;
        private DateTime fecha;
        private decimal total;

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

        public int IdCliente
        {
            get { return idCliente; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Seleccione un cliente válido.");

                idCliente = value;
            }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set
            {
                if (value == DateTime.MinValue)
                    throw new ArgumentException("Ingrese una fecha válida.");

                if (value.Date > DateTime.Today)
                    throw new ArgumentException("La fecha de venta no puede ser futura.");

                fecha = value.Date;
            }
        }

        public decimal Total
        {
            get { return total; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El total no puede ser negativo.");

                total = value;
            }
        }

        public Venta(int idVenta, int idCliente, DateTime fecha, decimal total)
        {
            IdVenta = idVenta;
            IdCliente = idCliente;
            Fecha = fecha;
            Total = total;
        }
    }
}