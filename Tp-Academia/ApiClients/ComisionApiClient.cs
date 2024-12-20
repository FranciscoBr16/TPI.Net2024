﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Entidades;

namespace ApiClients
{
    public class ComisionApiClient 
    {
        private static HttpClient client = new HttpClient();

        static ComisionApiClient()
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
        public static async Task<Comision> GetAsync(int id)
        {
            Comision com = null;
            HttpResponseMessage response = await client.GetAsync("comisiones/" + id);
            if (response.IsSuccessStatusCode)
            {
                com = await response.Content.ReadAsAsync<Comision>();
            }
            return com;
        }

        public static async Task<IEnumerable<Comision>> GetAllAsync()
        {
            IEnumerable<Comision> comisiones = null;
            HttpResponseMessage response = await client.GetAsync("comisiones");
            if (response.IsSuccessStatusCode)
            {
                comisiones = await response.Content.ReadAsAsync<IEnumerable<Comision>>();
            }
            return comisiones;
        }

        public static async Task AddAsync(Comision com)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("Comisiones", com);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("comisiones/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Comision com)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("comisiones", com);
            response.EnsureSuccessStatusCode();
        }
    }
}

