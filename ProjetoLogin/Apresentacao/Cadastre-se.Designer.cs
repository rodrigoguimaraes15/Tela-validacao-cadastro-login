
namespace ProjetoLogin.Apresentacao
{
    partial class CadastreSe
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.btnCadastrar2 = new System.Windows.Forms.Button();
            this.txtLogin2 = new System.Windows.Forms.TextBox();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(104, 36);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(48, 20);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(96, 82);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfSenha.Location = new System.Drawing.Point(23, 125);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(129, 20);
            this.lblConfSenha.TabIndex = 2;
            this.lblConfSenha.Text = "Confirmar Senha";
            // 
            // btnCadastrar2
            // 
            this.btnCadastrar2.Location = new System.Drawing.Point(220, 178);
            this.btnCadastrar2.Name = "btnCadastrar2";
            this.btnCadastrar2.Size = new System.Drawing.Size(116, 34);
            this.btnCadastrar2.TabIndex = 3;
            this.btnCadastrar2.Text = "Cadastrar";
            this.btnCadastrar2.UseVisualStyleBackColor = true;
            this.btnCadastrar2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLogin2
            // 
            this.txtLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin2.Location = new System.Drawing.Point(181, 34);
            this.txtLogin2.Name = "txtLogin2";
            this.txtLogin2.Size = new System.Drawing.Size(155, 22);
            this.txtLogin2.TabIndex = 4;
            // 
            // txtSenha2
            // 
            this.txtSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha2.Location = new System.Drawing.Point(181, 80);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.Size = new System.Drawing.Size(155, 22);
            this.txtSenha2.TabIndex = 5;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfSenha.Location = new System.Drawing.Point(181, 123);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(155, 22);
            this.txtConfSenha.TabIndex = 6;
            // 
            // CadastreSe
            // 
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.txtLogin2);
            this.Controls.Add(this.btnCadastrar2);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastreSe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.Button btnCadastrar2;
        private System.Windows.Forms.TextBox txtLogin2;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.TextBox txtConfSenha;
    }
}