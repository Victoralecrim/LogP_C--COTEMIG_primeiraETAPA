namespace Ex07Pag08
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
            this.lblCamisasP = new System.Windows.Forms.Label();
            this.lblcamisasM = new System.Windows.Forms.Label();
            this.lblCamisasG = new System.Windows.Forms.Label();
            this.txtCamisaP = new System.Windows.Forms.TextBox();
            this.txtCamisaG = new System.Windows.Forms.TextBox();
            this.txtCamisaM = new System.Windows.Forms.TextBox();
            this.btnCalculartotal = new System.Windows.Forms.Button();
            this.txttotalCamisas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCamisasP
            // 
            this.lblCamisasP.AutoSize = true;
            this.lblCamisasP.Location = new System.Drawing.Point(62, 28);
            this.lblCamisasP.Name = "lblCamisasP";
            this.lblCamisasP.Size = new System.Drawing.Size(162, 13);
            this.lblCamisasP.TabIndex = 0;
            this.lblCamisasP.Text = "Digite a quantidade de camisasP";
            // 
            // lblcamisasM
            // 
            this.lblcamisasM.AutoSize = true;
            this.lblcamisasM.Location = new System.Drawing.Point(62, 90);
            this.lblcamisasM.Name = "lblcamisasM";
            this.lblcamisasM.Size = new System.Drawing.Size(164, 13);
            this.lblcamisasM.TabIndex = 1;
            this.lblcamisasM.Text = "Digite a quantidade de camisasM";
            // 
            // lblCamisasG
            // 
            this.lblCamisasG.AutoSize = true;
            this.lblCamisasG.Location = new System.Drawing.Point(62, 158);
            this.lblCamisasG.Name = "lblCamisasG";
            this.lblCamisasG.Size = new System.Drawing.Size(163, 13);
            this.lblCamisasG.TabIndex = 2;
            this.lblCamisasG.Text = "Digite a quantidade de camisasG";
            // 
            // txtCamisaP
            // 
            this.txtCamisaP.Location = new System.Drawing.Point(252, 25);
            this.txtCamisaP.Name = "txtCamisaP";
            this.txtCamisaP.Size = new System.Drawing.Size(112, 20);
            this.txtCamisaP.TabIndex = 3;
            // 
            // txtCamisaG
            // 
            this.txtCamisaG.Location = new System.Drawing.Point(252, 158);
            this.txtCamisaG.Name = "txtCamisaG";
            this.txtCamisaG.Size = new System.Drawing.Size(112, 20);
            this.txtCamisaG.TabIndex = 4;
            // 
            // txtCamisaM
            // 
            this.txtCamisaM.Location = new System.Drawing.Point(252, 87);
            this.txtCamisaM.Name = "txtCamisaM";
            this.txtCamisaM.Size = new System.Drawing.Size(112, 20);
            this.txtCamisaM.TabIndex = 5;
            // 
            // btnCalculartotal
            // 
            this.btnCalculartotal.Location = new System.Drawing.Point(350, 222);
            this.btnCalculartotal.Name = "btnCalculartotal";
            this.btnCalculartotal.Size = new System.Drawing.Size(89, 23);
            this.btnCalculartotal.TabIndex = 6;
            this.btnCalculartotal.Text = "Calucular total";
            this.btnCalculartotal.UseVisualStyleBackColor = true;
            this.btnCalculartotal.Click += new System.EventHandler(this.btnCalculartotal_Click);
            // 
            // txttotalCamisas
            // 
            this.txttotalCamisas.Location = new System.Drawing.Point(339, 267);
            this.txttotalCamisas.Name = "txttotalCamisas";
            this.txttotalCamisas.Size = new System.Drawing.Size(100, 20);
            this.txttotalCamisas.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttotalCamisas);
            this.Controls.Add(this.btnCalculartotal);
            this.Controls.Add(this.txtCamisaM);
            this.Controls.Add(this.txtCamisaG);
            this.Controls.Add(this.txtCamisaP);
            this.Controls.Add(this.lblCamisasG);
            this.Controls.Add(this.lblcamisasM);
            this.Controls.Add(this.lblCamisasP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCamisasP;
        private System.Windows.Forms.Label lblcamisasM;
        private System.Windows.Forms.Label lblCamisasG;
        private System.Windows.Forms.TextBox txtCamisaP;
        private System.Windows.Forms.TextBox txtCamisaG;
        private System.Windows.Forms.TextBox txtCamisaM;
        private System.Windows.Forms.Button btnCalculartotal;
        private System.Windows.Forms.TextBox txttotalCamisas;
    }
}

