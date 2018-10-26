using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class TextAnalyser
    {
        // Initializes PorterStemmer class and Storwords_list class
        PorterStemmerAlgorithm.PorterStemmer myStemmer;
        System.Collections.Generic.Dictionary<string, int> tokenCount;
        Stopwords_list myStopwords = new Stopwords_list();
        

        public TextAnalyser()
        {
            
            myStemmer = new PorterStemmerAlgorithm.PorterStemmer();
            tokenCount = new Dictionary<string, int>();
        }

        // Term tokenization
        public string[] TokeniseString(string text)
        {
            char[] splitters = new char[] { '\r', '\t', '\'', '"', '-', '(', ')', ',', '’', '\n', ':', ';', '?', '.', '!',' ' };
            return text.ToLower().Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        }

        // Stems terms to root form
        public string[] StemTokens(string[] tokens)
        {
            int numTokens = tokens.Count();
            string[] stems = new string[numTokens];
            for (int i = 0; i < numTokens; i++)
            {
                stems[i] = myStemmer.stemTerm(tokens[i]);
            }
            return stems;
        }

        // Removes stopwords 
        public string[] StopWordFilter(string[] tokens)
        {
            string[] stopWords = myStopwords.CreateStopwords();
            int numTokens = tokens.Count();
            List<string> filteredTokens = new List<string>();
            for (int i = 0; i < numTokens; i++)
            {
                string token = tokens[i];
                if (!stopWords.Contains(token) && (token.Length > 2)) filteredTokens.Add(token);
            }
            return filteredTokens.ToArray<string>();
        }

        // Outputs query without pre-processing (only tokenizing)
        public string[] OutputInfoNeed(string str)
        {
            string[] tokens = TokeniseString(str);

            return tokens;
        }

        // Outputs query with pre-process (stems terms, clears stopwords and tokenizes)
        public string[] OutPreProcessed(string str)
        {
            string[] tokens = TokeniseString(str);
            string[] stems = StemTokens(tokens);
            string[] results = StopWordFilter(stems);
            return results;
        }

    }
}
