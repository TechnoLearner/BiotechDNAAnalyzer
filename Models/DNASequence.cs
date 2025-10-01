using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotechDNAAnalyzer.Models
{
    public class DNASequence
    {
        public string Sequence { get; private set; }

        public DNASequence(string sequence)
        {
            Sequence = sequence.ToUpper();
        }

        public bool IsValid()
        {
            return Sequence.All(c => "ATGC".Contains(c));
        }
    }
}
