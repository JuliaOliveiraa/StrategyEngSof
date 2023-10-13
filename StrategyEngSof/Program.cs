using StrategyEngSof;
using StrategyEngSof.Interfaces;

using System;

public class Program
{
    public static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Digite o tipo de operação (Aritmetica ou Geometrica):");
            string tipoOperacao = Console.ReadLine();

            ICalcMedia calculo;
            if (tipoOperacao == "Aritmetica")
            {
                calculo = new Aritmetica();
            }
            else if (tipoOperacao == "Geometrica")
            {
                calculo = new Geometrica();
            }
            else
            {
                Console.WriteLine("Tipo de operação inválido. Saindo do programa.");
                return;
            }

            Console.WriteLine("Digite a nota P1:");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota P2:");
            double p2 = Convert.ToDouble(Console.ReadLine());

            Disciplina d = new Disciplina(calculo);
            d.SetNome("Padroes de Desenvolvimento");
            d.SetP1(p1);
            d.SetP2(p2);
            d.CalcularMedia();

            Console.WriteLine(String.Format("P1:{0:F2} P2:{1:F2} \nMedia:{2:F2} \nSituacao: {3}\n",
                d.GetP1(), d.GetP2(), d.GetMedia(), d.GetSituacao()));

            Console.WriteLine("Deseja continuar? (S/N)");
            string resposta = Console.ReadLine();
            continuar = (resposta.ToUpper() == "S");
        }
    }
}

