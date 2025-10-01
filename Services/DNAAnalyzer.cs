using BiotechDNAAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BiotechDNAAnalyzer.Services
{
    public class DNAAnalyzer : IDNAAnalyzer
    {
        public double CalculateGCContent(DNASequence dna)
        {
            int gcCount = dna.Sequence.Count(c => c == 'G' || c == 'C');
            return (double)gcCount / dna.Sequence.Length * 100;
        }

        public string GetReverseComplement(DNASequence dna)
        {
            var complement = new Dictionary<char, char>
            {
                {'A', 'T'}, {'T', 'A'}, {'G', 'C'}, {'C', 'G'}
            };

            var reversed = dna.Sequence.Reverse()
                                       .Select(c => complement[c]);
            return new string(reversed.ToArray());
        }

        public bool ContainsMotif(DNASequence dna, string motif)
        {
            return dna.Sequence.Contains(motif.ToUpper());
        }
    }
}
