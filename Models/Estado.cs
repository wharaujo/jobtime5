using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ticketlog.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long Populacao { get; set; }
        public double CustoEstadoUS { get; set; }
    }
}
