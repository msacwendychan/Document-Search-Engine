# Document Search Engine

This search engine allows users to index, search and review the abstract of journal articles. It is written in C# with Lucene.NET search engine library v3.0.3. A simple GUI is also designed for the search engine. 

## Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) - main written language of the program
* [Apache Lucene.NET](https://lucenenet.apache.org) - the search engine library applied (written in C# and targeted .NET users)
* [Visual Studio 2017](https://visualstudio.microsoft.com/zh-hant/downloads/?rr=https%3A%2F%2Fwww.google.com.au%2F) - the IDE used to develop the entire program and design the GUI

## Features

* Index establishment
* Query parsing
* Query analysis
* Result retrieval and ranking
* Retrieved documents saving
* Pre-processing options for users (i.e.remove stopwords / term stemming) 
* Shows search time and number of documents retrieved
* Text analyzer options: snowball (default), keyoword, simple, standard, stop, whitespace

## Classes:

Major Class           | Description           
--------------------- | -------------  
LuceneApplication     | Main class for search operation    
SearchInterface       | The GUI interface class for the control functions
DisplayResults        | The GUI interface class for result display
Collection            | Parse the collection of documents
TextAnalyzer          | Analyzer operation including term stemming, stopwords removal and tokenization
CustomerSimilarity    | Term Frequency (TF) and document length normalization 
Stopwords_list        | List of the stopwords to be removed during pre-processing 
PorterStemmer         | The term stemmer applied in this program

## Screenshots
The below screenshot demonstrates the search engine GUI and the operational components.
![Demonstrate the simple GUI](https://github.com/msacwendychan/Document-Search-Engine/blob/master/Screenshots/query%20input.png)

For more screenshots, please go to https://github.com/msacwendychan/Document-Search-Engine/tree/master/Screenshots

## Contributing

Pull requests and improvement are welcome. :) Please make sure to include commit comments for each change made. 

## Credits

Team: Joe Qiu and Zhiyi Wu


