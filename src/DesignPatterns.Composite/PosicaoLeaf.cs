using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class PosicaoLeaf : InvestimentoComponent
    {
        public PosicaoLeaf(string nome, double valorUnitario, double quantidade) : base(nome, valorUnitario, quantidade)
        {
        }

        public override void Adicionar(InvestimentoComponent investimento)
        {
            throw new NotImplementedException();
        }

        public override double CalcularTotal()
        {
            return _valorUnitario * _quantidade;
        }

        public override void Mostrar()
        {
            Console.WriteLine(string.Format("--{0} | valor unitario:{1} | quantidade:{2}", _nome, _valorUnitario, _quantidade));
        }

        public override void Remover(InvestimentoComponent investimento)
        {
            throw new NotImplementedException();
        }
    }
}
