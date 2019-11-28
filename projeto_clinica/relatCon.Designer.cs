namespace projeto_clinica
{
    partial class relatCon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projeto_linguagemDataSet3 = new projeto_clinica.projeto_linguagemDataSet3();
            this.relatPagConBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatPagConTableAdapter = new projeto_clinica.projeto_linguagemDataSet3TableAdapters.relatPagConTableAdapter();
            this.formaDePagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDaFormaDePagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_linguagemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatPagConBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formaDePagamentoDataGridViewTextBoxColumn,
            this.dataDaFormaDePagamentoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.relatPagConBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // projeto_linguagemDataSet3
            // 
            this.projeto_linguagemDataSet3.DataSetName = "projeto_linguagemDataSet3";
            this.projeto_linguagemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatPagConBindingSource
            // 
            this.relatPagConBindingSource.DataMember = "relatPagCon";
            this.relatPagConBindingSource.DataSource = this.projeto_linguagemDataSet3;
            // 
            // relatPagConTableAdapter
            // 
            this.relatPagConTableAdapter.ClearBeforeFill = true;
            // 
            // formaDePagamentoDataGridViewTextBoxColumn
            // 
            this.formaDePagamentoDataGridViewTextBoxColumn.DataPropertyName = "forma de pagamento";
            this.formaDePagamentoDataGridViewTextBoxColumn.HeaderText = "forma de pagamento";
            this.formaDePagamentoDataGridViewTextBoxColumn.Name = "formaDePagamentoDataGridViewTextBoxColumn";
            // 
            // dataDaFormaDePagamentoDataGridViewTextBoxColumn
            // 
            this.dataDaFormaDePagamentoDataGridViewTextBoxColumn.DataPropertyName = "data da forma de pagamento";
            this.dataDaFormaDePagamentoDataGridViewTextBoxColumn.HeaderText = "data da forma de pagamento";
            this.dataDaFormaDePagamentoDataGridViewTextBoxColumn.Name = "dataDaFormaDePagamentoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor ";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor ";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // relatCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 298);
            this.Controls.Add(this.dataGridView1);
            this.Name = "relatCon";
            this.Text = "relatCon";
            this.Load += new System.EventHandler(this.RelatCon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_linguagemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatPagConBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private projeto_linguagemDataSet3 projeto_linguagemDataSet3;
        private System.Windows.Forms.BindingSource relatPagConBindingSource;
        private projeto_linguagemDataSet3TableAdapters.relatPagConTableAdapter relatPagConTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaDePagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDaFormaDePagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}