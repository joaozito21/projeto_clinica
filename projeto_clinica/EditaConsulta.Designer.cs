namespace projeto_clinica
{
    partial class EditaConsulta
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
            this.mascData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtNomeCli = new System.Windows.Forms.TextBox();
            this.edtNomeAni = new System.Windows.Forms.TextBox();
            this.edtNomeVet = new System.Windows.Forms.TextBox();
            this.edtMot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mascData
            // 
            this.mascData.Location = new System.Drawing.Point(120, 102);
            this.mascData.Mask = "00/00/0000";
            this.mascData.Name = "mascData";
            this.mascData.Size = new System.Drawing.Size(73, 20);
            this.mascData.TabIndex = 20;
            this.mascData.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "motivo da consulta";
            // 
            // edtNomeCli
            // 
            this.edtNomeCli.Location = new System.Drawing.Point(101, 22);
            this.edtNomeCli.Name = "edtNomeCli";
            this.edtNomeCli.Size = new System.Drawing.Size(247, 20);
            this.edtNomeCli.TabIndex = 18;
            // 
            // edtNomeAni
            // 
            this.edtNomeAni.Location = new System.Drawing.Point(101, 51);
            this.edtNomeAni.Name = "edtNomeAni";
            this.edtNomeAni.Size = new System.Drawing.Size(247, 20);
            this.edtNomeAni.TabIndex = 17;
            // 
            // edtNomeVet
            // 
            this.edtNomeVet.Location = new System.Drawing.Point(120, 77);
            this.edtNomeVet.Name = "edtNomeVet";
            this.edtNomeVet.Size = new System.Drawing.Size(228, 20);
            this.edtNomeVet.TabIndex = 16;
            // 
            // edtMot
            // 
            this.edtMot.Location = new System.Drawing.Point(120, 128);
            this.edtMot.Name = "edtMot";
            this.edtMot.Size = new System.Drawing.Size(228, 20);
            this.edtMot.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "data consulta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome do veterinario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome do animal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome do cliente";
            // 
            // EditaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mascData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtNomeCli);
            this.Controls.Add(this.edtNomeAni);
            this.Controls.Add(this.edtNomeVet);
            this.Controls.Add(this.edtMot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditaConsulta";
            this.Text = "EditaConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mascData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtNomeCli;
        private System.Windows.Forms.TextBox edtNomeAni;
        private System.Windows.Forms.TextBox edtNomeVet;
        private System.Windows.Forms.TextBox edtMot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}