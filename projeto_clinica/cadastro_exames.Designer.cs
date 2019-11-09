namespace projeto_clinica
{
    partial class cadastro_exames
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
            this.DescExa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valExa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "descrição do exame";
            // 
            // DescExa
            // 
            this.DescExa.Location = new System.Drawing.Point(120, 27);
            this.DescExa.Multiline = true;
            this.DescExa.Name = "DescExa";
            this.DescExa.Size = new System.Drawing.Size(182, 33);
            this.DescExa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "valor do exame ";
            // 
            // valExa
            // 
            this.valExa.Location = new System.Drawing.Point(120, 88);
            this.valExa.Name = "valExa";
            this.valExa.Size = new System.Drawing.Size(116, 20);
            this.valExa.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cadastro_exames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 160);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valExa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescExa);
            this.Controls.Add(this.label1);
            this.Name = "cadastro_exames";
            this.Text = "cadastro_exames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescExa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valExa;
        private System.Windows.Forms.Button button1;
    }
}