using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:44361/");
            //var teste = client.GetAsync("api/values/4");
            TesteApiController.api.ValuesController client = new TesteApiController.api.ValuesController();
            var resultado = client.TesteValor(1);
        }
    }
}
