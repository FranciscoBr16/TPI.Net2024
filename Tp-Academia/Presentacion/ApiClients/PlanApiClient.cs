using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Entidades;

namespace Presentacion.ApiClients
{
    internal class PlanApiClient : Client
    {


        public static async Task<Plan> GetAsync(int id)
        {
            Plan plan = null;
            HttpResponseMessage response = await HttpClient.GetAsync("planes/" + id);
            if (response.IsSuccessStatusCode)
            {
                plan = await response.Content.ReadAsAsync<Plan>();
            }
            return plan;
        }

        public static async Task<IEnumerable<Plan>> GetAllAsync()
        {
            IEnumerable<Plan> planes = null;
            HttpResponseMessage response = await HttpClient.GetAsync("planes");
            if (response.IsSuccessStatusCode)
            {
                planes = await response.Content.ReadAsAsync<IEnumerable<Plan>>();
            }
            return planes;
        }

        public static async Task AddAsync(Plan plan)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync("planes", plan);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await HttpClient.DeleteAsync("planes/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Plan plan)
        {
            HttpResponseMessage response = await HttpClient.PutAsJsonAsync("planes", plan);
            response.EnsureSuccessStatusCode();
        }
    }
}

