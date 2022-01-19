using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento2
{
    enum PedidoStatus : int 
    {
        AguardandoPagamento = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
