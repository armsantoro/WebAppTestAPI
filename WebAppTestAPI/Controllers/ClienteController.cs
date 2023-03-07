using Microsoft.AspNetCore.Mvc;
using WebAppTestAPI.Models;

namespace WebAppTestAPI.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            List<ClienteModel> clienti = new List<ClienteModel>();
            for (int i = 0; i < 4; i++)
            {
                ClienteModel cliente = new ClienteModel();
                cliente.Nome = "Armando" + i.ToString();
                cliente.Cognome = "Santoro" + i.ToString();
                cliente.Eta = 30 + i;
                cliente.PIva = "none";
                cliente.CodCapelli = i + 1;
                cliente.Data = DateTime.Now;
                cliente.StatoCliente = true;
                clienti.Add(cliente);
            }
            return View(clienti);
        }
    }
}
