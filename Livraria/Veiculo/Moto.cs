using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    internal class Moto : Veiculo
    {
        public override void acelerar() {
            Console.WriteLine("Moto acelerando rapidamente");
        }
    }
}
