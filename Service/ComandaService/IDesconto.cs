﻿using APIBarDG.Model.Comanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBarDG.Service.ComandaService
{
    interface IDesconto
    {
        Comanda DescontoAplicado(Comanda comanda);

    }
}
