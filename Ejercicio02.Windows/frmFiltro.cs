namespace Ejercicio02.Windows
{
    public partial class frmFiltro : Form
    {
        private int superficieFiltro;
        public frmFiltro()
        {
            InitializeComponent();
        }

        internal int GetSuperficie()
        {
            return superficieFiltro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            superficieFiltro=(int)nudSuperficie.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
