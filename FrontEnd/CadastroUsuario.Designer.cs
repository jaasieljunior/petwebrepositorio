namespace FrontEnd
{
    partial class CadastroUsuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxAdicionalCliente = new System.Windows.Forms.GroupBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxRG = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelRG = new System.Windows.Forms.Label();
            this.groupBoxAdicionalVeterinario = new System.Windows.Forms.GroupBox();
            this.textBoxCMRV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxAdicionalCliente.SuspendLayout();
            this.groupBoxAdicionalVeterinario.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(183, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSalvar);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(94, 8);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(94, 37);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha";
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(94, 91);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(100, 20);
            this.textLogin.TabIndex = 10;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(94, 121);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(100, 20);
            this.textSenha.TabIndex = 11;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Cliente",
            "Veterinário"});
            this.comboBoxTipo.Location = new System.Drawing.Point(94, 156);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipo.TabIndex = 14;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo";
            // 
            // groupBoxAdicionalCliente
            // 
            this.groupBoxAdicionalCliente.Controls.Add(this.textBoxCPF);
            this.groupBoxAdicionalCliente.Controls.Add(this.textBoxRG);
            this.groupBoxAdicionalCliente.Controls.Add(this.labelCPF);
            this.groupBoxAdicionalCliente.Controls.Add(this.labelRG);
            this.groupBoxAdicionalCliente.Location = new System.Drawing.Point(237, 8);
            this.groupBoxAdicionalCliente.Name = "groupBoxAdicionalCliente";
            this.groupBoxAdicionalCliente.Size = new System.Drawing.Size(260, 136);
            this.groupBoxAdicionalCliente.TabIndex = 16;
            this.groupBoxAdicionalCliente.TabStop = false;
            this.groupBoxAdicionalCliente.Text = "Dados adicionais";
            this.groupBoxAdicionalCliente.Visible = false;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(50, 45);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(100, 20);
            this.textBoxCPF.TabIndex = 3;
            // 
            // textBoxRG
            // 
            this.textBoxRG.Location = new System.Drawing.Point(50, 19);
            this.textBoxRG.Name = "textBoxRG";
            this.textBoxRG.Size = new System.Drawing.Size(100, 20);
            this.textBoxRG.TabIndex = 2;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(7, 45);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "CPF";
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Location = new System.Drawing.Point(7, 20);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(23, 13);
            this.labelRG.TabIndex = 0;
            this.labelRG.Text = "RG";
            // 
            // groupBoxAdicionalVeterinario
            // 
            this.groupBoxAdicionalVeterinario.Controls.Add(this.textBoxCMRV);
            this.groupBoxAdicionalVeterinario.Controls.Add(this.label5);
            this.groupBoxAdicionalVeterinario.Location = new System.Drawing.Point(237, 8);
            this.groupBoxAdicionalVeterinario.Name = "groupBoxAdicionalVeterinario";
            this.groupBoxAdicionalVeterinario.Size = new System.Drawing.Size(260, 136);
            this.groupBoxAdicionalVeterinario.TabIndex = 17;
            this.groupBoxAdicionalVeterinario.TabStop = false;
            this.groupBoxAdicionalVeterinario.Text = "Dados adicionais";
            this.groupBoxAdicionalVeterinario.Visible = false;
            // 
            // textBoxCMRV
            // 
            this.textBoxCMRV.Location = new System.Drawing.Point(51, 17);
            this.textBoxCMRV.Name = "textBoxCMRV";
            this.textBoxCMRV.Size = new System.Drawing.Size(100, 20);
            this.textBoxCMRV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CMRV";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(94, 65);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "E-mail";
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 253);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxAdicionalVeterinario);
            this.Controls.Add(this.groupBoxAdicionalCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.button1);
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Usuário";
            this.TopMost = true;
            this.groupBoxAdicionalCliente.ResumeLayout(false);
            this.groupBoxAdicionalCliente.PerformLayout();
            this.groupBoxAdicionalVeterinario.ResumeLayout(false);
            this.groupBoxAdicionalVeterinario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxAdicionalCliente;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.TextBox textBoxRG;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.GroupBox groupBoxAdicionalVeterinario;
        private System.Windows.Forms.TextBox textBoxCMRV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
    }
}
