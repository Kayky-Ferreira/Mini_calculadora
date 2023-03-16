namespace Mini_calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.primeiro_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.segundo_valor = new System.Windows.Forms.TextBox();
            this.resultado_do_calculo = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.operacao = new System.Windows.Forms.TextBox();
            this.Aviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "+  -  /   x";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite na caixa abaixo o caracteres a operação que deseja";
            // 
            // primeiro_valor
            // 
            this.primeiro_valor.Location = new System.Drawing.Point(223, 114);
            this.primeiro_valor.Name = "primeiro_valor";
            this.primeiro_valor.Size = new System.Drawing.Size(100, 20);
            this.primeiro_valor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(160, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor 1";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(160, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor 2";
            // 
            // segundo_valor
            // 
            this.segundo_valor.Location = new System.Drawing.Point(223, 140);
            this.segundo_valor.Name = "segundo_valor";
            this.segundo_valor.Size = new System.Drawing.Size(100, 20);
            this.segundo_valor.TabIndex = 5;
            // 
            // resultado_do_calculo
            // 
            this.resultado_do_calculo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultado_do_calculo.AutoSize = true;
            this.resultado_do_calculo.BackColor = System.Drawing.Color.Transparent;
            this.resultado_do_calculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado_do_calculo.ForeColor = System.Drawing.Color.White;
            this.resultado_do_calculo.Location = new System.Drawing.Point(181, 203);
            this.resultado_do_calculo.Name = "resultado_do_calculo";
            this.resultado_do_calculo.Size = new System.Drawing.Size(132, 16);
            this.resultado_do_calculo.TabIndex = 7;
            this.resultado_do_calculo.Text = "O resultado é: ___";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calcular.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_calcular.Location = new System.Drawing.Point(223, 166);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(94, 21);
            this.btn_calcular.TabIndex = 8;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.AllowDrop = true;
            this.btn_limpar.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpar.BackgroundImage = global::Mini_calculadora.Properties.Resources.fundo_azul;
            this.btn_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(148, 234);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(217, 21);
            this.btn_limpar.TabIndex = 10;
            this.btn_limpar.Text = "Limpar todos os campos";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // operacao
            // 
            this.operacao.Location = new System.Drawing.Point(222, 62);
            this.operacao.Name = "operacao";
            this.operacao.Size = new System.Drawing.Size(99, 20);
            this.operacao.TabIndex = 11;
            // 
            // Aviso
            // 
            this.Aviso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aviso.AutoSize = true;
            this.Aviso.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aviso.ForeColor = System.Drawing.Color.Red;
            this.Aviso.Location = new System.Drawing.Point(34, 88);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(0, 13);
            this.Aviso.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Mini_calculadora.Properties.Resources.fundo_azul;
            this.ClientSize = new System.Drawing.Size(498, 354);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.operacao);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.resultado_do_calculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.segundo_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.primeiro_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox primeiro_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox segundo_valor;
        private System.Windows.Forms.Label resultado_do_calculo;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox operacao;
        private System.Windows.Forms.Label Aviso;
    }
}

