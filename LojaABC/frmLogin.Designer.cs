
namespace LojaABC
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.PIngu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DigUsuario = new System.Windows.Forms.TextBox();
            this.DigSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Botaoentrar = new System.Windows.Forms.Button();
            this.botaoSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PIngu)).BeginInit();
            this.SuspendLayout();
            // 
            // PIngu
            // 
            this.PIngu.Image = ((System.Drawing.Image)(resources.GetObject("PIngu.Image")));
            this.PIngu.Location = new System.Drawing.Point(0, 0);
            this.PIngu.Name = "PIngu";
            this.PIngu.Size = new System.Drawing.Size(791, 569);
            this.PIngu.TabIndex = 0;
            this.PIngu.TabStop = false;
            this.PIngu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // DigUsuario
            // 
            this.DigUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigUsuario.Location = new System.Drawing.Point(254, 84);
            this.DigUsuario.MaxLength = 32;
            this.DigUsuario.Name = "DigUsuario";
            this.DigUsuario.Size = new System.Drawing.Size(264, 22);
            this.DigUsuario.TabIndex = 0;
            // 
            // DigSenha
            // 
            this.DigSenha.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.DigSenha.Location = new System.Drawing.Point(254, 157);
            this.DigSenha.MaxLength = 8;
            this.DigSenha.Name = "DigSenha";
            this.DigSenha.PasswordChar = 'l';
            this.DigSenha.Size = new System.Drawing.Size(264, 22);
            this.DigSenha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // Botaoentrar
            // 
            this.Botaoentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botaoentrar.Location = new System.Drawing.Point(254, 203);
            this.Botaoentrar.Name = "Botaoentrar";
            this.Botaoentrar.Size = new System.Drawing.Size(75, 23);
            this.Botaoentrar.TabIndex = 2;
            this.Botaoentrar.Text = "&Entrar";
            this.Botaoentrar.UseVisualStyleBackColor = true;
            // 
            // botaoSair
            // 
            this.botaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSair.Location = new System.Drawing.Point(345, 203);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(75, 23);
            this.botaoSair.TabIndex = 3;
            this.botaoSair.Text = "Sai&r";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.Botaoentrar);
            this.Controls.Add(this.DigSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DigUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PIngu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja ABC login";
            ((System.ComponentModel.ISupportInitialize)(this.PIngu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PIngu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DigUsuario;
        private System.Windows.Forms.TextBox DigSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Botaoentrar;
        private System.Windows.Forms.Button botaoSair;
    }
}