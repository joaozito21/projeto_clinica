namespace projeto_clinica
{
    partial class relatorioMes
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
            this.projeto_linguagemDataSet2 = new projeto_clinica.projeto_linguagemDataSet2();
            this.relatPagExaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatPagExaTableAdapter = new projeto_clinica.projeto_linguagemDataSet2TableAdapters.relatPagExaTableAdapter();
            this.formaDePagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDaFormaDePagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_linguagemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatPagExaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formaDePagamentoDataGridViewTextBoxColumn,
            this.dataDaFormaDePagamentoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.relatPagExaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // projeto_linguagemDataSet2
            // 
            this.projeto_linguagemDataSet2.DataSetName = "projeto_linguagemDataSet2";
            this.projeto_linguagemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatPagExaBindingSource
            // 
            this.relatPagExaBindingSource.DataMember = "relatPagExa";
            this.relatPagExaBindingSource.DataSource = this.projeto_linguagemDataSet2;
            // 
            // relatPagExaTableAdapter
            // 
            this.relatPagExaTableAdapter.ClearBeforeFill = true;
            // 
            // formaDePagamentoDataGridViewTextBoxColumn
            // 
            this.formaDePagamentoDataGridViewTextBoxColumn.DataPropertyName = "forma de pagamento";
            this.formaDePagamentoDataGridViewTextBoxColumn.HeaderText = "forma de pagamento";
            this.formaDePagamentoDataGridViewTextBoxColumn.Name = "formaDePagamentoDataGridViewTextBoxColumn";
            this.formaDePagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDaFormaDePagamentoDataGridViewTextBoxColumn
            // 
            this.dataDaFormaDePagamentoDataGridViewTextBoxColumn.DataPropertyName = "data da forma de pagamento";
            this.dataDaFormaDePagamentoDataGridViewTextBoxColumn.HeaderText = "data da forma de pagamento";
            this.dataDaFormaDePagamentoDataGridViewTextBoxColumn.Name = "dataDaFormaDePagamentoDataGridViewTextBoxColumn";
            this.dataDaFormaDePagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor ";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor ";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relatorioMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 294);
            this.Controls.Add(this.dataGridView1);
            this.Name = "relatorioMes";
            this.Text = "relatorioMes";
            this.Load += new System.EventHandler(this.RelatorioMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeto_linguagemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatPagExaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private projeto_linguagemDataSet2 projeto_linguagemDataSet2;
        private System.Windows.Forms.BindingSource relatPagExaBindingSource;
        private projeto_linguagemDataSet2TableAdapters.relatPagExaTableAdapter relatPagExaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaDePagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDaFormaDePagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}