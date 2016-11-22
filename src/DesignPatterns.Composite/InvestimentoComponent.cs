using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public abstract class InvestimentoComponent
    {
        protected string _nome;
        protected double _valorUnitario;
        protected double _quantidade;

        public InvestimentoComponent(string nome, double valorUnitario, double quantidade)
        {
            _nome = nome;
            _valorUnitario = valorUnitario;
            _quantidade = quantidade;
        }

        public abstract void Adicionar(InvestimentoComponent investimento);
        public abstract void Remover(InvestimentoComponent investimento);
        public abstract void Mostrar();
        public abstract double CalcularTotal();
    }
}
