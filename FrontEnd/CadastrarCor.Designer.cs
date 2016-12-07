namespace FrontEnd
{
    partial class CadastrarCor
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
            this.buttonInserirCor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNovaCor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonInserirCor
            // 
            this.buttonInserirCor.Location = new System.Drawing.Point(28, 117);
            this.buttonInserirCor.Name = "buttonInserirCor";
            this.buttonInserirCor.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirCor.TabIndex = 0;
            this.buttonInserirCor.Text = "Inserir";
            this.buttonInserirCor.UseVisualStyleBackColor = true;
            this.buttonInserirCor.Click += new System.EventHandler(this.buttonInserirCor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cor";
            // 
            // textBoxNovaCor
            // 
            this.textBoxNovaCor.Location = new System.Drawing.Point(87, 40);
            this.textBoxNovaCor.Name = "textBoxNovaCor";
            this.textBoxNovaCor.Size = new System.Drawing.Size(131, 20);
            this.textBoxNovaCor.TabIndex = 3;
            // 
            // CadastrarCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 152);
            this.Controls.Add(this.textBoxNovaCor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonInserirCor);
            this.Name = "CadastrarCor";
            this.Text = "Cadastro Cor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInserirCor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNovaCor;
    }
}