namespace TestInsertView
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabelaantetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proba_transareDataSet = new TestInsertView.proba_transareDataSet();
            this.tabela_antetTableAdapter = new TestInsertView.proba_transareDataSetTableAdapters.tabela_antetTableAdapter();
            this.nrdocDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idantetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpartenerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proba_transareDataSet1 = new TestInsertView.proba_transareDataSet1();
            this.view_DocumentTableAdapter = new TestInsertView.proba_transareDataSet1TableAdapters.View_DocumentTableAdapter();
            this.nrdocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpartenerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaantetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrdocDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idpartenerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelaantetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(443, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(295, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "View";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrdocDataGridViewTextBoxColumn1,
            this.idantetDataGridViewTextBoxColumn1,
            this.serieDataGridViewTextBoxColumn1,
            this.dataDataGridViewTextBoxColumn1,
            this.idpartenerDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.viewDocumentBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(62, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(317, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabelaantetBindingSource
            // 
            this.tabelaantetBindingSource.DataMember = "tabela_antet";
            this.tabelaantetBindingSource.DataSource = this.proba_transareDataSet;
            // 
            // proba_transareDataSet
            // 
            this.proba_transareDataSet.DataSetName = "proba_transareDataSet";
            this.proba_transareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabela_antetTableAdapter
            // 
            this.tabela_antetTableAdapter.ClearBeforeFill = true;
            // 
            // nrdocDataGridViewTextBoxColumn1
            // 
            this.nrdocDataGridViewTextBoxColumn1.DataPropertyName = "nr_doc";
            this.nrdocDataGridViewTextBoxColumn1.HeaderText = "nr_doc";
            this.nrdocDataGridViewTextBoxColumn1.Name = "nrdocDataGridViewTextBoxColumn1";
            // 
            // idantetDataGridViewTextBoxColumn1
            // 
            this.idantetDataGridViewTextBoxColumn1.DataPropertyName = "id_antet";
            this.idantetDataGridViewTextBoxColumn1.HeaderText = "id_antet";
            this.idantetDataGridViewTextBoxColumn1.Name = "idantetDataGridViewTextBoxColumn1";
            // 
            // serieDataGridViewTextBoxColumn1
            // 
            this.serieDataGridViewTextBoxColumn1.DataPropertyName = "serie";
            this.serieDataGridViewTextBoxColumn1.HeaderText = "serie";
            this.serieDataGridViewTextBoxColumn1.Name = "serieDataGridViewTextBoxColumn1";
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            // 
            // idpartenerDataGridViewTextBoxColumn1
            // 
            this.idpartenerDataGridViewTextBoxColumn1.DataPropertyName = "id_partener";
            this.idpartenerDataGridViewTextBoxColumn1.HeaderText = "id_partener";
            this.idpartenerDataGridViewTextBoxColumn1.Name = "idpartenerDataGridViewTextBoxColumn1";
            // 
            // viewDocumentBindingSource
            // 
            this.viewDocumentBindingSource.DataMember = "View_Document";
            this.viewDocumentBindingSource.DataSource = this.proba_transareDataSet1;
            // 
            // proba_transareDataSet1
            // 
            this.proba_transareDataSet1.DataSetName = "proba_transareDataSet1";
            this.proba_transareDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_DocumentTableAdapter
            // 
            this.view_DocumentTableAdapter.ClearBeforeFill = true;
            // 
            // nrdocDataGridViewTextBoxColumn
            // 
            this.nrdocDataGridViewTextBoxColumn.DataPropertyName = "nr_doc";
            this.nrdocDataGridViewTextBoxColumn.HeaderText = "nr_doc";
            this.nrdocDataGridViewTextBoxColumn.Name = "nrdocDataGridViewTextBoxColumn";
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // idpartenerDataGridViewTextBoxColumn
            // 
            this.idpartenerDataGridViewTextBoxColumn.DataPropertyName = "id_partener";
            this.idpartenerDataGridViewTextBoxColumn.HeaderText = "id_partener";
            this.idpartenerDataGridViewTextBoxColumn.Name = "idpartenerDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaantetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private proba_transareDataSet proba_transareDataSet;
        private System.Windows.Forms.BindingSource tabelaantetBindingSource;
        private proba_transareDataSetTableAdapters.tabela_antetTableAdapter tabela_antetTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private proba_transareDataSet1 proba_transareDataSet1;
        private System.Windows.Forms.BindingSource viewDocumentBindingSource;
        private proba_transareDataSet1TableAdapters.View_DocumentTableAdapter view_DocumentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrdocDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idantetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpartenerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrdocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpartenerDataGridViewTextBoxColumn;
    }
}

