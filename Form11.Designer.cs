
namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    partial class Form11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbDiaSemana = new System.Windows.Forms.ComboBox();
            this.cbbHora = new System.Windows.Forms.ComboBox();
            this.txtMaxAlunos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbModalidade = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbbDiaSemana);
            this.groupBox1.Controls.Add(this.cbbHora);
            this.groupBox1.Controls.Add(this.txtMaxAlunos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProfessor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbModalidade);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(339, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Turma";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbDiaSemana
            // 
            this.cbbDiaSemana.FormattingEnabled = true;
            this.cbbDiaSemana.Location = new System.Drawing.Point(135, 64);
            this.cbbDiaSemana.Name = "cbbDiaSemana";
            this.cbbDiaSemana.Size = new System.Drawing.Size(160, 24);
            this.cbbDiaSemana.TabIndex = 12;
            this.cbbDiaSemana.SelectedIndexChanged += new System.EventHandler(this.cbbDiaSemana_SelectedIndexChanged);
            // 
            // cbbHora
            // 
            this.cbbHora.FormattingEnabled = true;
            this.cbbHora.Location = new System.Drawing.Point(136, 94);
            this.cbbHora.Name = "cbbHora";
            this.cbbHora.Size = new System.Drawing.Size(161, 24);
            this.cbbHora.TabIndex = 11;
            // 
            // txtMaxAlunos
            // 
            this.txtMaxAlunos.Location = new System.Drawing.Point(189, 182);
            this.txtMaxAlunos.Name = "txtMaxAlunos";
            this.txtMaxAlunos.Size = new System.Drawing.Size(107, 22);
            this.txtMaxAlunos.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Qtde. MÁXIMA de Alunos:";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(136, 125);
            this.txtProfessor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(160, 22);
            this.txtProfessor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Professor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dia da Semana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modalidade:";
            // 
            // cbbModalidade
            // 
            this.cbbModalidade.FormattingEnabled = true;
            this.cbbModalidade.Location = new System.Drawing.Point(136, 32);
            this.cbbModalidade.Margin = new System.Windows.Forms.Padding(4);
            this.cbbModalidade.Name = "cbbModalidade";
            this.cbbModalidade.Size = new System.Drawing.Size(160, 24);
            this.cbbModalidade.TabIndex = 0;
            this.cbbModalidade.SelectedIndexChanged += new System.EventHandler(this.cbbModalidade_SelectedIndexChanged);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 309);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form11";
            this.Text = "Consultar Turma";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbModalidade;
        private System.Windows.Forms.TextBox txtMaxAlunos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbDiaSemana;
        private System.Windows.Forms.ComboBox cbbHora;
        private System.Windows.Forms.Button button1;
    }
}