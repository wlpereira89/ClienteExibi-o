namespace ClienteExibicao
{
    partial class View
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
            this.label3 = new System.Windows.Forms.Label();
            this.EditRegistro = new System.Windows.Forms.ComboBox();
            this.EditImagem = new System.Windows.Forms.ComboBox();
            this.BtnListarImg = new System.Windows.Forms.Button();
            this.BtnExibirImg = new System.Windows.Forms.Button();
            this.PicImagem = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditTipo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imagem";
            // 
            // EditRegistro
            // 
            this.EditRegistro.FormattingEnabled = true;
            this.EditRegistro.Location = new System.Drawing.Point(62, 6);
            this.EditRegistro.Name = "EditRegistro";
            this.EditRegistro.Size = new System.Drawing.Size(219, 21);
            this.EditRegistro.TabIndex = 3;
            // 
            // EditImagem
            // 
            this.EditImagem.FormattingEnabled = true;
            this.EditImagem.Location = new System.Drawing.Point(62, 74);
            this.EditImagem.Name = "EditImagem";
            this.EditImagem.Size = new System.Drawing.Size(219, 21);
            this.EditImagem.TabIndex = 5;
            // 
            // BtnListarImg
            // 
            this.BtnListarImg.Location = new System.Drawing.Point(287, 4);
            this.BtnListarImg.Name = "BtnListarImg";
            this.BtnListarImg.Size = new System.Drawing.Size(94, 43);
            this.BtnListarImg.TabIndex = 6;
            this.BtnListarImg.Text = "Listar Imagens";
            this.BtnListarImg.UseVisualStyleBackColor = true;
            this.BtnListarImg.Click += new System.EventHandler(this.BtnListarImg_Click);
            // 
            // BtnExibirImg
            // 
            this.BtnExibirImg.Location = new System.Drawing.Point(287, 53);
            this.BtnExibirImg.Name = "BtnExibirImg";
            this.BtnExibirImg.Size = new System.Drawing.Size(94, 44);
            this.BtnExibirImg.TabIndex = 7;
            this.BtnExibirImg.Text = "Exibir Imagem";
            this.BtnExibirImg.UseVisualStyleBackColor = true;
            this.BtnExibirImg.Visible = false;
            this.BtnExibirImg.Click += new System.EventHandler(this.BtnExibirImg_Click);
            // 
            // PicImagem
            // 
            this.PicImagem.Location = new System.Drawing.Point(22, 103);
            this.PicImagem.Name = "PicImagem";
            this.PicImagem.Size = new System.Drawing.Size(350, 350);
            this.PicImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagem.TabIndex = 7;
            this.PicImagem.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo arquivo procurado";
            // 
            // EditTipo
            // 
            this.EditTipo.Location = new System.Drawing.Point(133, 41);
            this.EditTipo.Name = "EditTipo";
            this.EditTipo.Size = new System.Drawing.Size(148, 20);
            this.EditTipo.TabIndex = 4;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 465);
            this.Controls.Add(this.EditTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PicImagem);
            this.Controls.Add(this.BtnExibirImg);
            this.Controls.Add(this.BtnListarImg);
            this.Controls.Add(this.EditImagem);
            this.Controls.Add(this.EditRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "View";
            this.Text = "Visualização";
            ((System.ComponentModel.ISupportInitialize)(this.PicImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EditRegistro;
        private System.Windows.Forms.ComboBox EditImagem;
        private System.Windows.Forms.Button BtnListarImg;
        private System.Windows.Forms.Button BtnExibirImg;
        private System.Windows.Forms.PictureBox PicImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditTipo;
    }
}

