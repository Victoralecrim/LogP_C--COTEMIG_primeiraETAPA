namespace Ex09Pag08
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmoeda1cent = new System.Windows.Forms.TextBox();
            this.txtmoeda5cent = new System.Windows.Forms.TextBox();
            this.txtmoeda10cent = new System.Windows.Forms.TextBox();
            this.txtmoeda25cent = new System.Windows.Forms.TextBox();
            this.txtmoeda50cent = new System.Windows.Forms.TextBox();
            this.txtmoeda1R = new System.Windows.Forms.TextBox();
            this.btnCalcTotalM = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a quantidade de moedas de cada valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "0.01:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "0.05:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "0.10:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "0.25:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "0.50:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "1.00:";
            // 
            // txtmoeda1cent
            // 
            this.txtmoeda1cent.Location = new System.Drawing.Point(120, 82);
            this.txtmoeda1cent.Name = "txtmoeda1cent";
            this.txtmoeda1cent.Size = new System.Drawing.Size(117, 20);
            this.txtmoeda1cent.TabIndex = 8;
            // 
            // txtmoeda5cent
            // 
            this.txtmoeda5cent.Location = new System.Drawing.Point(120, 132);
            this.txtmoeda5cent.Name = "txtmoeda5cent";
            this.txtmoeda5cent.Size = new System.Drawing.Size(117, 20);
            this.txtmoeda5cent.TabIndex = 9;
            // 
            // txtmoeda10cent
            // 
            this.txtmoeda10cent.Location = new System.Drawing.Point(120, 172);
            this.txtmoeda10cent.Name = "txtmoeda10cent";
            this.txtmoeda10cent.Size = new System.Drawing.Size(117, 20);
            this.txtmoeda10cent.TabIndex = 10;
            // 
            // txtmoeda25cent
            // 
            this.txtmoeda25cent.Location = new System.Drawing.Point(120, 215);
            this.txtmoeda25cent.Name = "txtmoeda25cent";
            this.txtmoeda25cent.Size = new System.Drawing.Size(117, 20);
            this.txtmoeda25cent.TabIndex = 11;
            // 
            // txtmoeda50cent
            // 
            this.txtmoeda50cent.Location = new System.Drawing.Point(120, 259);
            this.txtmoeda50cent.Name = "txtmoeda50cent";
            this.txtmoeda50cent.Size = new System.Drawing.Size(117, 20);
            this.txtmoeda50cent.TabIndex = 12;
            // 
            // txtmoeda1R
            // 
            this.txtmoeda1R.Location = new System.Drawing.Point(120, 309);
            this.txtmoeda1R.Name = "txtmoeda1R";
            this.txtmoeda1R.Size = new System.Drawing.Size(117, 20);
            this.txtmoeda1R.TabIndex = 13;
            // 
            // btnCalcTotalM
            // 
            this.btnCalcTotalM.Location = new System.Drawing.Point(344, 342);
            this.btnCalcTotalM.Name = "btnCalcTotalM";
            this.btnCalcTotalM.Size = new System.Drawing.Size(75, 23);
            this.btnCalcTotalM.TabIndex = 14;
            this.btnCalcTotalM.Text = "Calcular";
            this.btnCalcTotalM.UseVisualStyleBackColor = true;
            this.btnCalcTotalM.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(332, 402);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnCalcTotalM);
            this.Controls.Add(this.txtmoeda1R);
            this.Controls.Add(this.txtmoeda50cent);
            this.Controls.Add(this.txtmoeda25cent);
            this.Controls.Add(this.txtmoeda10cent);
            this.Controls.Add(this.txtmoeda5cent);
            this.Controls.Add(this.txtmoeda1cent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmoeda1cent;
        private System.Windows.Forms.TextBox txtmoeda5cent;
        private System.Windows.Forms.TextBox txtmoeda10cent;
        private System.Windows.Forms.TextBox txtmoeda25cent;
        private System.Windows.Forms.TextBox txtmoeda50cent;
        private System.Windows.Forms.TextBox txtmoeda1R;
        private System.Windows.Forms.Button btnCalcTotalM;
        private System.Windows.Forms.TextBox txttotal;
    }
}

