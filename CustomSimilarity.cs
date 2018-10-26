using Lucene.Net.Search;
using System;
using FieldInvertState = Lucene.Net.Index.FieldInvertState;

namespace a
{
    public class CustomSimilarity : DefaultSimilarity
    {

        // Calculates term frequency
        public override float Tf(float freq)
        {
            if (freq == 0)
            {
                return 0;
            }
            else
            {
                return (float) (System.Math.Sqrt(freq) * 0.5);
            }
           
        }

        // Normalizes document length 
        public override float LengthNorm(string fieldName, int numTerms)
        {
            if (fieldName.Equals("title"))
            {
                return (float)(0.1 * Math.Log(numTerms));
            }
            else
            {
                return base.LengthNorm(fieldName, numTerms);
            }
        }

    }

}
