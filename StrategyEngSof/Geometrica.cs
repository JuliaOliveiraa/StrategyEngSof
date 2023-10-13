using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyEngSof;

using StrategyEngSof.Interfaces;
using System;

public class Geometrica : ICalcMedia
{
    public double CalculaMedia(double p1, double p2)
    {
        return Math.Sqrt(p1 * p2);
    }

    public string Situacao(double media)
    {
        if (media > 7.0)
        {
            return "Aprovado";
        }
        else
        {
            return "Reprovado";
        }
    }
}

