using Ejercicio02.Entidades;

namespace Ejercicio02.Windows
{
    public partial class frmRectanguloAE : Form
    {
        private Rectangulo? rectangulo;
        public frmRectanguloAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (rectangulo is not null)
            { 
               txtLadoMayor.Text = rectangulo.LadoMayor.ToString();
               txtLadoMenor.Text=rectangulo.LadoMenor.ToString();

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if(rectangulo is null)
                {
                  rectangulo = new Rectangulo();
                }
                
                rectangulo.LadoMayor = int.Parse(txtLadoMayor.Text);
                rectangulo.LadoMenor = int.Parse(txtLadoMenor.Text);
                DialogResult = DialogResult.OK; 
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if(!int.TryParse(txtLadoMayor.Text,out int mayorLado ) || (mayorLado<=0))
            {
                errorProvider1.SetError(txtLadoMayor, "Lado Mayor no valido");
            }
            if (!int.TryParse(txtLadoMenor.Text, out int menorLado ) || (menorLado<=0) ||(menorLado>=mayorLado))
            {
                errorProvider1.SetError(txtLadoMenor, "Lado Menor no valido o mal ingresado");
            }
            return valido;
        }

        public Rectangulo? GetRectangulo()
        {
            return rectangulo;
        }

        public void SetRectangulo(Rectangulo r)
        {
            rectangulo=r;
        }
    }
}
