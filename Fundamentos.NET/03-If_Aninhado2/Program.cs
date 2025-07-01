Console.WriteLine("## If aninhados ##\n");

//If aninhado : Quando você tem varias condições para verificar, você pode usar o if aninhado.

int quantidadeEstoque = 30;
int quantidadeCompra = 50;
bool possivelCompra = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;//as duas condições devem ser verdadeiras para que a compra seja possivel

Console.WriteLine($"É possivel realizar a venda? {possivelCompra} ");

if (quantidadeCompra == 0)
{
    Console.WriteLine("A quantidade não pode ser menor que zero");
}
else if (possivelCompra)
{
    Console.WriteLine("Venda Realizada!");
}else
{
    Console.WriteLine("Compra invalida");
}

Console.ReadLine();