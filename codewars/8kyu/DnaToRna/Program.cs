string dna = "GCAT";

Console.WriteLine(DnaToRna(dna));

static string DnaToRna(string dna) => dna.Replace('T', 'U');