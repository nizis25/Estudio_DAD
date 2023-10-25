
namespace DAD_AULA01_SEGUNDO_SEMESTRE_0208
{
    partial class Form10
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
            this.cbbModalidade = new System.Windows.Forms.ComboBox();
            this.cbbHora = new System.Windows.Forms.ComboBox();
            this.cbbDia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbModalidade
            // 
            this.cbbModalidade.FormattingEnabled = true;
            this.cbbModalidade.Location = new System.Drawing.Point(136, 41);
            this.cbbModalidade.Margin = new System.Windows.Forms.Padding(4);
            this.cbbModalidade.Name = "cbbModalidade";
            this.cbbModalidade.Size = new System.Drawing.Size(205, 24);
            this.cbbModalidade.TabIndex = 0;
            this.cbbModalidade.SelectedIndexChanged += new System.EventHandler(this.cbbModalidade_SelectedIndexChanged);
            // 
            // cbbHora
            // 
            this.cbbHora.FormattingEnabled = true;
            this.cbbHora.Location = new System.Drawing.Point(136, 125);
            this.cbbHora.Margin = new System.Windows.Forms.Padding(4);
            this.cbbHora.Name = "cbbHora";
            this.cbbHora.Size = new System.Drawing.Size(205, 24);
            this.cbbHora.TabIndex = 1;
            this.cbbHora.SelectedIndexChanged += new System.EventHandler(this.cbbHora_SelectedIndexChanged);
            // 
            // cbbDia
            // 
            this.cbbDia.FormattingEnabled = true;
            this.cbbDia.Location = new System.Drawing.Point(136, 81);
            this.cbbDia.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDia.Name = "cbbDia";
            this.cbbDia.Size = new System.Drawing.Size(205, 24);
            this.cbbDia.TabIndex = 2;
            this.cbbDia.SelectedIndexChanged += new System.EventHandler(this.cbbDia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modalidade:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dia da semana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbModalidade);
            this.groupBox1.Controls.Add(this.cbbHora);
            this.groupBox1.Controls.Add(this.cbbDia);
            this.groupBox1.Location = new System.Drawing.Point(39, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(376, 238);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excluir Turma ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 295);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form10";
            this.Text = "Excluir Turma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbModalidade;
        private System.Windows.Forms.ComboBox cbbHora;
        private System.Windows.Forms.ComboBox cbbDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}