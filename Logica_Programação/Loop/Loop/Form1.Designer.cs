
namespace Loop
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
            this.btWhile = new System.Windows.Forms.Button();
            this.btDoWhile = new System.Windows.Forms.Button();
            this.btFor = new System.Windows.Forms.Button();
            this.libResult = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoma = new System.Windows.Forms.TextBox();
            this.tbMedium = new System.Windows.Forms.TextBox();
            this.btImpar = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loop";
            // 
            // btWhile
            // 
            this.btWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWhile.Location = new System.Drawing.Point(12, 51);
            this.btWhile.Name = "btWhile";
            this.btWhile.Size = new System.Drawing.Size(97, 49);
            this.btWhile.TabIndex = 1;
            this.btWhile.Text = "While";
            this.btWhile.UseVisualStyleBackColor = true;
            this.btWhile.Click += new System.EventHandler(this.btWhile_Click);
            // 
            // btDoWhile
            // 
            this.btDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoWhile.Location = new System.Drawing.Point(12, 106);
            this.btDoWhile.Name = "btDoWhile";
            this.btDoWhile.Size = new System.Drawing.Size(97, 49);
            this.btDoWhile.TabIndex = 2;
            this.btDoWhile.Text = "Do While";
            this.btDoWhile.UseVisualStyleBackColor = true;
            this.btDoWhile.Click += new System.EventHandler(this.btDoWhile_Click);
            // 
            // btFor
            // 
            this.btFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFor.Location = new System.Drawing.Point(12, 161);
            this.btFor.Name = "btFor";
            this.btFor.Size = new System.Drawing.Size(97, 49);
            this.btFor.TabIndex = 3;
            this.btFor.Text = "For";
            this.btFor.UseVisualStyleBackColor = true;
            this.btFor.Click += new System.EventHandler(this.btFor_Click);
            // 
            // libResult
            // 
            this.libResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libResult.FormattingEnabled = true;
            this.libResult.ItemHeight = 20;
            this.libResult.Location = new System.Drawing.Point(160, 15);
            this.libResult.Name = "libResult";
            this.libResult.Size = new System.Drawing.Size(242, 244);
            this.libResult.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Média";
            // 
            // tbSoma
            // 
            this.tbSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoma.Location = new System.Drawing.Point(333, 367);
            this.tbSoma.Name = "tbSoma";
            this.tbSoma.Size = new System.Drawing.Size(69, 26);
            this.tbSoma.TabIndex = 7;
            // 
            // tbMedium
            // 
            this.tbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMedium.Location = new System.Drawing.Point(333, 412);
            this.tbMedium.Name = "tbMedium";
            this.tbMedium.Size = new System.Drawing.Size(69, 26);
            this.tbMedium.TabIndex = 8;
            // 
            // btImpar
            // 
            this.btImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImpar.Location = new System.Drawing.Point(12, 216);
            this.btImpar.Name = "btImpar";
            this.btImpar.Size = new System.Drawing.Size(97, 49);
            this.btImpar.TabIndex = 9;
            this.btImpar.Text = "Números Impares";
            this.btImpar.UseVisualStyleBackColor = true;
            this.btImpar.Click += new System.EventHandler(this.btImpar_Click);
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.Location = new System.Drawing.Point(12, 271);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(97, 49);
            this.btSoma.TabIndex = 10;
            this.btSoma.Text = "Soma";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Média";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.btImpar);
            this.Controls.Add(this.tbMedium);
            this.Controls.Add(this.tbSoma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.libResult);
            this.Controls.Add(this.btFor);
            this.Controls.Add(this.btDoWhile);
            this.Controls.Add(this.btWhile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btWhile;
        private System.Windows.Forms.Button btDoWhile;
        private System.Windows.Forms.Button btFor;
        private System.Windows.Forms.ListBox libResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoma;
        private System.Windows.Forms.TextBox tbMedium;
        private System.Windows.Forms.Button btImpar;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button button1;
    }
}

