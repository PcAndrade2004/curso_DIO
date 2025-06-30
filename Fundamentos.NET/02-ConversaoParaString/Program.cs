Console.WriteLine("## Conversão para o Tipo String ##\n");

//forma errada 
//string a = 5;

//forma correta :
string a = Convert.ToString("5");
Console.WriteLine(a);

//quando queremos converter algum tipo para string devemos utilizar o ToString();
// não podemos utilizar nenhum outro metodo, pois não existem alem do ToString();


Console.ReadKey();

