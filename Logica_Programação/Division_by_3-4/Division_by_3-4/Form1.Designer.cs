
namespace Division_by_3_4
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
            this.btDoWhile = new System.Windows.Forms.Button();
            this.btWhile = new System.Windows.Forms.Button();
            this.btFor = new System.Windows.Forms.Button();
            this.libResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDoWhile
            // 
            this.btDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoWhile.Location = new System.Drawing.Point(12, 275);
            this.btDoWhile.Name = "btDoWhile";
            this.btDoWhile.Size = new System.Drawing.Size(137, 59);
            this.btDoWhile.TabIndex = 18;
            this.btDoWhile.Text = "Do While";
            this.btDoWhile.UseVisualStyleBackColor = true;
            this.btDoWhile.Click += new System.EventHandler(this.btDoWhile_Click);
            // 
            // btWhile
            // 
            this.btWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWhile.Location = new System.Drawing.Point(12, 167);
            this.btWhile.Name = "btWhile";
            this.btWhile.Size = new System.Drawing.Size(137, 59);
            this.btWhile.TabIndex = 17;
            this.btWhile.Text = "While";
            this.btWhile.UseVisualStyleBackColor = true;
            this.btWhile.Click += new System.EventHandler(this.btWhile_Click);
            // 
            // btFor
            // 
            this.btFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFor.Location = new System.Drawing.Point(12, 60);
            this.btFor.Name = "btFor";
            this.btFor.Size = new System.Drawing.Size(137, 59);
            this.btFor.TabIndex = 16;
            this.btFor.Text = "For";
            this.btFor.UseVisualStyleBackColor = true;
            this.btFor.Click += new System.EventHandler(this.btFor_Click);
            // 
            // libResult
            // 
            this.libResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libResult.FormattingEnabled = true;
            this.libResult.ItemHeight = 25;
            this.libResult.Location = new System.Drawing.Point(184, 60);
            this.libResult.Name = "libResult";
            this.libResult.Size = new System.Drawing.Size(341, 329);
            this.libResult.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Divisíveis por 3 e 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 410);
            this.Controls.Add(this.btDoWhile);
            this.Controls.Add(this.btWhile);
            this.Controls.Add(this.btFor);
            this.Controls.Add(this.libResult);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDoWhile;
        private System.Windows.Forms.Button btWhile;
        private System.Windows.Forms.Button btFor;
        private System.Windows.Forms.ListBox libResult;
        private System.Windows.Forms.Label label1;
    }
}

