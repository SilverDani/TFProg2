using System;
using System.Linq;

namespace GestorDeVentas.Clases
{
    public class Cliente
    {
        private int idCliente;
        private string nombre, apellido, cuil;
        private DateTime fechaNacimiento;

        public int IdCliente
        {
            get { return idCliente; }

            set
            {
                if (value <= 0)
                    throw new ArgumentException("ID invalido.");

                idCliente = value;
            }//set
        }//idcliente

        public string Nombre
        {
            get { return nombre; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ERROR: ingrese un Nombre.");

                nombre = value.Trim();
            }//set
        }//nombre

        public string Apellido
        {
            get { return apellido; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ERROR: ingrese un Apellido.");

                apellido = value.Trim();
            }//set
        }//apellido

        public string CUIL
        {
            get { return cuil; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ERROR: ingrese un CUIL.");

                string cuilLimpio = value.Replace("-", "").Trim();

                if (cuilLimpio.Length != 11 ||
                    !cuilLimpio.All(char.IsDigit))
                    throw new ArgumentException("El CUIL debe contener 11 dígitos.");

                cuil = cuilLimpio; ;
            }//set
        }//CUIL

        public DateTime FechaNacimiento

        {
            get { return fechaNacimiento; }

            set
            {
                if (value == DateTime.MinValue)
                    throw new ArgumentException("Ingrese una fecha de nacimiento.");

                if (value.Date > DateTime.Today)
                    throw new ArgumentException("La fecha de nacimiento no puede ser futura.");

                if (value.Date > DateTime.Today.AddYears(-18) || value.Date < DateTime.Today.AddYears(-120))
                    throw new ArgumentException("La fecha de nacimiento no es válida.");


                fechaNacimiento = value;
            }//set
        }//FechaNaciemiento

        public Cliente(int idCliente, string nombre, string apellido, string cuil, DateTime fechaNacimiento)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
            CUIL = cuil;
            FechaNacimiento = fechaNacimiento;
        }

    }//Class
}//NamseSpace