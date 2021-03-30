
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Resoluções");
            this.Botao1 = new System.Windows.Forms.Button();
            this.barradeprogresso = new System.Windows.Forms.ProgressBar();
            this.texto1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pairado = new System.Windows.Forms.RadioButton();
            this.atumakkkk = new System.Windows.Forms.RadioButton();
            this.loboradio2 = new System.Windows.Forms.RadioButton();
            this.sexoradio = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Resolutions = new System.Windows.Forms.TreeView();
            this.FullScreen = new System.Windows.Forms.Button();
            this.Confirmresolution = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Botao1
            // 
            this.Botao1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Botao1.Location = new System.Drawing.Point(318, 206);
            this.Botao1.Name = "Botao1";
            this.Botao1.Size = new System.Drawing.Size(128, 43);
            this.Botao1.TabIndex = 0;
            this.Botao1.Text = "Clica aqui por favor";
            this.Botao1.UseVisualStyleBackColor = true;
            this.Botao1.Click += new System.EventHandler(this.button1_Click);
            // 
            // barradeprogresso
            // 
            this.barradeprogresso.Location = new System.Drawing.Point(318, 255);
            this.barradeprogresso.Name = "barradeprogresso";
            this.barradeprogresso.Size = new System.Drawing.Size(128, 29);
            this.barradeprogresso.TabIndex = 2;
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Location = new System.Drawing.Point(336, 190);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(88, 13);
            this.texto1.TabIndex = 1;
            this.texto1.Text = "Você vai Morrer!!";
            this.texto1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 476);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pairado);
            this.tabPage1.Controls.Add(this.atumakkkk);
            this.tabPage1.Controls.Add(this.loboradio2);
            this.tabPage1.Controls.Add(this.sexoradio);
            this.tabPage1.Controls.Add(this.Botao1);
            this.tabPage1.Controls.Add(this.barradeprogresso);
            this.tabPage1.Controls.Add(this.texto1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SEXO DA PAGINA 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pairado
            // 
            this.pairado.AutoSize = true;
            this.pairado.Location = new System.Drawing.Point(409, 336);
            this.pairado.Name = "pairado";
            this.pairado.Size = new System.Drawing.Size(63, 17);
            this.pairado.TabIndex = 6;
            this.pairado.TabStop = true;
            this.pairado.Text = "Meu pai";
            this.pairado.UseVisualStyleBackColor = true;
            // 
            // atumakkkk
            // 
            this.atumakkkk.AutoSize = true;
            this.atumakkkk.Location = new System.Drawing.Point(409, 313);
            this.atumakkkk.Name = "atumakkkk";
            this.atumakkkk.Size = new System.Drawing.Size(90, 17);
            this.atumakkkk.TabIndex = 5;
            this.atumakkkk.TabStop = true;
            this.atumakkkk.Text = "ATUMALACA";
            this.atumakkkk.UseVisualStyleBackColor = true;
            // 
            // loboradio2
            // 
            this.loboradio2.AutoSize = true;
            this.loboradio2.Location = new System.Drawing.Point(306, 336);
            this.loboradio2.Name = "loboradio2";
            this.loboradio2.Size = new System.Drawing.Size(106, 17);
            this.loboradio2.TabIndex = 4;
            this.loboradio2.TabStop = true;
            this.loboradio2.Text = "Lobotomia frontal";
            this.loboradio2.UseVisualStyleBackColor = true;
            // 
            // sexoradio
            // 
            this.sexoradio.AutoSize = true;
            this.sexoradio.Location = new System.Drawing.Point(306, 313);
            this.sexoradio.Name = "sexoradio";
            this.sexoradio.Size = new System.Drawing.Size(49, 17);
            this.sexoradio.TabIndex = 3;
            this.sexoradio.TabStop = true;
            this.sexoradio.Text = "Sexo";
            this.sexoradio.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Confirmresolution);
            this.tabPage2.Controls.Add(this.Resolutions);
            this.tabPage2.Controls.Add(this.FullScreen);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SEXO DA PAGINA 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Resolutions
            // 
            this.Resolutions.Location = new System.Drawing.Point(7, 36);
            this.Resolutions.Name = "Resolutions";
            treeNode1.Name = "Resolutions";
            treeNode1.Text = "Resoluções";
            this.Resolutions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.Resolutions.Size = new System.Drawing.Size(123, 91);
            this.Resolutions.TabIndex = 4;
            this.Resolutions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Resolutions_NodeMouseDoubleClick);
            // 
            // FullScreen
            // 
            this.FullScreen.Location = new System.Drawing.Point(6, 6);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Size = new System.Drawing.Size(75, 23);
            this.FullScreen.TabIndex = 0;
            this.FullScreen.Text = "FullScreen";
            this.FullScreen.UseVisualStyleBackColor = true;
            this.FullScreen.Click += new System.EventHandler(this.FullScreen_Click);
            // 
            // Confirmresolution
            // 
            this.Confirmresolution.Location = new System.Drawing.Point(7, 134);
            this.Confirmresolution.Name = "Confirmresolution";
            this.Confirmresolution.Size = new System.Drawing.Size(123, 23);
            this.Confirmresolution.TabIndex = 5;
            this.Confirmresolution.Text = "Confirmar resolução";
            this.Confirmresolution.UseVisualStyleBackColor = true;
            this.Confirmresolution.Click += new System.EventHandler(this.Confirmresolution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Primeiro coisinha em C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Botao1;
        private System.Windows.Forms.ProgressBar barradeprogresso;
        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton pairado;
        private System.Windows.Forms.RadioButton loboradio2;
        private System.Windows.Forms.RadioButton sexoradio;
        private System.Windows.Forms.RadioButton atumakkkk;
        private System.Windows.Forms.Button FullScreen;
        private System.Windows.Forms.TreeView Resolutions;
        private System.Windows.Forms.Button Confirmresolution;
    }
}

