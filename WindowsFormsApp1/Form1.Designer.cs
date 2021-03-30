
namespace WindowsFormsApp1
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
            this.Botao1 = new System.Windows.Forms.Button();
            this.texto1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Botao1
            // 
            this.Botao1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Botao1.Location = new System.Drawing.Point(334, 239);
            this.Botao1.Name = "Botao1";
            this.Botao1.Size = new System.Drawing.Size(128, 23);
            this.Botao1.TabIndex = 0;
            this.Botao1.Text = "Clica aqui por favor";
            this.Botao1.UseVisualStyleBackColor = true;
            this.Botao1.Click += new System.EventHandler(this.button1_Click);
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Location = new System.Drawing.Point(334, 127);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(88, 13);
            this.texto1.TabIndex = 1;
            this.texto1.Text = "Você vai Morrer!!";
            this.texto1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 500);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.Botao1);
            this.Name = "Form1";
            this.Text = "Primeiro coisinha em C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botao1;
        private System.Windows.Forms.Label texto1;
    }
}

