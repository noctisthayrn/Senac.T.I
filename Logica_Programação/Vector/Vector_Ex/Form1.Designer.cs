
namespace Vector_Ex
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
            this.btInt = new System.Windows.Forms.Button();
            this.btString = new System.Windows.Forms.Button();
            this.libResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btInt
            // 
            this.btInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInt.Location = new System.Drawing.Point(12, 12);
            this.btInt.Name = "btInt";
            this.btInt.Size = new System.Drawing.Size(157, 64);
            this.btInt.TabIndex = 0;
            this.btInt.Text = "Vetor Int";
            this.btInt.UseVisualStyleBackColor = true;
            this.btInt.Click += new System.EventHandler(this.btInt_Click);
            // 
            // btString
            // 
            this.btString.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btString.Location = new System.Drawing.Point(12, 101);
            this.btString.Name = "btString";
            this.btString.Size = new System.Drawing.Size(157, 64);
            this.btString.TabIndex = 1;
            this.btString.Text = "Vetor String";
            this.btString.UseVisualStyleBackColor = true;
            this.btString.Click += new System.EventHandler(this.btString_Click);
            // 
            // libResult
            // 
            this.libResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libResult.FormattingEnabled = true;
            this.libResult.ItemHeight = 24;
            this.libResult.Location = new System.Drawing.Point(231, 12);
            this.libResult.Name = "libResult";
            this.libResult.Size = new System.Drawing.Size(240, 244);
            this.libResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 306);
            this.Controls.Add(this.libResult);
            this.Controls.Add(this.btString);
            this.Controls.Add(this.btInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btInt;
        private System.Windows.Forms.Button btString;
        private System.Windows.Forms.ListBox libResult;
    }
}

