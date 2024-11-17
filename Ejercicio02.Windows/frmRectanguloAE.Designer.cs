namespace Ejercicio02.Windows
{
    partial class frmRectanguloAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtLadoMayor = new TextBox();
            txtLadoMenor = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado Mayor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 0;
            label2.Text = "Lado Menor";
            // 
            // txtLadoMayor
            // 
            txtLadoMayor.Location = new Point(85, 27);
            txtLadoMayor.Name = "txtLadoMayor";
            txtLadoMayor.Size = new Size(100, 23);
            txtLadoMayor.TabIndex = 0;
            // 
            // txtLadoMenor
            // 
            txtLadoMenor.Location = new Point(85, 65);
            txtLadoMenor.Name = "txtLadoMenor";
            txtLadoMenor.Size = new Size(100, 23);
            txtLadoMenor.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 110);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(95, 63);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "OK";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(164, 110);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 63);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRectanguloAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 190);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtLadoMenor);
            Controls.Add(txtLadoMayor);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRectanguloAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRectanguloAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLadoMayor;
        private TextBox txtLadoMenor;
        private Button btnAceptar;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}