
namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    partial class Form13
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.idTurmaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadeDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaSemanaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaTurmaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(60, 19);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // dgvTurma
            // 
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTurmaDgv,
            this.modalidadeDgv,
            this.diaSemanaDgv,
            this.horaTurmaDgv});
            this.dgvTurma.Location = new System.Drawing.Point(12, 45);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.Size = new System.Drawing.Size(443, 264);
            this.dgvTurma.TabIndex = 2;
            this.dgvTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurma_CellClick);
            // 
            // idTurmaDgv
            // 
            this.idTurmaDgv.HeaderText = "ID";
            this.idTurmaDgv.Name = "idTurmaDgv";
            // 
            // modalidadeDgv
            // 
            this.modalidadeDgv.HeaderText = "Modalidade";
            this.modalidadeDgv.Name = "modalidadeDgv";
            // 
            // diaSemanaDgv
            // 
            this.diaSemanaDgv.HeaderText = "Dia da Semana";
            this.diaSemanaDgv.Name = "diaSemanaDgv";
            // 
            // horaTurmaDgv
            // 
            this.horaTurmaDgv.HeaderText = "Horário";
            this.horaTurmaDgv.Name = "horaTurmaDgv";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 331);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 377);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvTurma);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label1);
            this.Name = "Form13";
            this.Text = "Cadastrar/Excluir Aluno na Turma";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurmaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidadeDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaSemanaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaTurmaDgv;
        private System.Windows.Forms.Button btnCadastrar;
    }
}