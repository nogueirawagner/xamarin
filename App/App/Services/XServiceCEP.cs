using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
  public class XServiceCEP
  {
    public static string UrlBase = "https://viacep.com.br/ws/{0}/json/";

    public async static Task<string> BuscaCEP(String pCEP)
    {
      var url = String.Format(UrlBase, pCEP);

      var http = new HttpClient();
      var result = await http.GetStringAsync(url);
      var obj = JsonConvert.DeserializeObject<dynamic>(result);
      return String.Format("CEP: {0}, UF: {1}, Endereço: {2}, Cidade: {3}", obj.cep, obj.uf, obj.logradouro, obj.localidade);

    }
  }
}
