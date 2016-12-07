namespace FrontEnd
{
    partial class CadastrarAnimal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAnimal));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAnimalNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEspecie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRaça = new System.Windows.Forms.ComboBox();
            this.buttonNovaEspecie = new System.Windows.Forms.Button();
            this.ButtonNovaRaca = new System.Windows.Forms.Button();
            this.corBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.doseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCor = new System.Windows.Forms.ComboBox();
            this.ButtonNovaCor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.corBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxAnimalNome
            // 
            this.textBoxAnimalNome.Location = new System.Drawing.Point(63, 28);
            this.textBoxAnimalNome.Name = "textBoxAnimalNome";
            this.textBoxAnimalNome.Size = new System.Drawing.Size(209, 20);
            this.textBoxAnimalNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade";
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(63, 68);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(40, 20);
            this.textBoxIdade.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data do Cadastro";
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(63, 110);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(65, 20);
            this.textBoxPeso.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Peso";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(109, 142);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(88, 20);
            this.textBoxData.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Espécie";
            // 
            // comboBoxEspecie
            // 
            this.comboBoxEspecie.DisplayMember = "id";
            this.comboBoxEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEspecie.FormattingEnabled = true;
            this.comboBoxEspecie.Location = new System.Drawing.Point(278, 67);
            this.comboBoxEspecie.Name = "comboBoxEspecie";
            this.comboBoxEspecie.Size = new System.Drawing.Size(141, 21);
            this.comboBoxEspecie.TabIndex = 11;
            this.comboBoxEspecie.ValueMember = "id";
            this.comboBoxEspecie.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspecie_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Raça";
            // 
            // comboBoxRaça
            // 
            this.comboBoxRaça.DisplayMember = "id";
            this.comboBoxRaça.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRaça.FormattingEnabled = true;
            this.comboBoxRaça.Location = new System.Drawing.Point(278, 102);
            this.comboBoxRaça.Name = "comboBoxRaça";
            this.comboBoxRaça.Size = new System.Drawing.Size(141, 21);
            this.comboBoxRaça.TabIndex = 13;
            this.comboBoxRaça.ValueMember = "id";
            this.comboBoxRaça.SelectedIndexChanged += new System.EventHandler(this.comboBoxRaça_SelectedIndexChanged);
            // 
            // buttonNovaEspecie
            // 
            this.buttonNovaEspecie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNovaEspecie.BackgroundImage")));
            this.buttonNovaEspecie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNovaEspecie.Location = new System.Drawing.Point(425, 67);
            this.buttonNovaEspecie.Name = "buttonNovaEspecie";
            this.buttonNovaEspecie.Size = new System.Drawing.Size(25, 23);
            this.buttonNovaEspecie.TabIndex = 14;
            this.buttonNovaEspecie.UseVisualStyleBackColor = true;
            this.buttonNovaEspecie.Click += new System.EventHandler(this.buttonNovaEspecie_Click);
            // 
            // ButtonNovaRaca
            // 
            this.ButtonNovaRaca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonNovaRaca.BackgroundImage")));
            this.ButtonNovaRaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonNovaRaca.Location = new System.Drawing.Point(425, 102);
            this.ButtonNovaRaca.Name = "ButtonNovaRaca";
            this.ButtonNovaRaca.Size = new System.Drawing.Size(25, 23);
            this.ButtonNovaRaca.TabIndex = 15;
            this.ButtonNovaRaca.UseVisualStyleBackColor = true;
            this.ButtonNovaRaca.Click += new System.EventHandler(this.ButtonNovaRaca_Click);
            // 
            // corBindingSource
            // 
            this.corBindingSource.DataMember = "cor";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(137, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 39);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(264, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 39);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cancelar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Salvar";
            // 
            // doseBindingSource
            // 
            this.doseBindingSource.DataMember = "dose";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cor";
            // 
            // comboBoxCor
            // 
            this.comboBoxCor.DisplayMember = "id";
            this.comboBoxCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCor.FormattingEnabled = true;
            this.comboBoxCor.Location = new System.Drawing.Point(278, 142);
            this.comboBoxCor.Name = "comboBoxCor";
            this.comboBoxCor.Size = new System.Drawing.Size(141, 21);
            this.comboBoxCor.TabIndex = 24;
            this.comboBoxCor.ValueMember = "id";
            this.comboBoxCor.SelectedIndexChanged += new System.EventHandler(this.comboBoxCor_SelectedIndexChanged);
            // 
            // ButtonNovaCor
            // 
            this.ButtonNovaCor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonNovaCor.BackgroundImage")));
            this.ButtonNovaCor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonNovaCor.Location = new System.Drawing.Point(425, 142);
            this.ButtonNovaCor.Name = "ButtonNovaCor";
            this.ButtonNovaCor.Size = new System.Drawing.Size(25, 23);
            this.ButtonNovaCor.TabIndex = 25;
            this.ButtonNovaCor.UseVisualStyleBackColor = true;
            this.ButtonNovaCor.Click += new System.EventHandler(this.ButtonNovaCor_Click);
            // 
            // CadastrarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 266);
            this.Controls.Add(this.ButtonNovaCor);
            this.Controls.Add(this.comboBoxCor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonNovaRaca);
            this.Controls.Add(this.buttonNovaEspecie);
            this.Controls.Add(this.comboBoxRaça);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxEspecie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAnimalNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inserir Animal";
            this.Load += new System.EventHandler(this.CadastrarAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.corBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAnimalNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEspecie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRaça;
        private System.Windows.Forms.Button buttonNovaEspecie;
        private System.Windows.Forms.Button ButtonNovaRaca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource doseBindingSource;
        private System.Windows.Forms.BindingSource corBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCor;
        private System.Windows.Forms.Button ButtonNovaCor;
    }
}