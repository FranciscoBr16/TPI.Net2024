using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Entidades;

namespace Presentacion.ApiClients
{
    internal class EspecialidadApiClient : Client
    {

        public EspecialidadApiClient() : base()
        { 
        }

        public static async Task<Especialidad> GetAsync(int id)
        {
            Especialidad esp = null;
            HttpResponseMessage response = await client.GetAsync("especialidades/" + id);
            if (response.IsSuccessStatusCode)
            {
                esp = await response.Content.ReadAsAsync<Especialidad>();
            }
            return esp;
        }

        public static async Task<IEnumerable<Especialidad>> GetAllAsync()
        {
            IEnumerable<Especialidad> especialidades = null;
            HttpResponseMessage response = await client.GetAsync("especialidades");
            if (response.IsSuccessStatusCode)
            {
                especialidades = await response.Content.ReadAsAsync<IEnumerable<Especialidad>>();
            }
            return especialidades;
        }

        public static async Task AddAsync(Especialidad esp)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("especialidades", esp);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("especialidades/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Especialidad esp)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("especialidades", esp);
            response.EnsureSuccessStatusCode();
        }
    }
}

