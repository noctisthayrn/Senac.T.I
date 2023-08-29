
namespace Vector
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.btOrganize = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbSoma = new System.Windows.Forms.TextBox();
            this.tbMedium = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.libNumber = new System.Windows.Forms.ListBox();
            this.libResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserir um número e realizar a soma, media e\r\norganizar os valores.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe um número";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(17, 159);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(133, 49);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCal
            // 
            this.btCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCal.Location = new System.Drawing.Point(17, 236);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(133, 49);
            this.btCal.TabIndex = 3;
            this.btCal.Text = "Calcular";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btOrganize
            // 
            this.btOrganize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrganize.Location = new System.Drawing.Point(17, 311);
            this.btOrganize.Name = "btOrganize";
            this.btOrganize.Size = new System.Drawing.Size(133, 49);
            this.btOrganize.TabIndex = 4;
            this.btOrganize.Text = "Ordenar";
            this.btOrganize.UseVisualStyleBackColor = true;
            this.btOrganize.Click += new System.EventHandler(this.btOrganize_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.Location = new System.Drawing.Point(17, 107);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(133, 35);
            this.tbNumber.TabIndex = 5;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            // 
            // tbSoma
            // 
            this.tbSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoma.Location = new System.Drawing.Point(251, 365);
            this.tbSoma.Name = "tbSoma";
            this.tbSoma.Size = new System.Drawing.Size(133, 35);
            this.tbSoma.TabIndex = 6;
            // 
            // tbMedium
            // 
            this.tbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMedium.Location = new System.Drawing.Point(412, 365);
            this.tbMedium.Name = "tbMedium";
            this.tbMedium.Size = new System.Drawing.Size(133, 35);
            this.tbMedium.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Média";
            // 
            // libNumber
            // 
            this.libNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libNumber.FormattingEnabled = true;
            this.libNumber.ItemHeight = 20;
            this.libNumber.Location = new System.Drawing.Point(251, 107);
            this.libNumber.Name = "libNumber";
            this.libNumber.Size = new System.Drawing.Size(133, 164);
            this.libNumber.TabIndex = 10;
            // 
            // libResult
            // 
            this.libResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libResult.FormattingEnabled = true;
            this.libResult.ItemHeight = 20;
            this.libResult.Location = new System.Drawing.Point(412, 112);
            this.libResult.Name = "libResult";
            this.libResult.Size = new System.Drawing.Size(133, 164);
            this.libResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 418);
            this.Controls.Add(this.libResult);
            this.Controls.Add(this.libNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMedium);
            this.Controls.Add(this.tbSoma);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.btOrganize);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.btAdd);
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
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btOrganize;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbSoma;
        private System.Windows.Forms.TextBox tbMedium;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox libNumber;
        private System.Windows.Forms.ListBox libResult;
    }
}

