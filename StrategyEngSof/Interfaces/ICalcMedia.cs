using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyEngSof.Interfaces;

public interface ICalcMedia
{
    double CalculaMedia(double p1, double p2);
    string Situacao(double media);
}
