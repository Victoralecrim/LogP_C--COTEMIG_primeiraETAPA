namespace EX17Pag09
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
            this.lblQuantProd = new System.Windows.Forms.Label();
            this.lblPreçoProd = new System.Windows.Forms.Label();
            this.txtQuantProd = new System.Windows.Forms.TextBox();
            this.txtValorProd = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.txtExibirResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblQuantProd
            // 
            this.lblQuantProd.AutoSize = true;
            this.lblQuantProd.Location = new System.Drawing.Point(33, 28);
            this.lblQuantProd.Name = "lblQuantProd";
            this.lblQuantProd.Size = new System.Drawing.Size(215, 13);
            this.lblQuantProd.TabIndex = 0;
            this.lblQuantProd.Text = "Forneça a quantidade solicitada do produto:";
            // 
            // lblPreçoProd
            // 
            this.lblPreçoProd.AutoSize = true;
            this.lblPreçoProd.Location = new System.Drawing.Point(49, 98);
            this.lblPreçoProd.Name = "lblPreçoProd";
            this.lblPreçoProd.Size = new System.Drawing.Size(175, 13);
            this.lblPreçoProd.TabIndex = 1;
            this.lblPreçoProd.Text = "Forneça o valor unitario do produto:";
            // 
            // txtQuantProd
            // 
            this.txtQuantProd.Location = new System.Drawing.Point(254, 21);
            this.txtQuantProd.Name = "txtQuantProd";
            this.txtQuantProd.Size = new System.Drawing.Size(100, 20);
            this.txtQuantProd.TabIndex = 2;
            // 
            // txtValorProd
            // 
            this.txtValorProd.Location = new System.Drawing.Point(254, 95);
            this.txtValorProd.Name = "txtValorProd";
            this.txtValorProd.Size = new System.Drawing.Size(100, 20);
            this.txtValorProd.TabIndex = 3;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(316, 169);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 4;
            this.CalcBtn.Text = "Calcular";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // txtExibirResultado
            // 
            this.txtExibirResultado.Location = new System.Drawing.Point(303, 231);
            this.txtExibirResultado.Name = "txtExibirResultado";
            this.txtExibirResultado.Size = new System.Drawing.Size(100, 20);
            this.txtExibirResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExibirResultado);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.txtValorProd);
            this.Controls.Add(this.txtQuantProd);
            this.Controls.Add(this.lblPreçoProd);
            this.Controls.Add(this.lblQuantProd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantProd;
        private System.Windows.Forms.Label lblPreçoProd;
        private System.Windows.Forms.TextBox txtQuantProd;
        private System.Windows.Forms.TextBox txtValorProd;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.TextBox txtExibirResultado;
    }
}

