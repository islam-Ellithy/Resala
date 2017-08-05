namespace ResalaSystem.Question
{
    partial class ShowQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resalaDataSet3 = new ResalaSystem.resalaDataSet3();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resalaDataSet1 = new ResalaSystem.resalaDataSet1();
            this.resalaDataSet = new ResalaSystem.resalaDataSet();
            this.resalaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTableAdapter = new ResalaSystem.resalaDataSet1TableAdapters.questionTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choice_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resalaDataSet2 = new ResalaSystem.resalaDataSet2();
            this.choiceTableAdapter = new ResalaSystem.resalaDataSet2TableAdapters.choiceTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.answerTableAdapter = new ResalaSystem.resalaDataSet3TableAdapters.answerTableAdapter();
            this.answer_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questiondescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resalaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resalaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resalaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resalaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resalaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.questiondescDataGridViewTextBoxColumn,
            this.courseidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.questionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 115);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // resalaDataSet3
            // 
            this.resalaDataSet3.DataSetName = "resalaDataSet3";
            this.resalaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataMember = "question";
            this.questionBindingSource.DataSource = this.resalaDataSet1;
            // 
            // resalaDataSet1
            // 
            this.resalaDataSet1.DataSetName = "resalaDataSet1";
            this.resalaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resalaDataSet
            // 
            this.resalaDataSet.DataSetName = "resalaDataSet";
            this.resalaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resalaDataSetBindingSource
            // 
            this.resalaDataSetBindingSource.DataSource = this.resalaDataSet;
            this.resalaDataSetBindingSource.Position = 0;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.choice_desc,
            this.question_id});
            this.dataGridView2.DataSource = this.choiceBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 124);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(317, 64);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // choice_desc
            // 
            this.choice_desc.DataPropertyName = "choice_desc";
            this.choice_desc.HeaderText = "choice_desc";
            this.choice_desc.Name = "choice_desc";
            // 
            // question_id
            // 
            this.question_id.DataPropertyName = "question_id";
            this.question_id.HeaderText = "question_id";
            this.question_id.Name = "question_id";
            // 
            // choiceBindingSource
            // 
            this.choiceBindingSource.DataMember = "choice";
            this.choiceBindingSource.DataSource = this.resalaDataSet2;
            // 
            // resalaDataSet2
            // 
            this.resalaDataSet2.DataSetName = "resalaDataSet2";
            this.resalaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // choiceTableAdapter
            // 
            this.choiceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.answer_desc});
            this.dataGridView3.DataSource = this.answerBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 213);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(317, 64);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // answerBindingSource
            // 
            this.answerBindingSource.DataMember = "answer";
            this.answerBindingSource.DataSource = this.resalaDataSet3;
            // 
            // answerTableAdapter
            // 
            this.answerTableAdapter.ClearBeforeFill = true;
            // 
            // answer_desc
            // 
            this.answer_desc.DataPropertyName = "answer_desc";
            this.answer_desc.HeaderText = "answer_desc";
            this.answer_desc.Name = "answer_desc";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questiondescDataGridViewTextBoxColumn
            // 
            this.questiondescDataGridViewTextBoxColumn.DataPropertyName = "question_desc";
            this.questiondescDataGridViewTextBoxColumn.HeaderText = "question_desc";
            this.questiondescDataGridViewTextBoxColumn.Name = "questiondescDataGridViewTextBoxColumn";
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            // 
            // ShowQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowQuestion";
            this.Size = new System.Drawing.Size(437, 299);
            this.Load += new System.EventHandler(this.UpdateQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resalaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resalaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resalaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resalaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resalaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private resalaDataSet1 resalaDataSet1;
        private resalaDataSet resalaDataSet;
        private System.Windows.Forms.BindingSource resalaDataSetBindingSource;
        private resalaDataSet1TableAdapters.questionTableAdapter questionTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource choiceBindingSource;
        private resalaDataSet2 resalaDataSet2;
        private resalaDataSet2TableAdapters.choiceTableAdapter choiceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource answerBindingSource;
        private resalaDataSet3 resalaDataSet3;
        private resalaDataSet3TableAdapters.answerTableAdapter answerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn choice_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn question_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questiondescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer_desc;
    }
}
