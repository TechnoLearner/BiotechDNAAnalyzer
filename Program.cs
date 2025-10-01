using BiotechDNAAnalyzer.Models;
using BiotechDNAAnalyzer.Services;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        // Setup DI container
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IDNAAnalyzer, DNAAnalyzer>()
            .BuildServiceProvider();

        // Resolve service
        var analyzer = serviceProvider.GetService<IDNAAnalyzer>();

        var dna = new DNASequence("ATGCGTACGTTAGC");

        if (!dna.IsValid())
        {
            Console.WriteLine("Invalid DNA sequence.");
            return;
        }

        Console.WriteLine($"Sequence: {dna.Sequence}");
        Console.WriteLine($"GC Content: {analyzer.CalculateGCContent(dna):F2}%");
        Console.WriteLine($"Reverse Complement: {analyzer.GetReverseComplement(dna)}");

        string motif = "CGTA";
        Console.WriteLine($"Contains motif '{motif}': {analyzer.ContainsMotif(dna, motif)}");
    }
}
