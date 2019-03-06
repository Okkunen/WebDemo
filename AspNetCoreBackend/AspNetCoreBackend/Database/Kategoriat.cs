using System;
using System.Collections.Generic;

namespace AspNetCoreBackend.Database
{
    public partial class Kategoriat
    {
        public Kategoriat()
        {
            Kortit = new HashSet<Kortit>();
        }

        public int KategoriaId { get; set; }
        public string Kategoria { get; set; }

        public ICollection<Kortit> Kortit { get; set; }
    }
}
