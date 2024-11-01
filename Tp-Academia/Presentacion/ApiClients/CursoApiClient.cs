using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Entidades;

namespace Presentacion.ApiClients
{
    internal class CursoApiClient : Client
    {

        public static async Task<Curso> GetAsync(int id)
        {
            Curso com = null;
            HttpResponseMessage response = await HttpClient.GetAsync("cursos/" + id);
            if (response.IsSuccessStatusCode)
            {
                com = await response.Content.ReadAsAsync<Curso>();
            }
            return com;
        }

        public static async Task<IEnumerable<Curso>> GetAllAsync()
        {
            IEnumerable<Curso> cursos = null;
            HttpResponseMessage response = await HttpClient.GetAsync("cursos");
            if (response.IsSuccessStatusCode)
            {
                cursos = await response.Content.ReadAsAsync<IEnumerable<Curso>>();
            }
            return cursos;
        }

        public static async Task AddAsync(Curso cur)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync("cursos", cur);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await HttpClient.DeleteAsync("cursos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Curso cur)
        {
            HttpResponseMessage response = await HttpClient.PutAsJsonAsync("cursos", cur);
            response.EnsureSuccessStatusCode();
        }

        public static async Task InscripcionAsync(Inscripcion insc)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync("inscripciones", insc);
            response.EnsureSuccessStatusCode();
        }
    }
}

