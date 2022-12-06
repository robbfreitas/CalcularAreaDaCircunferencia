using System.Globalization;

/* 
Essa é uma calculadora da área de circunferência e volume
utilizando membros estáticos. A necessidade de utilizar
membros estáticos dá-se pelo fato de que os valores dos
cálculos não mudam para calculadoras diferentes sendo
assim, cálculos estáticos. O valor de Pi é constante ou
seja, é estático também.
*/

namespace CalcularAreaDaCircunferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}