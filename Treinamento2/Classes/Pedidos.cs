using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento2
{
    class Pedidos
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public PedidoStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Momento
                + ", "
                + Status;
        }
    }
}
