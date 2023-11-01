
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CPFAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Modalidade,
            this.diaSemana,
            this.hora});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPFAluno,
            this.NomeAluno});
            this.dataGridView2.Location = new System.Drawing.Point(555, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 264);
            this.dataGridView2.TabIndex = 1;
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
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form14";
            this.Text = "Consultar Aluno na Turma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAluno;
    }
}