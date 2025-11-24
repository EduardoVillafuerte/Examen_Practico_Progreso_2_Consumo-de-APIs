using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Examen_Práctico_Progreso_2_Consumo_de_APIs.Controllers
{
    public class PokemonController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();
        
        public async Task<ActionResult> Index()
        {
            var response = await _httpClient.GetStringAsync("https://pokeapi.co/api/v2/pokemon");
            JObject json = JObject.Parse(response);
            var results = json["results"];
            return View(results);
        }
    }
}