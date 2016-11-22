using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class InvestimentoComposite : InvestimentoComponent
    {
        private List<InvestimentoComponent> posicoes = new List<InvestimentoComponent>();

        public InvestimentoComposite(string nome, double valorUnitario, double quantidade) : base(nome, valorUnitario, quantidade)
        {
        }

        public override void Adicionar(InvestimentoComponent investimento)
        {
            posicoes.Add(investimento);
        }

        public override double CalcularTotal()
        {
            return posicoes.Sum(it => it.CalcularTotal());
        }

        public override void Mostrar()
        {
            Console.WriteLine(string.Format("Investimento em {0} | Total investido: {1}", _nome, CalcularTotal()));
            Console.WriteLine("=======================================================================================");

            foreach (var investimento in posicoes)
            {
                investimento.Mostrar();
            }

            Console.WriteLine();
        }

        public override void Remover(InvestimentoComponent investimento)
        {
            posicoes.Remove(investimento);
        }
    }
}
