namespace projeto_clinica
{
    partial class Consultas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtMot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mascData = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.edtNomeVet = new System.Windows.Forms.ComboBox();
            this.etdNomeCli = new System.Windows.Forms.ComboBox();
            this.edtNomeAni = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do animal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do veterinario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "data consulta";
            // 
            // edtMot
            // 
            this.edtMot.Location = new System.Drawing.Point(133, 128);
            this.edtMot.Name = "edtMot";
            this.edtMot.Size = new System.Drawing.Size(228, 20);
            this.edtMot.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "motivo da consulta";
            // 
            // mascData
            // 
            this.mascData.Location = new System.Drawing.Point(133, 102);
            this.mascData.Mask = "00/00/0000";
            this.mascData.Name = "mascData";
            this.mascData.Size = new System.Drawing.Size(73, 20);
            this.mascData.TabIndex = 9;
            this.mascData.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // edtNomeVet
            // 
            this.edtNomeVet.FormattingEnabled = true;
            this.edtNomeVet.Location = new System.Drawing.Point(133, 77);
            this.edtNomeVet.Name = "edtNomeVet";
            this.edtNomeVet.Size = new System.Drawing.Size(241, 21);
            this.edtNomeVet.TabIndex = 11;
            // 
            // etdNomeCli
            // 
            this.etdNomeCli.FormattingEnabled = true;
            this.etdNomeCli.Location = new System.Drawing.Point(114, 22);
            this.etdNomeCli.Name = "etdNomeCli";
            this.etdNomeCli.Size = new System.Drawing.Size(260, 21);
            this.etdNomeCli.TabIndex = 12;
            this.etdNomeCli.SelectedIndexChanged += new System.EventHandler(this.EtdNomeCli_SelectedIndexChanged);
            // 
            // edtNomeAni
            // 
            this.edtNomeAni.FormattingEnabled = true;
            this.edtNomeAni.Location = new System.Drawing.Point(124, 49);
            this.edtNomeAni.Name = "edtNomeAni";
            this.edtNomeAni.Size = new System.Drawing.Size(250, 21);
            this.edtNomeAni.TabIndex = 13;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 215);
            this.Controls.Add(this.edtNomeAni);
            this.Controls.Add(this.etdNomeCli);
            this.Controls.Add(this.edtNomeVet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mascData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtMot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtMot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mascData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox edtNomeVet;
        private System.Windows.Forms.ComboBox etdNomeCli;
        private System.Windows.Forms.ComboBox edtNomeAni;
    }
}