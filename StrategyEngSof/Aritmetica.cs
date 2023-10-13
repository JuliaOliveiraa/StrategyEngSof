using StrategyEngSof.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyEngSof;

public class Aritmetica : ICalcMedia
{
    public double CalculaMedia(double p1, double p2)
    {
        return (p1 + p2) / 2.0;
    }

    public string Situacao(double media)
    {
        if (media > 5.0)
        {
            return "Aprovado";
        }
        else
        {
            return "Reprovado";
        }
    }
}

