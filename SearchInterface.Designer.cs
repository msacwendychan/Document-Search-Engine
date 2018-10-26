namespace a
{
    partial class SearchInterface
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
            this.CollectionButton = new System.Windows.Forms.Button();
            this.CollectionLable = new System.Windows.Forms.Label();
            this.CollectionBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SetIndexButton = new System.Windows.Forms.Button();
            this.IndexSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.IndexTime = new System.Windows.Forms.Label();
            this.ShowIndexTime = new System.Windows.Forms.Label();
            this.InformationNeed = new System.Windows.Forms.Label();
            this.enterInformationNeed = new System.Windows.Forms.TextBox();
            this.parsedQuery = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.queryShow = new System.Windows.Forms.TextBox();
            this.searchTime = new System.Windows.Forms.Label();
            this.searchTimeShow = new System.Windows.Forms.Label();
            this.NumbersOfDocuments = new System.Windows.Forms.Label();
            this.NumbersOfDocumentsShow = new System.Windows.Forms.Label();
            this.ShowResults = new System.Windows.Forms.Button();
            this.SaveResults = new System.Windows.Forms.Button();
            this.TextBox_indentifier = new System.Windows.Forms.TextBox();
            this.SavingDirectory = new System.Windows.Forms.Button();
            this.ResultsSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FileDirectory = new System.Windows.Forms.Label();
            this.SaveFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Clear = new System.Windows.Forms.Button();
            this.AnalyserComboBox = new System.Windows.Forms.ComboBox();
            this.CreateIndexButton = new System.Windows.Forms.Button();
            this.preProcessingCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CollectionButton
            // 
            this.CollectionButton.Location = new System.Drawing.Point(19, 41);
            this.CollectionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CollectionButton.Name = "CollectionButton";
            this.CollectionButton.Size = new System.Drawing.Size(160, 28);
            this.CollectionButton.TabIndex = 0;
            this.CollectionButton.Text = "Choose Collection";
            this.CollectionButton.UseVisualStyleBackColor = true;
            this.CollectionButton.Click += new System.EventHandler(this.CollectionButton_Click);
            // 
            // CollectionLable
            // 
            this.CollectionLable.AutoSize = true;
            this.CollectionLable.Location = new System.Drawing.Point(206, 48);
            this.CollectionLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CollectionLable.Name = "CollectionLable";
            this.CollectionLable.Size = new System.Drawing.Size(192, 15);
            this.CollectionLable.TabIndex = 2;
            this.CollectionLable.Text = "Display collection directory path";
            this.CollectionLable.Click += new System.EventHandler(this.collectionLable_Click);
            // 
            // SetIndexButton
            // 
            this.SetIndexButton.Location = new System.Drawing.Point(19, 75);
            this.SetIndexButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SetIndexButton.Name = "SetIndexButton";
            this.SetIndexButton.Size = new System.Drawing.Size(160, 27);
            this.SetIndexButton.TabIndex = 4;
            this.SetIndexButton.Text = "Set Index";
            this.SetIndexButton.UseVisualStyleBackColor = true;
            this.SetIndexButton.Click += new System.EventHandler(this.IndexDirectory_Click);
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Location = new System.Drawing.Point(206, 87);
            this.IndexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IndexLabel.Size = new System.Drawing.Size(168, 15);
            this.IndexLabel.TabIndex = 5;
            this.IndexLabel.Text = "Display index directory path";
            this.IndexLabel.Click += new System.EventHandler(this.IndexLabel_Click);
            // 
            // IndexTime
            // 
            this.IndexTime.AutoSize = true;
            this.IndexTime.Location = new System.Drawing.Point(16, 115);
            this.IndexTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IndexTime.Name = "IndexTime";
            this.IndexTime.Size = new System.Drawing.Size(69, 15);
            this.IndexTime.TabIndex = 8;
            this.IndexTime.Text = "IndexTime";
            this.IndexTime.Click += new System.EventHandler(this.IndexTime_Click);
            // 
            // ShowIndexTime
            // 
            this.ShowIndexTime.AutoSize = true;
            this.ShowIndexTime.Location = new System.Drawing.Point(132, 115);
            this.ShowIndexTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowIndexTime.Name = "ShowIndexTime";
            this.ShowIndexTime.Size = new System.Drawing.Size(14, 15);
            this.ShowIndexTime.TabIndex = 9;
            this.ShowIndexTime.Text = "0";
            this.ShowIndexTime.Click += new System.EventHandler(this.ShowIndexTime_Click);
            // 
            // InformationNeed
            // 
            this.InformationNeed.AutoSize = true;
            this.InformationNeed.Location = new System.Drawing.Point(17, 170);
            this.InformationNeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InformationNeed.Name = "InformationNeed";
            this.InformationNeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InformationNeed.Size = new System.Drawing.Size(42, 15);
            this.InformationNeed.TabIndex = 14;
            this.InformationNeed.Text = "Query";
            this.InformationNeed.Click += new System.EventHandler(this.queryLable_1);
            // 
            // enterInformationNeed
            // 
            this.enterInformationNeed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.enterInformationNeed.Location = new System.Drawing.Point(17, 199);
            this.enterInformationNeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enterInformationNeed.Multiline = true;
            this.enterInformationNeed.Name = "enterInformationNeed";
            this.enterInformationNeed.Size = new System.Drawing.Size(441, 84);
            this.enterInformationNeed.TabIndex = 15;
            this.enterInformationNeed.TextChanged += new System.EventHandler(this.querytextBox2_TextChanged);
            // 
            // parsedQuery
            // 
            this.parsedQuery.AutoSize = true;
            this.parsedQuery.Location = new System.Drawing.Point(534, 170);
            this.parsedQuery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parsedQuery.Name = "parsedQuery";
            this.parsedQuery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.parsedQuery.Size = new System.Drawing.Size(83, 15);
            this.parsedQuery.TabIndex = 14;
            this.parsedQuery.Text = "Parsed Query";
            this.parsedQuery.Click += new System.EventHandler(this.queryLable_1);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SearchButton.Location = new System.Drawing.Point(17, 354);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 37);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // queryShow
            // 
            this.queryShow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.queryShow.Location = new System.Drawing.Point(537, 199);
            this.queryShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.queryShow.Multiline = true;
            this.queryShow.Name = "queryShow";
            this.queryShow.Size = new System.Drawing.Size(461, 84);
            this.queryShow.TabIndex = 17;
            this.queryShow.TextChanged += new System.EventHandler(this.queryShow_TextChanged);
            // 
            // searchTime
            // 
            this.searchTime.AutoSize = true;
            this.searchTime.Location = new System.Drawing.Point(534, 306);
            this.searchTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchTime.Name = "searchTime";
            this.searchTime.Size = new System.Drawing.Size(79, 15);
            this.searchTime.TabIndex = 19;
            this.searchTime.Text = "Search Time";
            this.searchTime.Click += new System.EventHandler(this.searchTime_Click);
            // 
            // searchTimeShow
            // 
            this.searchTimeShow.AutoSize = true;
            this.searchTimeShow.Location = new System.Drawing.Point(649, 306);
            this.searchTimeShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchTimeShow.Name = "searchTimeShow";
            this.searchTimeShow.Size = new System.Drawing.Size(14, 15);
            this.searchTimeShow.TabIndex = 20;
            this.searchTimeShow.Text = "0";
            this.searchTimeShow.Click += new System.EventHandler(this.searchtimeShow_Click);
            // 
            // NumbersOfDocuments
            // 
            this.NumbersOfDocuments.AutoSize = true;
            this.NumbersOfDocuments.Location = new System.Drawing.Point(534, 354);
            this.NumbersOfDocuments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumbersOfDocuments.Name = "NumbersOfDocuments";
            this.NumbersOfDocuments.Size = new System.Drawing.Size(187, 15);
            this.NumbersOfDocuments.TabIndex = 22;
            this.NumbersOfDocuments.Text = "Numbers of relevant documents";
            this.NumbersOfDocuments.Click += new System.EventHandler(this.NumbersOfDocuments_Click);
            // 
            // NumbersOfDocumentsShow
            // 
            this.NumbersOfDocumentsShow.AutoSize = true;
            this.NumbersOfDocumentsShow.Location = new System.Drawing.Point(768, 354);
            this.NumbersOfDocumentsShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumbersOfDocumentsShow.Name = "NumbersOfDocumentsShow";
            this.NumbersOfDocumentsShow.Size = new System.Drawing.Size(0, 15);
            this.NumbersOfDocumentsShow.TabIndex = 23;
            // 
            // ShowResults
            // 
            this.ShowResults.Location = new System.Drawing.Point(893, 332);
            this.ShowResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShowResults.Name = "ShowResults";
            this.ShowResults.Size = new System.Drawing.Size(105, 37);
            this.ShowResults.TabIndex = 25;
            this.ShowResults.Text = "Result";
            this.ShowResults.UseVisualStyleBackColor = true;
            this.ShowResults.Click += new System.EventHandler(this.ShowResults_Click);
            // 
            // SaveResults
            // 
            this.SaveResults.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveResults.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveResults.Location = new System.Drawing.Point(893, 482);
            this.SaveResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveResults.Name = "SaveResults";
            this.SaveResults.Size = new System.Drawing.Size(105, 37);
            this.SaveResults.TabIndex = 26;
            this.SaveResults.Text = "Save Result";
            this.SaveResults.UseVisualStyleBackColor = false;
            this.SaveResults.Click += new System.EventHandler(this.SaveResults_Click);
            // 
            // TextBox_indentifier
            // 
            this.TextBox_indentifier.Location = new System.Drawing.Point(17, 490);
            this.TextBox_indentifier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBox_indentifier.Name = "TextBox_indentifier";
            this.TextBox_indentifier.Size = new System.Drawing.Size(119, 25);
            this.TextBox_indentifier.TabIndex = 30;
            this.TextBox_indentifier.Text = "Input identifier";
            this.TextBox_indentifier.TextChanged += new System.EventHandler(this.textBox_indentifier_TextChanged);
            // 
            // SavingDirectory
            // 
            this.SavingDirectory.Location = new System.Drawing.Point(17, 432);
            this.SavingDirectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SavingDirectory.Name = "SavingDirectory";
            this.SavingDirectory.Size = new System.Drawing.Size(119, 37);
            this.SavingDirectory.TabIndex = 31;
            this.SavingDirectory.Text = "File Name";
            this.SavingDirectory.UseVisualStyleBackColor = true;
            this.SavingDirectory.Click += new System.EventHandler(this.SavingDirectory_Click);
            // 
            // FileDirectory
            // 
            this.FileDirectory.AutoSize = true;
            this.FileDirectory.Location = new System.Drawing.Point(190, 443);
            this.FileDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileDirectory.Name = "FileDirectory";
            this.FileDirectory.Size = new System.Drawing.Size(0, 15);
            this.FileDirectory.TabIndex = 32;
            this.FileDirectory.Click += new System.EventHandler(this.FileDirectory_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(157, 354);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 37);
            this.Clear.TabIndex = 33;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // AnalyserComboBox
            // 
            this.AnalyserComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AnalyserComboBox.FormattingEnabled = true;
            this.AnalyserComboBox.Items.AddRange(new object[] {
            "KeywordAnalyzer",
            "SimpleAnalyzer",
            "StandardAnalyzer",
            "StopAnalyzer",
            "WhitespaceAnalyzer",
            "SnowballAnalyzer"});
            this.AnalyserComboBox.Location = new System.Drawing.Point(19, 12);
            this.AnalyserComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AnalyserComboBox.Name = "AnalyserComboBox";
            this.AnalyserComboBox.Size = new System.Drawing.Size(160, 23);
            this.AnalyserComboBox.TabIndex = 38;
            this.AnalyserComboBox.Text = "Choose Analyzer";
            this.AnalyserComboBox.SelectedIndexChanged += new System.EventHandler(this.AnalyserComboBox_SelectedIndexChanged);
            // 
            // CreateIndexButton
            // 
            this.CreateIndexButton.Location = new System.Drawing.Point(698, 87);
            this.CreateIndexButton.Name = "CreateIndexButton";
            this.CreateIndexButton.Size = new System.Drawing.Size(160, 26);
            this.CreateIndexButton.TabIndex = 39;
            this.CreateIndexButton.Text = "Create Index";
            this.CreateIndexButton.UseVisualStyleBackColor = true;
            this.CreateIndexButton.Click += new System.EventHandler(this.CreateIndexButton_Click);
            // 
            // preProcessingCheck
            // 
            this.preProcessingCheck.AutoSize = true;
            this.preProcessingCheck.Location = new System.Drawing.Point(17, 306);
            this.preProcessingCheck.Name = "preProcessingCheck";
            this.preProcessingCheck.Size = new System.Drawing.Size(161, 19);
            this.preProcessingCheck.TabIndex = 40;
            this.preProcessingCheck.Text = "Pre-processing needed?";
            this.preProcessingCheck.UseVisualStyleBackColor = true;
            this.preProcessingCheck.CheckedChanged += new System.EventHandler(this.preprocessing_CheckedChanged);
            // 
            // SearchInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 544);
            this.Controls.Add(this.preProcessingCheck);
            this.Controls.Add(this.CreateIndexButton);
            this.Controls.Add(this.AnalyserComboBox);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.FileDirectory);
            this.Controls.Add(this.SavingDirectory);
            this.Controls.Add(this.TextBox_indentifier);
            this.Controls.Add(this.SaveResults);
            this.Controls.Add(this.ShowResults);
            this.Controls.Add(this.NumbersOfDocumentsShow);
            this.Controls.Add(this.NumbersOfDocuments);
            this.Controls.Add(this.searchTimeShow);
            this.Controls.Add(this.searchTime);
            this.Controls.Add(this.queryShow);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.enterInformationNeed);
            this.Controls.Add(this.parsedQuery);
            this.Controls.Add(this.InformationNeed);
            this.Controls.Add(this.ShowIndexTime);
            this.Controls.Add(this.IndexTime);
            this.Controls.Add(this.IndexLabel);
            this.Controls.Add(this.SetIndexButton);
            this.Controls.Add(this.CollectionLable);
            this.Controls.Add(this.CollectionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SearchInterface";
            this.Text = "EduSearch Application";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CollectionButton;
        private System.Windows.Forms.Label CollectionLable;
        private System.Windows.Forms.FolderBrowserDialog CollectionBrowserDialog;
        private System.Windows.Forms.Button SetIndexButton;
        private System.Windows.Forms.SaveFileDialog IndexSaveFileDialog;
        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.Label IndexTime;
        private System.Windows.Forms.Label ShowIndexTime;
        private System.Windows.Forms.Label InformationNeed;
        private System.Windows.Forms.TextBox enterInformationNeed;
        private System.Windows.Forms.Label parsedQuery;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox queryShow;
        private System.Windows.Forms.Label searchTime;
        private System.Windows.Forms.Label searchTimeShow;
        private System.Windows.Forms.Label NumbersOfDocuments;
        private System.Windows.Forms.Label NumbersOfDocumentsShow;
        private System.Windows.Forms.Button ShowResults;
        private System.Windows.Forms.Button SaveResults;
        private System.Windows.Forms.TextBox TextBox_indentifier;
        private System.Windows.Forms.Button SavingDirectory;
        private System.Windows.Forms.SaveFileDialog ResultsSaveFileDialog;
        private System.Windows.Forms.Label FileDirectory;
        private System.Windows.Forms.FolderBrowserDialog SaveFolderBrowserDialog;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox AnalyserComboBox;
        private System.Windows.Forms.Button CreateIndexButton;
        private System.Windows.Forms.CheckBox preProcessingCheck;
    }
}