
namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    partial class Form9
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
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.txtNumMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mkdHora = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDSemana = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtModalidade);
            this.groupBox1.Controls.Add(this.txtNumMax);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mkdHora);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtDSemana);
            this.groupBox1.Controls.Add(this.txtProfessor);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtModalidade
            // 
            this.txtModalidade.Location = new System.Drawing.Point(111, 54);
            this.txtModalidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(215, 20);
            this.txtModalidade.TabIndex = 13;
            // 
            // txtNumMax
            // 
            this.txtNumMax.Enabled = false;
            this.txtNumMax.Location = new System.Drawing.Point(161, 127);
            this.txtNumMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumMax.Name = "txtNumMax";
            this.txtNumMax.Size = new System.Drawing.Size(76, 20);
            this.txtNumMax.TabIndex = 1;
            this.txtNumMax.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numero de Alunos:";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // mkdHora
            // 
            this.mkdHora.Location = new System.Drawing.Point(278, 124);
            this.mkdHora.Mask = "90:00";
            this.mkdHora.Name = "mkdHora";
            this.mkdHora.Size = new System.Drawing.Size(48, 20);
            this.mkdHora.TabIndex = 10;
            this.mkdHora.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modalidade});
            this.dataGridView1.Location = new System.Drawing.Point(344, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // modalidade
            // 
            this.modalidade.HeaderText = "Modalidade";
            this.modalidade.MinimumWidth = 6;
            this.modalidade.Name = "modalidade";
            this.modalidade.Width = 125;
            // 
            // txtDSemana
            // 
            this.txtDSemana.Location = new System.Drawing.Point(111, 100);
            this.txtDSemana.Name = "txtDSemana";
            this.txtDSemana.Size = new System.Drawing.Size(215, 20);
            this.txtDSemana.TabIndex = 7;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(111, 77);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(215, 20);
            this.txtProfessor.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " Dia da Semana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Modalidade:";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form9";
            this.Text = "Cadastro de Turma";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDSemana;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mkdHora;
        private System.Windows.Forms.TextBox txtNumMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidade;
        private System.Windows.Forms.TextBox txtModalidade;
    }
}