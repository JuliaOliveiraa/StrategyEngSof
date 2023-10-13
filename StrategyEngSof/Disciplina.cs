using StrategyEngSof.Interfaces;
using System;

namespace StrategyEngSof
{
    public class Disciplina
    {
        private ICalcMedia calculo; 
        private string nome;
        private double p1;
        private double p2;
        private double media;
        private string situacao;

        public Disciplina(ICalcMedia calculo)
        {
            this.calculo = calculo;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetP1(double p1)
        {
            this.p1 = p1;
        }

        public void SetP2(double p2)
        {
            this.p2 = p2;
        }

        public double GetP1()
        {
            return this.p1;
        }

        public double GetP2()
        {
            return this.p2;
        }

        public double GetMedia()
        {
            return this.media;
        }

        public string GetSituacao()
        {
            return this.situacao;
        }

        public void CalcularMedia()
        {
            this.media = calculo.CalculaMedia(p1, p2);
            this.situacao = calculo.Situacao(media);
        }
    }
}
