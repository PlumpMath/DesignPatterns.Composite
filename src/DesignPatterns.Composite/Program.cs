using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var investimentos = new InvestimentoComposite("Carteira Rico", 0, 0);

            var tesouroDireto = new InvestimentoComposite("Tesouro Direto", 0, 0);
            tesouroDireto.Adicionar(new PosicaoLeaf("2019+ IPCA", 2004.12, 2));
            tesouroDireto.Adicionar(new PosicaoLeaf("SELIC 2017", 1092.55, 1.5));
            tesouroDireto.Adicionar(new PosicaoLeaf("2023+ IPCA", 2500.33, 4.1));

            var rendaFixa = new InvestimentoComposite("Renda Fixa", 0, 0);
            rendaFixa.Adicionar(new PosicaoLeaf("LCI BANCO PINE S.A", 10000, 3));
            rendaFixa.Adicionar(new PosicaoLeaf("LCA CARGILL AGRICOLA S.A", 10215.63, 1));
            rendaFixa.Adicionar(new PosicaoLeaf("CDB BANCO DAYCOVAL S.A", 20000, 2.1234));

            var acoes = new InvestimentoComposite("Acoes", 0, 0);
            acoes.Adicionar(new PosicaoLeaf("VALE5", 14.44, 1001));

            investimentos.Adicionar(tesouroDireto);
            investimentos.Adicionar(rendaFixa);
            investimentos.Adicionar(acoes);

            investimentos.Mostrar();

            Console.ReadKey();
        }
    }
}
