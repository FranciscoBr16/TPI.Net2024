using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Entidades;

namespace Presentacion.ApiClients
{
    internal class MateriaApiClient : Client
    {

        public static async Task<Materia> GetAsync(int id)
        {
            Materia mat = null;
            HttpResponseMessage response = await HttpClient.GetAsync("materias/" + id);
            if (response.IsSuccessStatusCode)
            {
                mat = await response.Content.ReadAsAsync<Materia>();
            }
            return mat;
        }

        public static async Task<IEnumerable<Materia>> GetAllAsync()
        {
            IEnumerable<Materia> materias = null;
            HttpResponseMessage response = await HttpClient.GetAsync("materias");
            if (response.IsSuccessStatusCode)
            {
                materias = await response.Content.ReadAsAsync<IEnumerable<Materia>>();
            }
            return materias;
        }

        public static async Task AddAsync(Materia esp)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync("materias", esp);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await HttpClient.DeleteAsync("materias/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Materia com)
        {
            HttpResponseMessage response = await HttpClient.PutAsJsonAsync("materias", com);
            response.EnsureSuccessStatusCode();
        }
    }
}

