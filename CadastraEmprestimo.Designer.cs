namespace Projeto_Biblioteca_Nassau
{
    partial class CadastraEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastraEmprestimo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.txtIDLeitor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDLivro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetirada = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.lblLeitor = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Livro:";
            // 
            // txtLeitor
            // 
            this.txtLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeitor.Location = new System.Drawing.Point(16, 42);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.Size = new System.Drawing.Size(357, 24);
            this.txtLeitor.TabIndex = 2;
            this.txtLeitor.TextChanged += new System.EventHandler(this.TxtLeitor_TextChanged);
            // 
            // txtLivro
            // 
            this.txtLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLivro.Location = new System.Drawing.Point(16, 142);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(357, 24);
            this.txtLivro.TabIndex = 3;
            this.txtLivro.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(16, 232);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(494, 150);
            this.data.TabIndex = 4;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cadastraCampos);
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellContentClick);
            // 
            // txtIDLeitor
            // 
            this.txtIDLeitor.Enabled = false;
            this.txtIDLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLeitor.Location = new System.Drawing.Point(389, 42);
            this.txtIDLeitor.Name = "txtIDLeitor";
            this.txtIDLeitor.Size = new System.Drawing.Size(121, 24);
            this.txtIDLeitor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID:";
            // 
            // txtIDLivro
            // 
            this.txtIDLivro.Enabled = false;
            this.txtIDLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLivro.Location = new System.Drawing.Point(389, 142);
            this.txtIDLivro.Name = "txtIDLivro";
            this.txtIDLivro.Size = new System.Drawing.Size(121, 24);
            this.txtIDLivro.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Retirada:";
            // 
            // txtRetirada
            // 
            this.txtRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetirada.Location = new System.Drawing.Point(530, 237);
            this.txtRetirada.Mask = "00/00/0000";
            this.txtRetirada.Name = "txtRetirada";
            this.txtRetirada.Size = new System.Drawing.Size(135, 24);
            this.txtRetirada.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Devolução:";
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevolucao.Location = new System.Drawing.Point(530, 298);
            this.txtDevolucao.Mask = "00/00/0000";
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.Size = new System.Drawing.Size(135, 24);
            this.txtDevolucao.TabIndex = 12;
            this.txtDevolucao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtDevolucao_MaskInputRejected);
            // 
            // lblLeitor
            // 
            this.lblLeitor.AutoSize = true;
            this.lblLeitor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeitor.Location = new System.Drawing.Point(18, 79);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Padding = new System.Windows.Forms.Padding(0, 0, 355, 20);
            this.lblLeitor.Size = new System.Drawing.Size(355, 38);
            this.lblLeitor.TabIndex = 13;
            this.lblLeitor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLeitor.Click += new System.EventHandler(this.Label7_Click);
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivro.Location = new System.Drawing.Point(18, 179);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Padding = new System.Windows.Forms.Padding(0, 0, 355, 20);
            this.lblLivro.Size = new System.Drawing.Size(355, 38);
            this.lblLivro.TabIndex = 14;
            this.lblLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(16, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cadastrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CadastraEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.lblLeitor);
            this.Controls.Add(this.txtDevolucao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRetirada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDLivro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDLeitor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txtLivro);
            this.Controls.Add(this.txtLeitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastraEmprestimo";
            this.Text = "Cadastrar Emprestimo";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox txtIDLeitor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtRetirada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDevolucao;
        private System.Windows.Forms.Label lblLeitor;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Button button1;
    }
}