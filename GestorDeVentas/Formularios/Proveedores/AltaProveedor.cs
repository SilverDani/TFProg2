using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestorDeVentas.Formularios.Proveedores
{
    public partial class AltaProveedor : Form
    {
        public AltaProveedor()
        {
            InitializeComponent();
        }//Constructor

        private void txtRazonSocial_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
                MessageBox.Show("Por favor ingrese una Razon Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }//Class
}//Namespace