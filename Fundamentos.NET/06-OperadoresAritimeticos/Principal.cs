using OperadoresAritimeticos;

namespace _06_OperadoresAritimeticos;

public class Principal
{
    public static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        //quando estamos passando parâmetros colocamos a virgula para delimitar.
        calc.Somar(30, 30);
        calc.Subtrair(40, 20);
        calc.Multiplicar(30, 30);
        calc.Dividir(30, 30);   
        calc.Potencia(20, 30);
        
        
        Console.ReadKey();
    }
}
