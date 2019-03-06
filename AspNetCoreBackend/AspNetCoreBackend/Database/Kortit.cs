using System;
using System.Collections.Generic;

namespace AspNetCoreBackend.Database
{
    public partial class Kortit
    {
        public int KorttiId { get; set; }
        public string Sana { get; set; }
        public string Kaannos { get; set; }
        public int? KategoriaId { get; set; }

        public Kategoriat Kategoria { get; set; }
    }
}
