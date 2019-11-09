namespace projeto_clinica
{
    partial class EditarVeterinario
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
            this.label7 = new System.Windows.Forms.Label();
            this.mask = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mascData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtend = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.edtcidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtCRMV = new System.Windows.Forms.TextBox();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.lbCRMV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 32);
            this.button1.TabIndex = 50;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Telefone";
            // 
            // mask
            // 
            this.mask.Location = new System.Drawing.Point(159, 198);
            this.mask.Mask = "(99) 00000-0000";
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(93, 20);
            this.mask.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Data de nascimento";
            // 
            // mascData
            // 
            this.mascData.Location = new System.Drawing.Point(159, 172);
            this.mascData.Mask = "00/00/0000";
            this.mascData.Name = "mascData";
            this.mascData.Size = new System.Drawing.Size(70, 20);
            this.mascData.TabIndex = 46;
            this.mascData.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Endereço";
            // 
            // edtend
            // 
            this.edtend.Location = new System.Drawing.Point(124, 146);
            this.edtend.Name = "edtend";
            this.edtend.Size = new System.Drawing.Size(266, 20);
            this.edtend.TabIndex = 44;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(322, 119);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 43;
            this.cmbGenero.Text = "selecione genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC",
            "AM",
            "AL",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbEstado.Location = new System.Drawing.Point(135, 116);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(111, 21);
            this.cmbEstado.TabIndex = 40;
            this.cmbEstado.Text = "seleciona estado";
            // 
            // edtcidade
            // 
            this.edtcidade.Location = new System.Drawing.Point(135, 85);
            this.edtcidade.Name = "edtcidade";
            this.edtcidade.Size = new System.Drawing.Size(284, 20);
            this.edtcidade.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cidade";
            // 
            // edtCRMV
            // 
            this.edtCRMV.Location = new System.Drawing.Point(135, 50);
            this.edtCRMV.Name = "edtCRMV";
            this.edtCRMV.Size = new System.Drawing.Size(294, 20);
            this.edtCRMV.TabIndex = 37;
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(135, 21);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(294, 20);
            this.edtNome.TabIndex = 36;
            // 
            // lbCRMV
            // 
            this.lbCRMV.AutoSize = true;
            this.lbCRMV.Location = new System.Drawing.Point(37, 57);
            this.lbCRMV.Name = "lbCRMV";
            this.lbCRMV.Size = new System.Drawing.Size(38, 13);
            this.lbCRMV.TabIndex = 35;
            this.lbCRMV.Text = "CRMV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nome do veterinario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 31);
            this.button2.TabIndex = 51;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // EditarVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mascData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtend);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.edtcidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtCRMV);
            this.Controls.Add(this.edtNome);
            this.Controls.Add(this.lbCRMV);
            this.Controls.Add(this.label1);
            this.Name = "EditarVeterinario";
            this.Text = "EditarVeterinario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mascData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtend;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox edtcidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtCRMV;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label lbCRMV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}