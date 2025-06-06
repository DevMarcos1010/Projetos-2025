
int[] sophiaNotas = {93, 87, 98, 95, 100};
int[] nicolasNotas = {80, 83, 82, 88, 85};
int[] zahirahNotas = {84, 96, 73, 85, 79};
int[] jeongNotas = {90, 92, 98, 100, 97};

int sophiaSum = sophiaNotas.Sum();
int nicolasSum = nicolasNotas.Sum();
int zahirahSum = zahirahNotas.Sum();
int jeongSum = jeongNotas.Sum();

int[] listSum = {sophiaSum, nicolasSum, zahirahSum, jeongSum};



int currentAssignments = 5;
string barraHorizont = "-------------------------";
int counter = 0;

Console.WriteLine("\tNotas totais dos alunos\n");
Console.WriteLine("\t\t\tN1\t\tN2\t\tN3\t\tN4\t\tN5\t\tMédia\t\tNota Final");
Console.WriteLine(barraHorizont + barraHorizont + barraHorizont);


Console.Write("Sophia\t");
foreach (int nota in sophiaNotas) 
{
    Console.Write($"\t|{nota} ");
}
Console.Write($"\t|{(decimal) sophiaSum / 5}");
Console.WriteLine("\t\t|A");


Console.Write("Nicolas\t");
foreach (int nota in nicolasNotas) 
{
    Console.Write($"\t|{nota} ");
}
Console.Write($"\t|{(decimal) nicolasSum / 5}");
Console.WriteLine("\t\t|B");


Console.Write("Zahirah\t");
foreach (int nota in zahirahNotas) 
{
    Console.Write($"\t|{nota} ");
}
Console.Write($"\t|{(decimal) zahirahSum / 5}");
Console.WriteLine("\t\t|B");


Console.Write("Jeong\t");
foreach (int nota in jeongNotas) 
{
    Console.Write($"\t|{nota} ");
}
Console.Write($"\t|{(decimal) jeongSum / 5}");
Console.WriteLine("\t\t|A");