namespace OperadoresAritimeticos
{
    // Classe Calculadora que contém os métodos para as operações
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"A soma de: {x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"A subtração de: {x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"A multiplicação de: {x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
                Console.WriteLine($"A divisão de: {x} / {y} = {x / y}");
          
        }

        public void Potencia(int x, int y)
        {
            //elevado devemos usar o ^ 
            double pot = Math.Pow(x, y);//Pow -> significa a potencia
            Console.WriteLine($"A potencia de: {x}^{y} = {pot}");
        }
        
        public void raizQuadrada(double x)
        {
            //sqrt => Raiz Quadrada Calculo.
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} é: =  {Math.Sqrt(raiz)}");
        }
    }
}