using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public abstract class Veiculo
    {
        public virtual void acelerar()
        {
            Console.WriteLine("Veículo acelerando…");
        }
    }
}
