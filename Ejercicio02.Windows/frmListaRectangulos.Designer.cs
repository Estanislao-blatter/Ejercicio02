namespace Ejercicio02.Windows
{
    partial class frmListaRectangulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaRectangulos));
            tsBarraHerramientas = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbCerrar = new ToolStripButton();
            panelResultados = new Panel();
            txtCantidadRegistros = new TextBox();
            label1 = new Label();
            panelGrilla = new Panel();
            dgvDatos = new DataGridView();
            ColLadoMayor = new DataGridViewTextBoxColumn();
            colLadoMenor = new DataGridViewTextBoxColumn();
            ColPerimetro = new DataGridViewTextBoxColumn();
            colSuperficie = new DataGridViewTextBoxColumn();
            tsBarraHerramientas.SuspendLayout();
            panelResultados.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // tsBarraHerramientas
            // 
            tsBarraHerramientas.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbCerrar });
            tsBarraHerramientas.Location = new Point(0, 0);
            tsBarraHerramientas.Name = "tsBarraHerramientas";
            tsBarraHerramientas.Size = new Size(798, 38);
            tsBarraHerramientas.TabIndex = 0;
            tsBarraHerramientas.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 35);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(43, 35);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 35);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(41, 35);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 35);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // tsbCerrar
            // 
            tsbCerrar.Image = (Image)resources.GetObject("tsbCerrar.Image");
            tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbCerrar.ImageTransparentColor = Color.Magenta;
            tsbCerrar.Name = "tsbCerrar";
            tsbCerrar.Size = new Size(43, 35);
            tsbCerrar.Text = "Cerrar";
            tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbCerrar.Click += tsbCerrar_Click;
            // 
            // panelResultados
            // 
            panelResultados.Controls.Add(txtCantidadRegistros);
            panelResultados.Controls.Add(label1);
            panelResultados.Dock = DockStyle.Bottom;
            panelResultados.Location = new Point(0, 313);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(798, 100);
            panelResultados.TabIndex = 1;
            // 
            // txtCantidadRegistros
            // 
            txtCantidadRegistros.Location = new Point(127, 49);
            txtCantidadRegistros.Name = "txtCantidadRegistros";
            txtCantidadRegistros.ReadOnly = true;
            txtCantidadRegistros.Size = new Size(100, 23);
            txtCantidadRegistros.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad Registros:";
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvDatos);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 38);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(798, 275);
            panelGrilla.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColLadoMayor, colLadoMenor, ColPerimetro, colSuperficie });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(798, 275);
            dgvDatos.TabIndex = 0;
            // 
            // ColLadoMayor
            // 
            ColLadoMayor.HeaderText = "LadoMayor";
            ColLadoMayor.Name = "ColLadoMayor";
            ColLadoMayor.ReadOnly = true;
            // 
            // colLadoMenor
            // 
            colLadoMenor.HeaderText = "LadoMenor";
            colLadoMenor.Name = "colLadoMenor";
            colLadoMenor.ReadOnly = true;
            // 
            // ColPerimetro
            // 
            ColPerimetro.HeaderText = "Perimetro";
            ColPerimetro.Name = "ColPerimetro";
            ColPerimetro.ReadOnly = true;
            // 
            // colSuperficie
            // 
            colSuperficie.HeaderText = "Superficie";
            colSuperficie.Name = "colSuperficie";
            colSuperficie.ReadOnly = true;
            // 
            // frmListaRectangulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 413);
            Controls.Add(panelGrilla);
            Controls.Add(panelResultados);
            Controls.Add(tsBarraHerramientas);
            Name = "frmListaRectangulos";
            Text = "frmListaRectangulos";
            Load += frmListaRectangulos_Load;
            tsBarraHerramientas.ResumeLayout(false);
            tsBarraHerramientas.PerformLayout();
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsBarraHerramientas;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbCerrar;
        private Panel panelResultados;
        private TextBox txtCantidadRegistros;
        private Label label1;
        private Panel panelGrilla;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColLadoMayor;
        private DataGridViewTextBoxColumn colLadoMenor;
        private DataGridViewTextBoxColumn ColPerimetro;
        private DataGridViewTextBoxColumn colSuperficie;
    }
}