Console.WriteLine("## Operador OR || ##\n");
// Pelo menor uma das condições deve ser verdadeira para que o resultado seja verdadeira.
// E se todas forem falsas, o resultado será falso.

bool ehmaiorDeIdade = true;
bool possuiAutorizacao = false;

if (ehmaiorDeIdade || possuiAutorizacao)
{
    Console.WriteLine("Pode entrar na festa");
}else 
{
    Console.WriteLine("Não pode entrar na festa");
}

Console.WriteLine("-------------------------------");

Console.WriteLine("\n## Operador AND && ##\n");
// neste caso, as duas condições devem ser verdadeiras para que o resultado seja verdadeiro.
//caso apenas uma seja verdadeira, o programa já direciona para o else que exibe a mensagem de que o aluno foi reprovado.

Console.WriteLine("Digite a pressaça do aluno: ");
int presenca = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a media do aluno: ");
int media = int.Parse(Console.ReadLine());

int presencaMinima = 75;

if (presenca > presencaMinima && media >= 7)
{
 Console.WriteLine("Aluno aprovado");
}else 
{
    Console.WriteLine("Aluno reprovado");
}   

Console.WriteLine("-------------------------------");

Console.WriteLine("\n## Operador Ternário ##\n");

bool choveu = true;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("vou pedalar");
}
else
{
    Console.WriteLine("não vou pedalar");   
}


Console.ReadLine();
