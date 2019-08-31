using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double Total() => Preco * Quantidade;
        
        public override string ToString() => Nome + ", " + " Unodade: R$ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture) + "\nValor Total da compra:" 
            + " R$"+Total().ToString("F2", CultureInfo.InvariantCulture);
    }
}
