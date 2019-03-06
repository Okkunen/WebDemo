using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBackend.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {

        [Route("Lista")]

        public List<Kortit> KorttiLista()
        {
            List<Kortit> kortit = new List<Kortit>()
            {
                new Kortit()
                {
                    Sana = "Kana",
                    Kaannos = "Chicken",
                    KategoriaId = 1
                },
                new Kortit()
                {
                    Sana = "Possu",
                    Kaannos = "Pig",
                    KategoriaId = 1
                },
                new Kortit()
                {
                    Sana = "Koira",
                    Kaannos = "Dog",
                    KategoriaId = 1
                }
            };
            return kortit;
        }
    }
}