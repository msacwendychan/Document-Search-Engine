using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace a
{
    class Collection
    {
        public Collection()
        {

        }

        // Reads the content of documents as string line by line to the end
        public string fileRead1(string path)
        {
            FileStream content = new FileStream(path, FileMode.Open);
            TextReader reader;
            string text;
            using (reader = new StreamReader(content))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }


        public List<string> WalkDirectoryTree(String path)
        {
            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(path);
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;
            
            List<string> l = new List<string>();
            // Processes all the files directly under the document directory 
            try
            {
                files = root.GetFiles("*.*");
            }

            catch (UnauthorizedAccessException e)
            {
                System.Console.WriteLine(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            string[] m = new string[files.Length + 1];
            if (files != null)
            {

                foreach (System.IO.FileInfo fi in files)
                {                    
                    string text;
                    string name = fi.FullName;
                    string name2 = fi.Name;
                    string index = Regex.Replace(name2, @"[^\d]", " ");
                    text = fileRead1(name);
                    int number;
                    bool result = Int32.TryParse(index, out number);
                    if (result)
                    {
                        m[number] = text;
                    }
                }

                // Finds all the subdirectories under this directory
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory
                    string name = dirInfo.FullName;
                    WalkDirectoryTree(name);
                }
            }
            l.Add("");
            for(int i = 0; i < m.Length; i++)
            {
               l.Add(m[i]);
            }
            return l;
        }
       
    }
}
