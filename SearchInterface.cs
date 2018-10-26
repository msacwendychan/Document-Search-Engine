using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Lucene.Net.Search; 
using Lucene.Net.QueryParsers;
using System.IO;


namespace a
{
    
    public partial class SearchInterface : Form
    {

        LuceneApplication myLuceneApp = new LuceneApplication();
        Collection myCollection = new Collection();
        Stopwatch stopwatch = new Stopwatch();
        TextAnalyser myTextAnalyser = new TextAnalyser();

        // Result list Array
        string[,] dt = null;
        List<string> l = new List<string>();
        List<string> searchResultList = new List<string>();
        TopDocs topDocs;
        string topicID = "";
        Boolean indexCreated;
        Boolean searchDone;


        public SearchInterface()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        // Selects collcetion directory path
        private void CollectionButton_Click(object sender, EventArgs e)
        {
            CollectionBrowserDialog.ShowDialog();
            CollectionLable.Text = CollectionBrowserDialog.SelectedPath;

        }

        // Open index selection directory 
        private void IndexDirectory_Click(object sender, EventArgs e)
        {

            IndexSaveFileDialog.ShowDialog();
            IndexLabel.Text = IndexSaveFileDialog.FileName;

        }


        private void CreateIndexButton_Click(object sender, EventArgs e)
        {
            if (IndexLabel.Text != "" && IndexLabel.Text != "Display index directory path")
            {
                // Starts counting index time
                

                // Error handling
                if (CollectionLable.Text != "" && CollectionLable.Text != "Display collection directory path")
                {
                    l = myCollection.WalkDirectoryTree(CollectionBrowserDialog.SelectedPath);
                }
                else
                {
                    MessageBox.Show("Please select collection path first.");
                }

                // Creates index
                stopwatch.Start();
                myLuceneApp.CreateIndex(IndexSaveFileDialog.FileName, AnalyserComboBox.Text);
                foreach (string s in l)
                {
                    myLuceneApp.IndexText(s);
                }

                stopwatch.Stop();
                myLuceneApp.CleanUpIndexer();

                // Timer stops
                

                // Shows index time on GUI
                ShowIndexTime.Text = stopwatch.Elapsed.ToString();
                stopwatch.Reset();

                // Message tells user the index is created
                MessageBox.Show("Index Created");
                indexCreated = true;
            }
            else
            {
                // Error handling
                MessageBox.Show("Index error! Please set index path first.");
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            // Error handling
            if(indexCreated == false)
            {
                MessageBox.Show("Create Index First");
            }


            if(indexCreated)
            {
                //Starts counting search time
                stopwatch.Start();

                myLuceneApp.CreateSearcher();

                // Checks if pre-processing is needed
                if (preProcessingCheck.Checked)
                {
                    string[] querys = myTextAnalyser.OutPreProcessed(enterInformationNeed.Text);
                    queryShow.Clear();
                    foreach (string s in querys)
                    {
                        queryShow.Text += s + " ";
                    }
                }
                else
                {
                    // Pre-processing is not needed, query parsed as is
                    string[] querys = myTextAnalyser.OutputInfoNeed(enterInformationNeed.Text);
                    queryShow.Clear();
                    foreach (string s in querys)
                    {
                        queryShow.Text += s + " ";
                    }
                }

                // Shows parsed query
                string querytext = queryShow.Text;

                int numberOfDocuments = 0;

                // Error handling
                if (querytext == "")
                {
                    MessageBox.Show("Query cannot be empty");
                }



                if (querytext != "")
                {
                     myLuceneApp.SearchIndex(querytext, ref topDocs, ref numberOfDocuments);
                     searchDone = true;                   
                }

                // Shows numbers of relevant documents retrieved 
                NumbersOfDocumentsShow.Text = numberOfDocuments.ToString();

                if(topDocs != null && topDocs.TotalHits != 0)
                {
                    dt = myLuceneApp.CreateData(topDocs);
                    searchResultList = myLuceneApp.SaveResults(topDocs);
                }
                


                myLuceneApp.CleanUpSearcher();

                // Timer stops
                stopwatch.Stop();

                // Shows searhc time on GUI
                searchTimeShow.Text = stopwatch.Elapsed.ToString();
                stopwatch.Reset();
            }
            Console.WriteLine(topicID);
            
        }

        // Clear query button click
        private void Clear_Click(object sender, EventArgs e)
        {
            enterInformationNeed.Text = "";
            queryShow.Text = "";
        }

        // Result button click
        private void ShowResults_Click(object sender, EventArgs e)
        {
            DisplayResults form2 = new DisplayResults(dt);
            form2.ShowDialog();
        }

        // Opens save result directory
        private void SavingDirectory_Click(object sender, EventArgs e)
        {
            ResultsSaveFileDialog.ShowDialog();
            FileDirectory.Text = ResultsSaveFileDialog.FileName;
        }

        // Saves results button click
        private void SaveResults_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchDone)
                {
                    // Error handling
                    if ((string.IsNullOrEmpty(TextBox_indentifier.Text))||(string.IsNullOrEmpty(FileDirectory.Text)))
                    {
                        MessageBox.Show("File Name and Identifier are needed");
                    }
                    else
                    {
                        // Creates result file based on set filename and identifier
                        string text = FileDirectory.Text;

                        string filename1 = text + ".txt";
                        using (StreamWriter textWriter = new StreamWriter(filename1, true))
                        {
                            foreach (string var in searchResultList)
                            {
                                textWriter.Write(TextBox_indentifier.Text);
                                
                                textWriter.Write("\t" + var+ "\t");
                        
                                textWriter.WriteLine("n9582541_n9781463_n9589147");
                            }
                        }
                        MessageBox.Show("File Created");
                    }
                }
                else
                {
                    MessageBox.Show("Please search first");
                }
            }

            // Catches unexpected errors
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }
        private void querytextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void collectionLable_Click(object sender, EventArgs e)
        {

        }

        private void IndexLabel_Click(object sender, EventArgs e)
        {

        }

        private void queryLable_1(object sender, EventArgs e)
        {

        }
        private void queryShow_TextChanged(object sender, EventArgs e)
        {

        }
        private void searchtimeShow_Click(object sender, EventArgs e)
        {

        }

        private void FileDirectory_Click(object sender, EventArgs e)
        {

        }

        private void Indentifier_Click(object sender, EventArgs e)
        {

        }

        private void AnalyserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void preprocessing_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NumbersOfDocuments_Click(object sender, EventArgs e)
        {

        }

        private void IndexTime_Click(object sender, EventArgs e)
        {

        }

        private void searchTime_Click(object sender, EventArgs e)
        {

        }

        private void textBox_indentifier_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowIndexTime_Click(object sender, EventArgs e)
        {

        }
    }

}
