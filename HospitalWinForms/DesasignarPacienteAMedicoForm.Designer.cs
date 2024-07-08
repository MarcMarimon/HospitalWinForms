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
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(30, 30);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(200, 21);
            this.cmbMedicos.TabIndex = 0;
            this.cmbMedicos.SelectedIndexChanged += new System.EventHandler(this.cmbMedicos_SelectedIndexChanged);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.Location = new System.Drawing.Point(30, 70);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(200, 95);
            this.lstPacientes.TabIndex = 1;
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Location = new System.Drawing.Point(30, 180);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(200, 30);
            this.btnDesasignar.TabIndex = 2;
            this.btnDesasignar.Text = "Desasignar";
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // DesasignarPacienteAMedicoForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 240);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.cmbMedicos);
            this.Name = "DesasignarPacienteAMedicoForm";
            this.Text = "Desasignar Paciente de Médico";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cmbMedicos;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Button btnDesasignar;
    }
}
