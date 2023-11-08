
namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    partial class Form14
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
            this.dgvAlunoTurma = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.CPFAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunoTurma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunoTurma
            // 
            this.dgvAlunoTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunoTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Modalidade,
            this.diaSemana,
            this.hora});
            this.dgvAlunoTurma.Location = new System.Drawing.Point(12, 12);
            this.dgvAlunoTurma.Name = "dgvAlunoTurma";
            this.dgvAlunoTurma.Size = new System.Drawing.Size(443, 264);
            this.dgvAlunoTurma.TabIndex = 0;
            this.dgvAlunoTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Modalidade
            // 
            this.Modalidade.HeaderText = "Modalidade";
            this.Modalidade.Name = "Modalidade";
            // 
            // diaSemana
            // 
            this.diaSemana.HeaderText = "Dia da Semana";
            this.diaSemana.Name = "diaSemana";
            // 
            // hora
            // 
            this.hora.HeaderText = "Horário";
            this.hora.Name = "hora";
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPFAluno,
            this.NomeAluno});
            this.dgvAluno.Location = new System.Drawing.Point(555, 12);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(243, 264);
            this.dgvAluno.TabIndex = 1;
            // 
            // CPFAluno
            // 
            this.CPFAluno.HeaderText = "CPFAluno";
            this.CPFAluno.Name = "CPFAluno";
            // 
            // NomeAluno
            // 
            this.NomeAluno.HeaderText = "Nome do Aluno";
            this.NomeAluno.Name = "NomeAluno";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 293);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.dgvAlunoTurma);
            this.Name = "Form14";
            this.Text = "Consultar Aluno na Turma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunoTurma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunoTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAluno;
    }
}