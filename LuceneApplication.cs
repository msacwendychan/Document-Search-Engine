/* IFN647 Project - EduSearch Application created by 
 * Huanjiao Qiu n9582541
 * Wai Wing Chan n9781463
 * Zhiyi Wu n9589147
 * on 26 Oct 2017
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser
using System.Text.RegularExpressions;
using System.Data;

namespace a
{
    class LuceneApplication
    {
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        Lucene.Net.Search.IndexSearcher searcher;
        Lucene.Net.QueryParsers.QueryParser parser;
        CustomSimilarity customSimilarity;
        const string TEXT_FN = "Abstract";
        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        
        
        // Initializes objects
        public LuceneApplication()
        {
            luceneIndexDirectory = null;
            writer = null;
            analyzer = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(VERSION, "English");
            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
            customSimilarity = new CustomSimilarity();
        }


        // Creates index based on selection of analyzer
        public void CreateIndex(string indexPath,string name)
        {
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath);
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            if (name == "WhitespaceAnalyzer")
            {
                analyzer = new Lucene.Net.Analysis.WhitespaceAnalyzer();
            }
            if (name == "SimpleAnalyzer")
            {
                analyzer = new Lucene.Net.Analysis.SimpleAnalyzer();
            }

            if (name == "StandardAnalyzer")
            {
                analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(VERSION);
            }


            if (name == "StopAnalyzer")
            {
                analyzer = new Lucene.Net.Analysis.StopAnalyzer(VERSION);
            }
            else
            {
                writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, analyzer, true, mfl);
            }   
        
            writer.SetSimilarity(customSimilarity);
        }

        // Cleans up index
        public void CleanUpIndexer()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }

        // Creates multiple fields and sections DocID, Title, Author, Biliographic, Abstract for index
        public void IndexText(string text)
        {
            if (text == "")
            {
                Lucene.Net.Documents.Field field = new Field(TEXT_FN, text, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
                Lucene.Net.Documents.Document doc = new Document();
                doc.Add(field);
                writer.AddDocument(doc);
            }

            if ((text != "") && (text != null))
            {
                string removal = "\n";
                text = text.Replace(removal, "");

                // Delimeters 
                string pattern = @"(.T)|(.A)|(.B)|(.W)";

                // Splits items by delimeters
                string[] substrings = Regex.Split(text, pattern);
                Lucene.Net.Documents.Document doc = new Document();

                // Creates new doc of multiple fields
                doc.Add(new Field("Title", substrings[2], Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                doc.Add(new Field("Author", substrings[4], Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                doc.Add(new Field("Bibliographic", substrings[6], Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                doc.Add(new Field("Abstract", substrings[8], Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                writer.AddDocument(doc);
            }
        }

        // Creates searcher using custom similarity class
        public void CreateSearcher()
        {

            searcher = new IndexSearcher(luceneIndexDirectory);
            searcher.Similarity = customSimilarity;


        }

        // Cleans up searcher
        public void CleanUpSearcher()
        {
            searcher.Dispose();
        }

        // Processes query and ranks results
        public void SearchIndex(string querytext, ref TopDocs results, ref int numberOfDocuments)
        {
            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            results = searcher.Search(query, 1400);
            numberOfDocuments = results.TotalHits;
            int rank = 0;
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                // retrieve the document from the 'ScoreDoc' object
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(TEXT_FN).ToString();
                //Console.WriteLine("Rank " + rank + " text " + myFieldValue);
            }
        }

        // Creates result array 
        public string[,] CreateData(TopDocs topDocs)
        {
            
            string[,] dt = new string[topDocs.TotalHits, 4];
            int index = 0;
            foreach (ScoreDoc scoreDoc in topDocs.ScoreDocs)
            {
                string removal = ".";
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);

                dt[index, 0] = doc.Get("Title").ToString().Replace(removal, "");
                dt[index, 1] = doc.Get("Author").ToString().Replace(removal, "");
                dt[index, 2] = doc.Get("Bibliographic").ToString();
                if(doc.Get(TEXT_FN).ToString() != "")
                {
                    dt[index, 3] = doc.Get(TEXT_FN).ToString().Replace(doc.Get("Title").ToString(), "");
                }
                
                index++;
            }
            return dt;
        }

        // Generates top documents by ranking results
        public List<string> SaveResults(TopDocs topDocs)
        {
            List<string> searchResultList = new List<string>();
            int rank = 0;
            foreach (ScoreDoc scoreDoc in topDocs.ScoreDocs)
            {                
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                rank++;
                Lucene.Net.Documents.Document doc1 = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(TEXT_FN).ToString();
                string result = "Q0" + "\t" + scoreDoc.Doc + "\t" + rank + "\t" + scoreDoc.Score + "\t";
                searchResultList.Add(result);                
            }
            return searchResultList;
        }
    }
}

