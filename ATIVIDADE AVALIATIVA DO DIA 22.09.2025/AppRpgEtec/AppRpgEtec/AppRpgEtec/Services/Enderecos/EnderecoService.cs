using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRpgEtec.Models;
using Newtonsoft.Json.Linq;

namespace AppRpgEtec.Services.Enderecos
{
    internal class EnderecoService : Request
    {
        private readonly Request _request;
        private const string _apiUrlBase = "https://rpgapi3ai2025.azurewebsites.net/Enderecos";
        //Azure: https://rpgapi3ai2025.azurewebsites.net/Enderecos
        //Somee: http://luizfernando.somee.com/RpgApi/Enderecos

        public EnderecoService()
        {
            _request = new Request();
        }

        public async Task<ObservableCollection<Endereco>> GetEnderecoAsync (string name)
        {
            string urlComplementar = string.Format("{0}", name);
            ObservableCollection<Models.Endereco> listaEnderecos = await
            _request.GetAsync<ObservableCollection<Models.Endereco>>(_apiUrlBase, urlComplementar);
            return listaEnderecos;

        }
    }
}
