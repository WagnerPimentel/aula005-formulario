namespace aula005_formulario
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
            this.btn_trocar = new System.Windows.Forms.Button();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_trocar
            // 
            this.btn_trocar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_trocar.Location = new System.Drawing.Point(82, 56);
            this.btn_trocar.Name = "btn_trocar";
            this.btn_trocar.Size = new System.Drawing.Size(75, 32);
            this.btn_trocar.TabIndex = 0;
            this.btn_trocar.Text = "Trocar";
            this.btn_trocar.UseVisualStyleBackColor = true;
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.Location = new System.Drawing.Point(239, 24);
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(70, 26);
            this.txtSegundoValor.TabIndex = 1;
            // 
            // txtPrimeiroValor
            // 
            this.txtPrimeiroValor.Location = new System.Drawing.Point(82, 24);
            this.txtPrimeiroValor.Name = "txtPrimeiroValor";
            this.txtPrimeiroValor.Size = new System.Drawing.Size(70, 26);
            this.txtPrimeiroValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrimeiroValor);
            this.Controls.Add(this.txtSegundoValor);
            this.Controls.Add(this.btn_trocar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(13, 17);
            this.Name = "Form1";
            this.Text = "frmTrocaDeValores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_trocar;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.TextBox txtPrimeiroValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

