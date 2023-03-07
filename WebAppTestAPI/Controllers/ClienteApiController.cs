using Microsoft.AspNetCore.Mvc;
using WebAppTestAPI.Service;

namespace WebAppTestAPI.Controllers
{
    public class ClienteApiController : Controller
    {
        //DEPENDENCY INJECTION
        private readonly ExternalApiGetClienti _externalApiGetClienti;
        public ClienteApiController(ExternalApiGetClienti externalApiGetClienti)
        {
            _externalApiGetClienti = externalApiGetClienti;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _externalApiGetClienti.GetClienteApi();
            return View(result);
        }
    }
}
