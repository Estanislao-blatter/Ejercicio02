namespace Ejercicio02.Windows
{
    partial class frmFiltro
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
            label1 = new Label();
            nudSuperficie = new NumericUpDown();
            btnOK = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudSuperficie).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Superficie para filtrar:";
            // 
            // nudSuperficie
            // 
            nudSuperficie.Location = new Point(178, 42);
            nudSuperficie.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudSuperficie.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSuperficie.Name = "nudSuperficie";
            nudSuperficie.Size = new Size(87, 23);
            nudSuperficie.TabIndex = 1;
            nudSuperficie.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnOK
            // 
            btnOK.Location = new Point(12, 115);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(78, 59);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(178, 115);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 59);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 202);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(nudSuperficie);
            Controls.Add(label1);
            MaximumSize = new Size(293, 241);
            MinimumSize = new Size(293, 241);
            Name = "frmFiltro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFiltro";
            ((System.ComponentModel.ISupportInitialize)nudSuperficie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudSuperficie;
        private Button btnOK;
        private Button btnCancelar;
    }
}