namespace projeto_clinica
{
    partial class EditarCliente
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
            this.label7 = new System.Windows.Forms.Label();
            this.mask = new System.Windows.Forms.MaskedTextBox();
            this.mascData = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtend = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.edtcidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Telefone";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // mask
            // 
            this.mask.Location = new System.Drawing.Point(159, 169);
            this.mask.Mask = "(99) 00000-0000";
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(93, 20);
            this.mask.TabIndex = 28;
            this.mask.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mask_MaskInputRejected);
            // 
            // mascData
            // 
            this.mascData.Location = new System.Drawing.Point(159, 143);
            this.mascData.Mask = "00/00/0000";
            this.mascData.Name = "mascData";
            this.mascData.Size = new System.Drawing.Size(70, 20);
            this.mascData.TabIndex = 27;
            this.mascData.ValidatingType = typeof(System.DateTime);
            this.mascData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MascData_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Data de nascimento";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // edtend
            // 
            this.edtend.Location = new System.Drawing.Point(110, 117);
            this.edtend.Name = "edtend";
            this.edtend.Size = new System.Drawing.Size(266, 20);
            this.edtend.TabIndex = 25;
            this.edtend.TextChanged += new System.EventHandler(this.Edtend_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Endereço";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(255, 90);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 23;
            this.cmbGenero.Text = "selecione genero";
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.CmbGenero_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Genero";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Estado";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
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
            this.cmbEstado.Location = new System.Drawing.Point(93, 90);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(111, 21);
            this.cmbEstado.TabIndex = 16;
            this.cmbEstado.Text = "seleciona estado";
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // edtcidade
            // 
            this.edtcidade.Location = new System.Drawing.Point(92, 59);
            this.edtcidade.Name = "edtcidade";
            this.edtcidade.Size = new System.Drawing.Size(284, 20);
            this.edtcidade.TabIndex = 20;
            this.edtcidade.TextChanged += new System.EventHandler(this.Edtcidade_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "cidade";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(88, 28);
            this.edtNome.MaxLength = 70;
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(288, 20);
            this.edtNome.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 255);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mask);
            this.Controls.Add(this.mascData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.edtcidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtNome);
            this.Controls.Add(this.label1);
            this.Name = "EditarCliente";
            this.Text = "EditarCliente";
            this.Load += new System.EventHandler(this.EditarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mask;
        private System.Windows.Forms.MaskedTextBox mascData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox edtcidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}