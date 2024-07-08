namespace HospitalWinForms
{
    partial class ListarForm
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
            this.cbTipos = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(102, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Listar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // cbTipos
            // 
            this.cbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipos.FormattingEnabled = true;
            this.cbTipos.Location = new System.Drawing.Point(67, 78);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(200, 28);
            this.cbTipos.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Location = new System.Drawing.Point(107, 118);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 30);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 20;
            this.lbLista.Location = new System.Drawing.Point(27, 158);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(405, 284);
            this.lbLista.TabIndex = 3;
            // 
            // ListarForm
            // 
            this.ClientSize = new System.Drawing.Size(444, 500);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cbTipos);
            this.Controls.Add(this.label1);
            this.Name = "ListarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lbLista;
    }
}
