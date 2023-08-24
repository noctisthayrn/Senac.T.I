
namespace Loop_01
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
            this.libMessage = new System.Windows.Forms.ListBox();
            this.btMessage = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.libQua = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saudades Renata";
            // 
            // libMessage
            // 
            this.libMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libMessage.FormattingEnabled = true;
            this.libMessage.ItemHeight = 20;
            this.libMessage.Location = new System.Drawing.Point(494, 49);
            this.libMessage.Name = "libMessage";
            this.libMessage.Size = new System.Drawing.Size(365, 364);
            this.libMessage.TabIndex = 1;
            // 
            // btMessage
            // 
            this.btMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMessage.Location = new System.Drawing.Point(13, 80);
            this.btMessage.Name = "btMessage";
            this.btMessage.Size = new System.Drawing.Size(171, 87);
            this.btMessage.TabIndex = 2;
            this.btMessage.Text = "Mensagem";
            this.btMessage.UseVisualStyleBackColor = true;
            this.btMessage.Click += new System.EventHandler(this.btMessage_Click);
            // 
            // btCal
            // 
            this.btCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCal.Location = new System.Drawing.Point(13, 199);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(171, 87);
            this.btCal.TabIndex = 3;
            this.btCal.Text = "Calcular ao Quadrado";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // libQua
            // 
            this.libQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libQua.FormattingEnabled = true;
            this.libQua.ItemHeight = 20;
            this.libQua.Location = new System.Drawing.Point(194, 49);
            this.libQua.Name = "libQua";
            this.libQua.Size = new System.Drawing.Size(277, 364);
            this.libQua.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.libQua);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.btMessage);
            this.Controls.Add(this.libMessage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox libMessage;
        private System.Windows.Forms.Button btMessage;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.ListBox libQua;
    }
}

