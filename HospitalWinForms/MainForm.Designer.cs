namespace HospitalWinForms
{
    partial class MainForm
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
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.btnCrearMedico = new System.Windows.Forms.Button();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.btnCrearPersonalAuxiliar = new System.Windows.Forms.Button();
            this.btnAsignarPacienteAMedico = new System.Windows.Forms.Button();
            this.btnDesasignarPacienteAMedico = new System.Windows.Forms.Button();
            this.btnVerPacientesDeMedico = new System.Windows.Forms.Button();
            this.btnVerMedicosDePaciente = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.panelIzquierdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(284, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Hospital Manager";
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIzquierdo.Controls.Add(this.btnCrearMedico);
            this.panelIzquierdo.Controls.Add(this.btnCrearPaciente);
            this.panelIzquierdo.Controls.Add(this.btnCrearPersonalAuxiliar);
            this.panelIzquierdo.Controls.Add(this.btnAsignarPacienteAMedico);
            this.panelIzquierdo.Controls.Add(this.btnDesasignarPacienteAMedico);
            this.panelIzquierdo.Controls.Add(this.btnVerPacientesDeMedico);
            this.panelIzquierdo.Controls.Add(this.btnVerMedicosDePaciente);
            this.panelIzquierdo.Controls.Add(this.btnListar);
            this.panelIzquierdo.Controls.Add(this.btnEliminar);
            this.panelIzquierdo.Location = new System.Drawing.Point(13, 80);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(250, 569);
            this.panelIzquierdo.TabIndex = 1;
            // 
            // btnCrearMedico
            // 
            this.btnCrearMedico.Location = new System.Drawing.Point(15, 15);
            this.btnCrearMedico.Name = "btnCrearMedico";
            this.btnCrearMedico.Size = new System.Drawing.Size(220, 50);
            this.btnCrearMedico.TabIndex = 0;
            this.btnCrearMedico.Text = "Crear Médico";
            this.btnCrearMedico.UseVisualStyleBackColor = true;
            this.btnCrearMedico.Click += new System.EventHandler(this.btnCrearMedico_Click);
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Location = new System.Drawing.Point(15, 75);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(220, 50);
            this.btnCrearPaciente.TabIndex = 1;
            this.btnCrearPaciente.Text = "Crear Paciente";
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // btnCrearPersonalAuxiliar
            // 
            this.btnCrearPersonalAuxiliar.Location = new System.Drawing.Point(15, 135);
            this.btnCrearPersonalAuxiliar.Name = "btnCrearPersonalAuxiliar";
            this.btnCrearPersonalAuxiliar.Size = new System.Drawing.Size(220, 50);
            this.btnCrearPersonalAuxiliar.TabIndex = 2;
            this.btnCrearPersonalAuxiliar.Text = "Crear Personal Auxiliar";
            this.btnCrearPersonalAuxiliar.UseVisualStyleBackColor = true;
            this.btnCrearPersonalAuxiliar.Click += new System.EventHandler(this.btnCrearPersonalAuxiliar_Click);
            // 
            // btnAsignarPacienteAMedico
            // 
            this.btnAsignarPacienteAMedico.Location = new System.Drawing.Point(15, 195);
            this.btnAsignarPacienteAMedico.Name = "btnAsignarPacienteAMedico";
            this.btnAsignarPacienteAMedico.Size = new System.Drawing.Size(220, 50);
            this.btnAsignarPacienteAMedico.TabIndex = 3;
            this.btnAsignarPacienteAMedico.Text = "Asignar Paciente a Médico";
            this.btnAsignarPacienteAMedico.UseVisualStyleBackColor = true;
            this.btnAsignarPacienteAMedico.Click += new System.EventHandler(this.btnAsignarPacienteAMedico_Click);
            // 
            // btnDesasignarPacienteAMedico
            // 
            this.btnDesasignarPacienteAMedico.Location = new System.Drawing.Point(15, 255);
            this.btnDesasignarPacienteAMedico.Name = "btnDesasignarPacienteAMedico";
            this.btnDesasignarPacienteAMedico.Size = new System.Drawing.Size(220, 50);
            this.btnDesasignarPacienteAMedico.TabIndex = 4;
            this.btnDesasignarPacienteAMedico.Text = "Desasignar Paciente de Médico";
            this.btnDesasignarPacienteAMedico.UseVisualStyleBackColor = true;
            this.btnDesasignarPacienteAMedico.Click += new System.EventHandler(this.btnDesasignarPacienteAMedico_Click);
            // 
            // btnVerPacientesDeMedico
            // 
            this.btnVerPacientesDeMedico.Location = new System.Drawing.Point(15, 315);
            this.btnVerPacientesDeMedico.Name = "btnVerPacientesDeMedico";
            this.btnVerPacientesDeMedico.Size = new System.Drawing.Size(220, 50);
            this.btnVerPacientesDeMedico.TabIndex = 5;
            this.btnVerPacientesDeMedico.Text = "Ver Pacientes de Médico";
            this.btnVerPacientesDeMedico.UseVisualStyleBackColor = true;
            this.btnVerPacientesDeMedico.Click += new System.EventHandler(this.btnVerPacientesDeMedico_Click);
            // 
            // btnVerMedicosDePaciente
            // 
            this.btnVerMedicosDePaciente.Location = new System.Drawing.Point(15, 375);
            this.btnVerMedicosDePaciente.Name = "btnVerMedicosDePaciente";
            this.btnVerMedicosDePaciente.Size = new System.Drawing.Size(220, 50);
            this.btnVerMedicosDePaciente.TabIndex = 6;
            this.btnVerMedicosDePaciente.Text = "Ver Médicos de Paciente";
            this.btnVerMedicosDePaciente.UseVisualStyleBackColor = true;
            this.btnVerMedicosDePaciente.Click += new System.EventHandler(this.btnVerMedicosDePaciente_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(15, 435);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(220, 50);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(15, 495);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(220, 50);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panelDerecho
            // 
            this.panelDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDerecho.Location = new System.Drawing.Point(270, 80);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(700, 569);
            this.panelDerecho.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MainForm";
            this.Text = "Gestión Hospitalaria";
            this.panelIzquierdo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Button btnCrearMedico;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.Button btnCrearPersonalAuxiliar;
        private System.Windows.Forms.Button btnAsignarPacienteAMedico;
        private System.Windows.Forms.Button btnDesasignarPacienteAMedico;
        private System.Windows.Forms.Button btnVerPacientesDeMedico;
        private System.Windows.Forms.Button btnVerMedicosDePaciente;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panelDerecho;
    }
}
