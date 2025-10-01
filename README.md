DNA Sequence Analyzer
Overview
This is a modular C# console application designed for biotechnology use cases. It performs core DNA sequence analysis tasks such as validation, GC content calculation, reverse complement generation, and motif detection. Built with clean architecture and dependency injection for scalability and testability.

Features
DNA sequence validation (A, T, G, C only)
GC content calculation
Reverse complement generation
Motif detection (e.g., restriction sites)
Dependency Injection using Microsoft.Extensions.DependencyInjection
Clean separation of concerns (Models, Services, Program)
 Project Structure
Code
BiotechDNAAnalyzer/
├── Models/
│   └── DNASequence.cs
├── Services/
│   ├── IDNAAnalyzer.cs
│   └── DNAAnalyzer.cs
├── Program.cs
├── README.md
🛠️ Technologies Used
C# (.NET 6 or later)

Console Application

Microsoft.Extensions.DependencyInjection (for DI)

LINQ and Collections

Setup Instructions
Clone the repository

bash
git clone https://github.com/TechnoLearner/BiotechDNAAnalyzer.git
Open in Visual Studio

Select Console App (.NET 6 or later) as the project type.

Run the application

Press Ctrl + F5 or use the terminal:

bash
dotnet run
Sample Output
Code
Sequence: ATGCGTACGTTAGC
GC Content: 57.14%
Reverse Complement: GCTAACGTACGCAT
Contains motif 'CGTA': True

Author
Nalini Sindphale


