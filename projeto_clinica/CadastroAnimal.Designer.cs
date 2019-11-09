namespace projeto_clinica
{
    partial class CadastroAnimal
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
            this.label1 = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.edtEsp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EdtRac = new System.Windows.Forms.TextBox();
            this.mascData = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do animal";
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(101, 17);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(201, 20);
            this.edtNome.TabIndex = 1;
            // 
            // edtEsp
            // 
            this.edtEsp.Location = new System.Drawing.Point(110, 52);
            this.edtEsp.Name = "edtEsp";
            this.edtEsp.Size = new System.Drawing.Size(163, 20);
            this.edtEsp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "especie do animal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Raça do animal";
            // 
            // EdtRac
            // 
            this.EdtRac.Location = new System.Drawing.Point(101, 85);
            this.EdtRac.Name = "EdtRac";
            this.EdtRac.Size = new System.Drawing.Size(172, 20);
            this.EdtRac.TabIndex = 5;
            // 
            // mascData
            // 
            this.mascData.Location = new System.Drawing.Point(111, 120);
            this.mascData.Mask = "00/00/0000";
            this.mascData.Name = "mascData";
            this.mascData.Size = new System.Drawing.Size(71, 20);
            this.mascData.TabIndex = 12;
            this.mascData.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome do cliente";
            // 
            // edtCli
            // 
            this.edtCli.Location = new System.Drawing.Point(118, 150);
            this.edtCli.Name = "edtCli";
            this.edtCli.Size = new System.Drawing.Size(172, 20);
            this.edtCli.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "data de nascimento";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CadastroAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 216);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mascData);
            this.Controls.Add(this.EdtRac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtEsp);
            this.Controls.Add(this.edtNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAnimal";
            this.Text = "CadastroAmimal";
            this.Load += new System.EventHandler(this.CadastroAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.TextBox edtEsp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EdtRac;
        private System.Windows.Forms.MaskedTextBox mascData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}