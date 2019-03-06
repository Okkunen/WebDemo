using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBackend.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBackend.Controllers
{
    [Route("api/kortit")]
    [ApiController]
    public class KortitApiController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Kortit> Listaus()
        {
            KorttiappiContext context = new KorttiappiContext();
            List<Kortit> allKortit = context.Kortit.ToList();

            return allKortit;
        }

        [Route("{korttiId}")]
        public Kortit Yksittäinen(int korttiId)
        {
            KorttiappiContext context = new KorttiappiContext();
            Kortit kortti = context.Kortit.Find(korttiId);

            return kortti;
        }

        [HttpPost]
        [Route("")]
        public bool Luonti([FromBody] Kortit uusi)
        {
            KorttiappiContext context = new KorttiappiContext();
            context.Kortit.Add(uusi);
            context.SaveChanges();

            return true;
        }

        [HttpPut]
        [Route("{korttiId}")]
        public Kortit Muokkaus(int korttiId, [FromBody] Kortit muutokset)
        {
            KorttiappiContext context = new KorttiappiContext();
            Kortit kortti = context.Kortit.Find(korttiId);

            // Löytyikö asiakas annetulla id:llä?
            if (kortti == null)
            {
                return null;
            }

            // Muokkaus
            kortti.Sana = muutokset.Sana;
            kortti.Kaannos = muutokset.Kaannos;
            kortti.KategoriaId = muutokset.KategoriaId;

            // Tallennus tietokantaan
            context.SaveChanges();

            return kortti;
        }

        [HttpDelete]
        [Route("{korttiId}")]
        public bool Poisto(int korttiId)
        {
            KorttiappiContext context = new KorttiappiContext();
            Kortit kortti = context.Kortit.Find(korttiId);

            if (kortti == null)
            {
                return false;
            }

            context.Kortit.Remove(kortti);
            context.SaveChanges();

            return true;
        }

    }
}