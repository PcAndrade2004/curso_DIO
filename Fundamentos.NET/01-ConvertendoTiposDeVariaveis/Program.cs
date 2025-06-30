Console.WriteLine("## Convertendo Tipos de Variáveis ##\n");

// Casting -> usando o Convert
int a = Convert.ToInt32("5");   // Converte a string "5" para int
Console.WriteLine(a);          // Saída: 5

double b = double.Parse("4");  // Converte a string "4" para double
Console.WriteLine(b);          // Saída: 4

Console.ReadKey();