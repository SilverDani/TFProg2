using System;

namespace GestorDeVentas.Clases
{
    public class Proveedor
    {
        private string razonSocial, cuit;

        public string RazonSocial
        {
            get { return razonSocial; }
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ERROR: ingrese una Razon social.");

                foreach (char caracter in value)
                    if (!char.IsLetter(caracter) && !char.IsWhiteSpace(caracter))
                        throw new ArgumentException("ERROR: Valores introducidos no validos. solo se permite Letras. Ingrese una Razon social valida.");

                razonSocial = value;
            }
        }
        public string CUIT
        {
            get { return cuit; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ERROR: ingrese un CUIT.");

                foreach (char caracter in value)
                    if (!char.IsLetter(caracter) && !char.IsWhiteSpace(caracter))
                        throw new ArgumentException("ERROR: Valores introducidos no validos. solo se permite Letras. Ingrese un CUIT valido.");

                cuit = value;
            }
        }


        public Proveedor(string razonSocial, string cuit)
        {
            RazonSocial = razonSocial;
            CUIT = cuit;
        }//Constructor
    }//Class
}//Namespace