
namespace Multi
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
            this.libResult = new System.Windows.Forms.ListBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btFor = new System.Windows.Forms.Button();
            this.btWhile = new System.Windows.Forms.Button();
            this.btDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabuada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número:";
            // 
            // libResult
            // 
            this.libResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libResult.FormattingEnabled = true;
            this.libResult.ItemHeight = 25;
            this.libResult.Location = new System.Drawing.Point(194, 51);
            this.libResult.Name = "libResult";
            this.libResult.Size = new System.Drawing.Size(243, 329);
            this.libResult.TabIndex = 2;
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.Location = new System.Drawing.Point(93, 51);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(66, 26);
            this.tbNumber.TabIndex = 3;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            // 
            // btFor
            // 
            this.btFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFor.Location = new System.Drawing.Point(22, 110);
            this.btFor.Name = "btFor";
            this.btFor.Size = new System.Drawing.Size(137, 59);
            this.btFor.TabIndex = 4;
            this.btFor.Text = "For";
            this.btFor.UseVisualStyleBackColor = true;
            this.btFor.Click += new System.EventHandler(this.btFor_Click);
            // 
            // btWhile
            // 
            this.btWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWhile.Location = new System.Drawing.Point(22, 189);
            this.btWhile.Name = "btWhile";
            this.btWhile.Size = new System.Drawing.Size(137, 59);
            this.btWhile.TabIndex = 5;
            this.btWhile.Text = "While";
            this.btWhile.UseVisualStyleBackColor = true;
            this.btWhile.Click += new System.EventHandler(this.btWhile_Click);
            // 
            // btDoWhile
            // 
            this.btDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoWhile.Location = new System.Drawing.Point(22, 266);
            this.btDoWhile.Name = "btDoWhile";
            this.btDoWhile.Size = new System.Drawing.Size(137, 59);
            this.btDoWhile.TabIndex = 6;
            this.btDoWhile.Text = "Do While";
            this.btDoWhile.UseVisualStyleBackColor = true;
            this.btDoWhile.Click += new System.EventHandler(this.btDoWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 405);
            this.Controls.Add(this.btDoWhile);
            this.Controls.Add(this.btWhile);
            this.Controls.Add(this.btFor);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.libResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox libResult;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btFor;
        private System.Windows.Forms.Button btWhile;
        private System.Windows.Forms.Button btDoWhile;
    }
}

