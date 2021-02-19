using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ticketlog.Models
{
    [Keyless]
    public class ParametroCusto
    {
        public double PorPessoa { get; set; }
        public double ValorCorte { get; set; }
        public double Descontos { get; set; }
    }
}
