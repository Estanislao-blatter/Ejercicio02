using Ejercicio02.Datos;
using Ejercicio02.Entidades;

namespace Ejercicio02.Windows
{

    public partial class frmListaRectangulos : Form
    {
        private RepositorioDeRectangulo repo;
        private List<Rectangulo>? lista;
        private int cantidadRegritros;

        public frmListaRectangulos()
        {
            InitializeComponent();
            repo = new RepositorioDeRectangulo();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            repo.GuardarDatos();
            Application.Exit();
        }

        private void frmListaRectangulos_Load(object sender, EventArgs e)
        {
            cantidadRegritros = repo.GetCantidad();
            if (cantidadRegritros > 0)
            {
                lista = repo.GetLista();
                MostrarDatosEnGrilla();
                MostrarDatosEnTotales();
            }

        }

        private void MostrarDatosEnTotales()
        {
            txtCantidadRegistros.Text = cantidadRegritros.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var rectangulo in lista!)
            {
                DataGridViewRow r = ConstruirFila();
                SeterarFila(r, rectangulo);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SeterarFila(DataGridViewRow r, Rectangulo rectangulo)
        {
            r.Cells[ColLadoMayor.Index].Value = rectangulo.LadoMayor;
            r.Cells[colLadoMenor.Index].Value = rectangulo.LadoMenor;
            r.Cells[ColPerimetro.Index].Value = rectangulo.GetPerimetro();
            r.Cells[colSuperficie.Index].Value = rectangulo.GetSuperficie();
            r.Tag = rectangulo;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmRectanguloAE() { Text = "Agregar Rectángulo" };
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            try
            {
                Rectangulo? rNuevo = frm.GetRectangulo();
                if (rNuevo is null) { return; }
                if (!repo.Existe(rNuevo))
                {
                    repo.GetAgregar(rNuevo);
                    var r = ConstruirFila();
                    SeterarFila(r, rNuevo);
                    AgregarFila(r);
                    cantidadRegritros = repo.GetCantidad();
                    MostrarDatosEnTotales();
                    MessageBox.Show("Registro Agregado!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro Duplicado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var fila = dgvDatos.SelectedRows[0];
            Rectangulo r = (Rectangulo)fila.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea Borrar el Rectangúlo de Lados {r.LadoMayor} y {r.LadoMenor}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            repo.Borrar(r);
            QuitarFila(fila);
            MessageBox.Show("Registro Borrado!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void QuitarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Remove(r);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var fila = dgvDatos.SelectedRows[0];
            Rectangulo r = (Rectangulo)fila.Tag!;
            var frm = new frmRectanguloAE() { Text = "Editar Rectángulo" };
            frm.SetRectangulo(r);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            try
            {
                r = frm.GetRectangulo();
                if (r == null) return;
                SeterarFila(fila, r);
                MessageBox.Show("Registro Editado!!");
            }
            catch
            {
                throw;
            }
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            frmFiltro frm = new frmFiltro() { Text = "Agregar Filtro" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            int superficieFiltro = frm.GetSuperficie();
            lista = repo.Filtrar(superficieFiltro);
            MostrarDatosEnGrilla();
            cantidadRegritros = repo.GetCantidad(superficieFiltro);
            MostrarDatosEnTotales();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            lista = repo.GetLista();
            cantidadRegritros = repo.GetCantidad();
            MostrarDatosEnGrilla();
            MostrarDatosEnTotales();
        }
    }
}
