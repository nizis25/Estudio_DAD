﻿
namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    partial class Form15
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbModalidade = new System.Windows.Forms.ComboBox();
            this.cbbTurma = new System.Windows.Forms.ComboBox();
            this.cbbHora = new System.Windows.Forms.ComboBox();
            this.cbbCPF = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.cbbCPF);
            this.groupBox1.Controls.Add(this.cbbHora);
            this.groupBox1.Controls.Add(this.cbbTurma);
            this.groupBox1.Controls.Add(this.cbbModalidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar/Consultar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Aluno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Turma:";
            // 
            // cbbModalidade
            // 
            this.cbbModalidade.FormattingEnabled = true;
            this.cbbModalidade.Location = new System.Drawing.Point(99, 27);
            this.cbbModalidade.Name = "cbbModalidade";
            this.cbbModalidade.Size = new System.Drawing.Size(121, 21);
            this.cbbModalidade.TabIndex = 5;
            // 
            // cbbTurma
            // 
            this.cbbTurma.FormattingEnabled = true;
            this.cbbTurma.Location = new System.Drawing.Point(99, 59);
            this.cbbTurma.Name = "cbbTurma";
            this.cbbTurma.Size = new System.Drawing.Size(121, 21);
            this.cbbTurma.TabIndex = 6;
            // 
            // cbbHora
            // 
            this.cbbHora.FormattingEnabled = true;
            this.cbbHora.Location = new System.Drawing.Point(99, 92);
            this.cbbHora.Name = "cbbHora";
            this.cbbHora.Size = new System.Drawing.Size(121, 21);
            this.cbbHora.TabIndex = 7;
            // 
            // cbbCPF
            // 
            this.cbbCPF.FormattingEnabled = true;
            this.cbbCPF.Location = new System.Drawing.Point(99, 124);
            this.cbbCPF.Name = "cbbCPF";
            this.cbbCPF.Size = new System.Drawing.Size(121, 21);
            this.cbbCPF.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(99, 157);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 9;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 244);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form15";
            this.Text = "Buscar/Consultar Aluno na Turma";
            this.Load += new System.EventHandler(this.Form15_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbbCPF;
        private System.Windows.Forms.ComboBox cbbHora;
        private System.Windows.Forms.ComboBox cbbTurma;
        private System.Windows.Forms.ComboBox cbbModalidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}