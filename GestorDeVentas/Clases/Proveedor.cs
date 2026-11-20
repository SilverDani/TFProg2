namespace GestorDeVentas.Clases
{
    using System;
    using System.Linq;

    public class Proveedor
    {
        private int idProveedor;
        private string razonSocial, cuit;

        public int IdProveedor
        {
            get { return idProveedor; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("ID inválido.");

                idProveedor = value;
            }//set
        }//idproveedor

        public string RazonSocial
        {
            get { return razonSocial; }
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ERROR: ingrese una Razon social.");

                razonSocial = value.Trim();
            }//set
        }//RazonSocial
        public string CUIT
        {
            get { return cuit; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ingrese un CUIT.");

                string cuitLimpio = value.Replace("-", "").Trim();

                if (cuitLimpio.Length != 11 ||
                    !cuitLimpio.All(char.IsDigit))
                    throw new ArgumentException("El CUIT debe contener 11 dígitos.");

                cuit = cuitLimpio;
            }//set
        }//CUIT


        public Proveedor(int idProveedor, string razonSocial, string cuit)
        {
            IdProveedor = idProveedor;
            RazonSocial = razonSocial;
            CUIT = cuit;
        }//Constructor
    }//Class
}//Namespace