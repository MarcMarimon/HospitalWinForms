namespace HospitalWinForms
{
    partial class AsignarPacienteAMedicoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.cbPacientes = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(18, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(426, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Asignar Paciente A Medico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Médico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente:";
            // 
            // cbMedicos
            // 
            this.cbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(111, 70);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(200, 28);
            this.cbMedicos.TabIndex = 2;
            // 
            // cbPacientes
            // 
            this.cbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacientes.FormattingEnabled = true;
            this.cbPacientes.Location = new System.Drawing.Point(111, 110);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(200, 28);
            this.cbPacientes.TabIndex = 3;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.Location = new System.Drawing.Point(149, 157);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(100, 30);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // AsignarPacienteAMedicoForm
            // 
            this.ClientSize = new System.Drawing.Size(745, 374);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cbPacientes);
            this.Controls.Add(this.cbMedicos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AsignarPacienteAMedicoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.Button btnAsignar;
    }
}