using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Entidades;

namespace ApiClients
{
    public class MateriaApiClient 
    {

        private static HttpClient client = new HttpClient();
        static MateriaApiClient()
        {

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string baseUrl = configuration["ApiSettings:BaseUrl"];
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<Materia> GetAsync(int id)
        {
            Materia mat = null;
            HttpResponseMessage response = await client.GetAsync("materias/" + id);
            if (response.IsSuccessStatusCode)
            {
                mat = await response.Content.ReadAsAsync<Materia>();
            }
            return mat;
        }
        public static async Task<IEnumerable<Materia>> GetAllAsync()
        {
            IEnumerable<Materia> materias = null;
            HttpResponseMessage response = await client.GetAsync("materias");
            if (response.IsSuccessStatusCode)
            {
                materias = await response.Content.ReadAsAsync<IEnumerable<Materia>>();
            }
            return materias;
        }

        public static async Task AddAsync(Materia esp)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("materias", esp);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("materias/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Materia com)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("materias", com);
            response.EnsureSuccessStatusCode();
        }
    }
}

