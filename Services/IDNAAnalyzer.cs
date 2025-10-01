using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiotechDNAAnalyzer.Models;

namespace BiotechDNAAnalyzer.Services
{
    public interface IDNAAnalyzer
    {
        double CalculateGCContent(DNASequence dna);
        string GetReverseComplement(DNASequence dna);
        bool ContainsMotif(DNASequence dna, string motif);
    }
}
