namespace Civil
{
    partial class Viewexistingsite
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
            this.newsiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cividatanewDataSet = new Civil.cividatanewDataSet();
            this.newsiteTableAdapter = new Civil.cividatanewDataSetTableAdapters.newsiteTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.cividatanewDataSet8 = new Civil.cividatanewDataSet8();
            this.newsiteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newsiteTableAdapter1 = new Civil.cividatanewDataSet8TableAdapters.newsiteTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.siteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitenameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteaddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteareaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.architecturenameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constructiontypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetocompleteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalapproximatecostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.newsiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cividatanewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cividatanewDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsiteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // newsiteBindingSource
            // 
            this.newsiteBindingSource.DataMember = "newsite";
            this.newsiteBindingSource.DataSource = this.cividatanewDataSet;
            // 
            // cividatanewDataSet
            // 
            this.cividatanewDataSet.DataSetName = "cividatanewDataSet";
            this.cividatanewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newsiteTableAdapter
            // 
            this.newsiteTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cividatanewDataSet8
            // 
            this.cividatanewDataSet8.DataSetName = "cividatanewDataSet8";
            this.cividatanewDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newsiteBindingSource1
            // 
            this.newsiteBindingSource1.DataMember = "newsite";
            this.newsiteBindingSource1.DataSource = this.cividatanewDataSet8;
            // 
            // newsiteTableAdapter1
            // 
            this.newsiteTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siteidDataGridViewTextBoxColumn,
            this.sitenameDataGridViewTextBoxColumn1,
            this.siteaddressDataGridViewTextBoxColumn1,
            this.siteareaDataGridViewTextBoxColumn1,
            this.architecturenameDataGridViewTextBoxColumn1,
            this.constructiontypeDataGridViewTextBoxColumn1,
            this.timetocompleteDataGridViewTextBoxColumn1,
            this.totalapproximatecostDataGridViewTextBoxColumn1,
            this.startdateDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.newsiteBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(-94, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1043, 383);
            this.dataGridView2.TabIndex = 3;
            // 
            // siteidDataGridViewTextBoxColumn
            // 
            this.siteidDataGridViewTextBoxColumn.DataPropertyName = "siteid";
            this.siteidDataGridViewTextBoxColumn.HeaderText = "siteid";
            this.siteidDataGridViewTextBoxColumn.Name = "siteidDataGridViewTextBoxColumn";
            // 
            // sitenameDataGridViewTextBoxColumn1
            // 
            this.sitenameDataGridViewTextBoxColumn1.DataPropertyName = "sitename";
            this.sitenameDataGridViewTextBoxColumn1.HeaderText = "sitename";
            this.sitenameDataGridViewTextBoxColumn1.Name = "sitenameDataGridViewTextBoxColumn1";
            // 
            // siteaddressDataGridViewTextBoxColumn1
            // 
            this.siteaddressDataGridViewTextBoxColumn1.DataPropertyName = "siteaddress";
            this.siteaddressDataGridViewTextBoxColumn1.HeaderText = "siteaddress";
            this.siteaddressDataGridViewTextBoxColumn1.Name = "siteaddressDataGridViewTextBoxColumn1";
            // 
            // siteareaDataGridViewTextBoxColumn1
            // 
            this.siteareaDataGridViewTextBoxColumn1.DataPropertyName = "sitearea";
            this.siteareaDataGridViewTextBoxColumn1.HeaderText = "sitearea";
            this.siteareaDataGridViewTextBoxColumn1.Name = "siteareaDataGridViewTextBoxColumn1";
            // 
            // architecturenameDataGridViewTextBoxColumn1
            // 
            this.architecturenameDataGridViewTextBoxColumn1.DataPropertyName = "architecturename";
            this.architecturenameDataGridViewTextBoxColumn1.HeaderText = "architecturename";
            this.architecturenameDataGridViewTextBoxColumn1.Name = "architecturenameDataGridViewTextBoxColumn1";
            // 
            // constructiontypeDataGridViewTextBoxColumn1
            // 
            this.constructiontypeDataGridViewTextBoxColumn1.DataPropertyName = "constructiontype";
            this.constructiontypeDataGridViewTextBoxColumn1.HeaderText = "constructiontype";
            this.constructiontypeDataGridViewTextBoxColumn1.Name = "constructiontypeDataGridViewTextBoxColumn1";
            // 
            // timetocompleteDataGridViewTextBoxColumn1
            // 
            this.timetocompleteDataGridViewTextBoxColumn1.DataPropertyName = "timetocomplete";
            this.timetocompleteDataGridViewTextBoxColumn1.HeaderText = "timetocomplete";
            this.timetocompleteDataGridViewTextBoxColumn1.Name = "timetocompleteDataGridViewTextBoxColumn1";
            // 
            // totalapproximatecostDataGridViewTextBoxColumn1
            // 
            this.totalapproximatecostDataGridViewTextBoxColumn1.DataPropertyName = "totalapproximatecost";
            this.totalapproximatecostDataGridViewTextBoxColumn1.HeaderText = "totalapproximatecost";
            this.totalapproximatecostDataGridViewTextBoxColumn1.Name = "totalapproximatecostDataGridViewTextBoxColumn1";
            // 
            // startdateDataGridViewTextBoxColumn1
            // 
            this.startdateDataGridViewTextBoxColumn1.DataPropertyName = "startdate";
            this.startdateDataGridViewTextBoxColumn1.HeaderText = "startdate";
            this.startdateDataGridViewTextBoxColumn1.Name = "startdateDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // Viewexistingsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 512);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Name = "Viewexistingsite";
            this.Text = "Viewexistingsite";
            this.Load += new System.EventHandler(this.Viewexistingsite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newsiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cividatanewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cividatanewDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsiteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private cividatanewDataSet cividatanewDataSet;
        private System.Windows.Forms.BindingSource newsiteBindingSource;
        private cividatanewDataSetTableAdapters.newsiteTableAdapter newsiteTableAdapter;
        private System.Windows.Forms.Button button2;
        private cividatanewDataSet8 cividatanewDataSet8;
        private System.Windows.Forms.BindingSource newsiteBindingSource1;
        private cividatanewDataSet8TableAdapters.newsiteTableAdapter newsiteTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitenameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteaddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteareaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn architecturenameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn constructiontypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timetocompleteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalapproximatecostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
    }
}