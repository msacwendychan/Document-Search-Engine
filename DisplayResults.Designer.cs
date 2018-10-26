namespace a
{
    partial class DisplayResults
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
            this.ResultsShow2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextPage = new System.Windows.Forms.Button();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.Instruction = new System.Windows.Forms.Label();
            this.PageLable = new System.Windows.Forms.Label();
            this.PageNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsShow2)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsShow2
            // 
            this.ResultsShow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsShow2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.ResultsShow2.Location = new System.Drawing.Point(0, 82);
            this.ResultsShow2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResultsShow2.Name = "ResultsShow2";
            this.ResultsShow2.Size = new System.Drawing.Size(804, 294);
            this.ResultsShow2.TabIndex = 0;
            this.ResultsShow2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Title";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Author";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bibliographic";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Abstract";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NextPage
            // 
            this.NextPage.Location = new System.Drawing.Point(659, 37);
            this.NextPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(113, 27);
            this.NextPage.TabIndex = 1;
            this.NextPage.Text = "Next Page";
            this.NextPage.UseVisualStyleBackColor = true;
            this.NextPage.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousPage
            // 
            this.PreviousPage.Location = new System.Drawing.Point(466, 38);
            this.PreviousPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(113, 27);
            this.PreviousPage.TabIndex = 2;
            this.PreviousPage.Text = "Previous Page";
            this.PreviousPage.UseVisualStyleBackColor = true;
            this.PreviousPage.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // Instruction
            // 
            this.Instruction.AutoSize = true;
            this.Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruction.Location = new System.Drawing.Point(13, 37);
            this.Instruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(331, 24);
            this.Instruction.TabIndex = 3;
            this.Instruction.Text = "Click each row to show the full abstract";
            this.Instruction.Click += new System.EventHandler(this.Instruction_Click);
            // 
            // PageLable
            // 
            this.PageLable.AutoSize = true;
            this.PageLable.Location = new System.Drawing.Point(591, 44);
            this.PageLable.Name = "PageLable";
            this.PageLable.Size = new System.Drawing.Size(34, 15);
            this.PageLable.TabIndex = 4;
            this.PageLable.Text = "Page";
            // 
            // PageNum
            // 
            this.PageNum.AutoSize = true;
            this.PageNum.Location = new System.Drawing.Point(634, 44);
            this.PageNum.Name = "PageNum";
            this.PageNum.Size = new System.Drawing.Size(14, 15);
            this.PageNum.TabIndex = 5;
            this.PageNum.Text = "1";
            this.PageNum.Click += new System.EventHandler(this.PageNum_Click);
            // 
            // DisplayResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 377);
            this.Controls.Add(this.PageNum);
            this.Controls.Add(this.PageLable);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.PreviousPage);
            this.Controls.Add(this.NextPage);
            this.Controls.Add(this.ResultsShow2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "DisplayResults";
            this.Text = "Search Results";
            this.Load += new System.EventHandler(this.DisplayResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsShow2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultsShow2;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.Button PreviousPage;
        private System.Windows.Forms.Label Instruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label PageLable;
        private System.Windows.Forms.Label PageNum;

    }
}