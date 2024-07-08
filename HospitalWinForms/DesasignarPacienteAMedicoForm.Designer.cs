namespace HospitalWinForms
{
    partial class DesasignarPacienteAMedicoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(26, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(481, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Desasignar Paciente A Medico";
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(33, 77);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(200, 28);
            this.cmbMedicos.TabIndex = 0;
            this.cmbMedicos.SelectedIndexChanged += new System.EventHandler(this.cmbMedicos_SelectedIndexChanged);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 20;
            this.lstPacientes.Location = new System.Drawing.Point(33, 117);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(200, 84);
            this.lstPacientes.TabIndex = 1;
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesasignar.Location = new System.Drawing.Point(33, 227);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(200, 30);
            this.btnDesasignar.TabIndex = 2;
            this.btnDesasignar.Text = "Desasignar";
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // DesasignarPacienteAMedicoForm
            // 
            this.ClientSize = new System.Drawing.Size(676, 344);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.cmbMedicos);
            this.Name = "DesasignarPacienteAMedicoForm";
            this.Text = "Desasignar Paciente de Médico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbMedicos;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Button btnDesasignar;
    }
}
