using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Modulo01EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler os dados de um funcionário(nome,
            // salário bruto e imposto). Em seguida, mostrar os dados do
            //funcionário(nome e salário líquido).Em seguida, aumentar o salário
            //do funcionário com base em uma porcentagem dada(somente o
            //salário bruto é afetado pela porcentagem) e mostrar novamente os
            //dados do funcionário.Use a classe projetada abaixo.

            Funcionario funcionario;

            Console.Write("Nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.Write("Sálario bruto: ");
            double salBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            funcionario = new Funcionario(nome, salBruto, imposto);

            Console.WriteLine("Funcionário: " + funcionario);

            Console.WriteLine("");

            Console.Write("Digite a porcentagem para aumentar o salário:");

            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            funcionario.AumentoSal(porcentagem);

            Console.WriteLine("Funcionário, dados atualizados: " + funcionario);
        }
    }
}
