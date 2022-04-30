namespace Ex05_pag08
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.btnCalcArea = new System.Windows.Forms.Button();
            this.btnCalcPerimetro = new System.Windows.Forms.Button();
            this.txtExibirArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor da base do retangulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o valor da altura:";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(192, 37);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(84, 20);
            this.txtBase.TabIndex = 2;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(192, 75);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(84, 20);
            this.txtaltura.TabIndex = 3;
            // 
            // btnCalcArea
            // 
            this.btnCalcArea.Location = new System.Drawing.Point(124, 121);
            this.btnCalcArea.Name = "btnCalcArea";
            this.btnCalcArea.Size = new System.Drawing.Size(75, 23);
            this.btnCalcArea.TabIndex = 4;
            this.btnCalcArea.Text = "CalcArea";
            this.btnCalcArea.UseVisualStyleBackColor = true;
            this.btnCalcArea.Click += new System.EventHandler(this.btnCalcArea_Click);
            // 
            // btnCalcPerimetro
            // 
            this.btnCalcPerimetro.Location = new System.Drawing.Point(263, 117);
            this.btnCalcPerimetro.Name = "btnCalcPerimetro";
            this.btnCalcPerimetro.Size = new System.Drawing.Size(84, 31);
            this.btnCalcPerimetro.TabIndex = 5;
            this.btnCalcPerimetro.Text = "CalcPerimetro";
            this.btnCalcPerimetro.UseVisualStyleBackColor = true;
            this.btnCalcPerimetro.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtExibirArea
            // 
            this.txtExibirArea.Location = new System.Drawing.Point(176, 168);
            this.txtExibirArea.Name = "txtExibirArea";
            this.txtExibirArea.Size = new System.Drawing.Size(100, 20);
            this.txtExibirArea.TabIndex = 6;
            this.txtExibirArea.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 243);
            this.Controls.Add(this.txtExibirArea);
            this.Controls.Add(this.btnCalcPerimetro);
            this.Controls.Add(this.btnCalcArea);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Button btnCalcArea;
        private System.Windows.Forms.Button btnCalcPerimetro;
        private System.Windows.Forms.TextBox txtExibirArea;
    }
}

