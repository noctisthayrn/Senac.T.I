
namespace Vector_Matrix
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
            this.btVector = new System.Windows.Forms.Button();
            this.btMatrix = new System.Windows.Forms.Button();
            this.libList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaiorNumero = new System.Windows.Forms.TextBox();
            this.tbMenorNumero = new System.Windows.Forms.TextBox();
            this.libPares = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vetor de 10 possições";
            // 
            // btVector
            // 
            this.btVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVector.Location = new System.Drawing.Point(13, 85);
            this.btVector.Name = "btVector";
            this.btVector.Size = new System.Drawing.Size(145, 60);
            this.btVector.TabIndex = 1;
            this.btVector.Text = "Vector";
            this.btVector.UseVisualStyleBackColor = true;
            this.btVector.Click += new System.EventHandler(this.btVector_Click);
            // 
            // btMatrix
            // 
            this.btMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMatrix.Location = new System.Drawing.Point(12, 269);
            this.btMatrix.Name = "btMatrix";
            this.btMatrix.Size = new System.Drawing.Size(145, 60);
            this.btMatrix.TabIndex = 2;
            this.btMatrix.Text = "Metrix";
            this.btMatrix.UseVisualStyleBackColor = true;
            this.btMatrix.Click += new System.EventHandler(this.btMatrix_Click);
            // 
            // libList
            // 
            this.libList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libList.FormattingEnabled = true;
            this.libList.ItemHeight = 20;
            this.libList.Location = new System.Drawing.Point(215, 85);
            this.libList.Name = "libList";
            this.libList.Size = new System.Drawing.Size(220, 244);
            this.libList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(766, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maior Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(766, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menor Número";
            // 
            // tbMaiorNumero
            // 
            this.tbMaiorNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaiorNumero.Location = new System.Drawing.Point(903, 83);
            this.tbMaiorNumero.Name = "tbMaiorNumero";
            this.tbMaiorNumero.Size = new System.Drawing.Size(100, 26);
            this.tbMaiorNumero.TabIndex = 6;
            // 
            // tbMenorNumero
            // 
            this.tbMenorNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMenorNumero.Location = new System.Drawing.Point(903, 137);
            this.tbMenorNumero.Name = "tbMenorNumero";
            this.tbMenorNumero.Size = new System.Drawing.Size(100, 26);
            this.tbMenorNumero.TabIndex = 7;
            // 
            // libPares
            // 
            this.libPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libPares.FormattingEnabled = true;
            this.libPares.ItemHeight = 20;
            this.libPares.Location = new System.Drawing.Point(458, 85);
            this.libPares.Name = "libPares";
            this.libPares.Size = new System.Drawing.Size(220, 244);
            this.libPares.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 605);
            this.Controls.Add(this.libPares);
            this.Controls.Add(this.tbMenorNumero);
            this.Controls.Add(this.tbMaiorNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.libList);
            this.Controls.Add(this.btMatrix);
            this.Controls.Add(this.btVector);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVector;
        private System.Windows.Forms.Button btMatrix;
        private System.Windows.Forms.ListBox libList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaiorNumero;
        private System.Windows.Forms.TextBox tbMenorNumero;
        private System.Windows.Forms.ListBox libPares;
    }
}

