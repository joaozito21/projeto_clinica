namespace projeto_clinica
{
    partial class EditaAnimal
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
            this.edtNomeANI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EdtEspAni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RacAni = new System.Windows.Forms.TextBox();
            this.MascData = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EdtNomeCli = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edtNomeANI
            // 
            this.edtNomeANI.Location = new System.Drawing.Point(101, 12);
            this.edtNomeANI.Name = "edtNomeANI";
            this.edtNomeANI.Size = new System.Drawing.Size(215, 20);
            this.edtNomeANI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Especie do animal";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // EdtEspAni
            // 
            this.EdtEspAni.Location = new System.Drawing.Point(120, 38);
            this.EdtEspAni.Name = "EdtEspAni";
            this.EdtEspAni.Size = new System.Drawing.Size(215, 20);
            this.EdtEspAni.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raça do animal";
            // 
            // RacAni
            // 
            this.RacAni.Location = new System.Drawing.Point(120, 72);
            this.RacAni.Name = "RacAni";
            this.RacAni.Size = new System.Drawing.Size(215, 20);
            this.RacAni.TabIndex = 4;
            // 
            // MascData
            // 
            this.MascData.Location = new System.Drawing.Point(120, 102);
            this.MascData.Mask = "00/00/0000";
            this.MascData.Name = "MascData";
            this.MascData.Size = new System.Drawing.Size(70, 20);
            this.MascData.TabIndex = 6;
            this.MascData.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome do Cliente";
            // 
            // EdtNomeCli
            // 
            this.EdtNomeCli.Location = new System.Drawing.Point(101, 139);
            this.EdtNomeCli.Name = "EdtNomeCli";
            this.EdtNomeCli.Size = new System.Drawing.Size(215, 20);
            this.EdtNomeCli.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // EditaAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 224);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EdtNomeCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MascData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RacAni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EdtEspAni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtNomeANI);
            this.Name = "EditaAnimal";
            this.Text = "EditaAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtNomeANI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdtEspAni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RacAni;
        private System.Windows.Forms.MaskedTextBox MascData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EdtNomeCli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}