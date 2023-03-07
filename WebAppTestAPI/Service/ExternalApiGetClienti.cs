using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using WebAppTestAPI.Models;

namespace WebAppTestAPI.Service
{
    public class ExternalApiGetClienti
    {
        //DEPENDENCY INJECTION
        private readonly HttpClient _httpClient;
        public ExternalApiGetClienti(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ClienteApiModel>> GetClienteApi()
        {
            JsonValue result = await _httpClient.GetFromJsonAsync<JsonValue>("https://localhost:7015/ClienteResult?numeroClienti=5");

            List<JObject>jsonObjResult = JsonConvert.DeserializeObject<List<JObject>>(result.ToString());
            
            List<ClienteApiModel> clientiApi = new List<ClienteApiModel>();
            foreach (var item in jsonObjResult)
            {
                ClienteApiModel clienteApiModel = new ClienteApiModel();
                clienteApiModel.Nome = item["nome"].ToString();
                clienteApiModel.Cognome = item["cognome"].ToString();
                clientiApi.Add(clienteApiModel);
            }

            return clientiApi;
        }
    }
}
