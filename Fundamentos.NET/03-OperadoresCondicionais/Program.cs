Console.WriteLine("## Operadores Condicionais ##\n");

int quantidadeEstoque = 30;
int quantidadeCompra = 50;
bool possivelVenda = quantidadeEstoque >= quantidadeCompra; //aqui ela verifica se a quantidade em estoque é maior ou igual a quantidade comprada.

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade comprada: {quantidadeCompra}");

if (possivelVenda)
{
    //Caso seja retorne TRUE exibe esta mensagem. 
    Console.WriteLine("Venda realizada com sucesso!");
}
else
{
    //Caso seja FALSE exibe esta mensagem.
    Console.WriteLine("Não temos a quantidade suficiente para realizar a venda.");
}

/*
 If ele verificara se nos podemos ou não comprar.
 Ele sempre retorna uma expressão booleana, TRUE ou FALSE

 Criamos uma variável do tipo booleana, que atribuimos a ela uma verificação de que se,
a quantidadeEstoque (for maior ou igual) a quantidadeCompra = o nosso código será executado a mensagem que esta dentro do if.
Caso não seja possível e retorne FALSE a mensagem que esta dentro do else será exibida.

* Eu criei uma variável e dentro dela adicionei a lógica a ser verificada → (quantidadeEstoque >= quantidadeCompra).

* Mas poderia colocá-la dentro do IF (quantidadeEstoque >= quantidadeCompra) 

* Se passarmos uma variável booleana ele também verificara. Não precisa ser dentro do if.

 */


Console.ReadKey();