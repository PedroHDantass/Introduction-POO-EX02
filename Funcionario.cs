using System.Globalization;
using System.Xml.Serialization;

namespace Modulo01EX02
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentoSal(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
        }

        public override string ToString()
        {
            return $"{Nome}, $ {SalLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
