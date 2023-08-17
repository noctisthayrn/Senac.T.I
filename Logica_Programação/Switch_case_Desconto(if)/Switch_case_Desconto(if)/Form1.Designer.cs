
namespace Switch_case_Desconto_if_
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
            this.btVerificar = new System.Windows.Forms.Button();
            this.tbValorFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDesconto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btVerificar
            // 
            this.btVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerificar.Location = new System.Drawing.Point(498, 261);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(151, 79);
            this.btVerificar.TabIndex = 15;
            this.btVerificar.Text = "Finalizar";
            this.btVerificar.UseVisualStyleBackColor = true;
            this.btVerificar.Click += new System.EventHandler(this.btVerificar_Click);
            // 
            // tbValorFinal
            // 
            this.tbValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorFinal.Location = new System.Drawing.Point(330, 279);
            this.tbValorFinal.Name = "tbValorFinal";
            this.tbValorFinal.Size = new System.Drawing.Size(135, 44);
            this.tbValorFinal.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Preço Final da Compra:";
            // 
            // cbDesconto
            // 
            this.cbDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDesconto.FormattingEnabled = true;
            this.cbDesconto.Location = new System.Drawing.Point(315, 179);
            this.cbDesconto.Name = "cbDesconto";
            this.cbDesconto.Size = new System.Drawing.Size(121, 32);
            this.cbDesconto.TabIndex = 12;
            this.cbDesconto.SelectedIndexChanged += new System.EventHandler(this.cbDesconto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Forma de Pagamento:";
            // 
            // tbPreco
            // 
            this.tbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreco.Location = new System.Drawing.Point(264, 112);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(100, 29);
            this.tbPreco.TabIndex = 10;
            this.tbPreco.TextChanged += new System.EventHandler(this.tbPreco_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor da Compra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calcular preço final de compra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 360);
            this.Controls.Add(this.btVerificar);
            this.Controls.Add(this.tbValorFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDesconto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVerificar;
        private System.Windows.Forms.TextBox tbValorFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDesconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

