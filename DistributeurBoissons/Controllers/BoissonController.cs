using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DistributeurBoissons.Controllers
{
    [Produces("application/json")]
    [Route("Boisson")]
    public class BoissonController : Controller
    {

        [HttpGet]
        public IActionResult get()
        {
            return Ok("hello Taher");
        }


        [HttpPost]
        public IActionResult post(string boisson)
        {
            double prix = 0;
            Dictionary<string, double> produits = new Dictionary<string, double>();

            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            produits.Add("Cafe", 1);
            produits.Add("Sucre", 0.1);
            produits.Add("Creme", 0.5);
            produits.Add("The", 2);
            produits.Add("Eau", 0.2);
            produits.Add("Chocolat", 1);
            produits.Add("Lait", 0.4);

            switch (boisson)
            {
                case "Expresso":
                    prix = produits["Cafe"] + produits["Eau"];
                    break;
                case "Allonge":
                    prix = produits["Cafe"] + produits["Eau"] * 2;
                    break;
                case "Capuccino":
                    prix = produits["Cafe"] + produits["Chocolat"] + produits["Eau"] + produits["Creme"];
                    break;
                case "Chocolat":
                    prix = produits["Chocolat"] * 3 + produits["Lait"] * 2 + produits["Eau"] + produits["Sucre"];
                    break;
                case "The":
                    prix = produits["The"] + produits["Eau"] * 2;
                    break;
                default:
                    prix = 0;
                    break;
            }

            return Ok("le prix du" +" "  + boisson  + " est " + prix);
        }
    }
}