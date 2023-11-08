
namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    partial class Form8
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
            this.btnReativar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtQtdeAulasAtu = new System.Windows.Forms.TextBox();
            this.txtQtdeAlunosAtu = new System.Windows.Forms.TextBox();
            this.txtPrecoAtu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNova = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNova);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnReativar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.txtQtdeAulasAtu);
            this.groupBox1.Controls.Add(this.txtQtdeAlunosAtu);
            this.groupBox1.Controls.Add(this.txtPrecoAtu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidades";
            // 
            // btnReativar
            // 
            this.btnReativar.Location = new System.Drawing.Point(105, 194);
            this.btnReativar.Name = "btnReativar";
            this.btnReativar.Size = new System.Drawing.Size(353, 23);
            this.btnReativar.TabIndex = 11;
            this.btnReativar.Text = "REATIVAR";
            this.btnReativar.UseVisualStyleBackColor = true;
            this.btnReativar.Click += new System.EventHandler(this.btnReativar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ""});
            this.comboBox1.Location = new System.Drawing.Point(105, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(353, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(105, 165);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(353, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtQtdeAulasAtu
            // 
            this.txtQtdeAulasAtu.Location = new System.Drawing.Point(105, 113);
            this.txtQtdeAulasAtu.Name = "txtQtdeAulasAtu";
            this.txtQtdeAulasAtu.Size = new System.Drawing.Size(353, 20);
            this.txtQtdeAulasAtu.TabIndex = 7;
            // 
            // txtQtdeAlunosAtu
            // 
            this.txtQtdeAlunosAtu.Location = new System.Drawing.Point(105, 86);
            this.txtQtdeAlunosAtu.Name = "txtQtdeAlunosAtu";
            this.txtQtdeAlunosAtu.Size = new System.Drawing.Size(353, 20);
            this.txtQtdeAlunosAtu.TabIndex = 6;
            // 
            // txtPrecoAtu
            // 
            this.txtPrecoAtu.Location = new System.Drawing.Point(105, 59);
            this.txtPrecoAtu.Name = "txtPrecoAtu";
            this.txtPrecoAtu.Size = new System.Drawing.Size(353, 20);
            this.txtPrecoAtu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qtde de Aulas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qtde de Alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nova Descrição:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNova
            // 
            this.txtNova.Location = new System.Drawing.Point(105, 139);
            this.txtNova.Name = "txtNova";
            this.txtNova.Size = new System.Drawing.Size(353, 20);
            this.txtNova.TabIndex = 13;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 372);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.Text = "Buscar/Atualizar Modalidades";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtQtdeAulasAtu;
        private System.Windows.Forms.TextBox txtQtdeAlunosAtu;
        private System.Windows.Forms.TextBox txtPrecoAtu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnReativar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNova;
    }
}