using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Entidades;

namespace Presentacion.ApiClients
{
    internal class CursoApiClient 
    {
        private static HttpClient client = new HttpClient();
        static CursoApiClient()
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

        public static async Task<Curso> GetAsync(int id)
        {
            Curso cur = null;
            HttpResponseMessage response = await client.GetAsync("cursos/" + id);
            if (response.IsSuccessStatusCode)
            {
                cur = await response.Content.ReadAsAsync<Curso>();
            }
            return cur;
        }

        public static async Task<IEnumerable<Curso>> GetAllAsync()
        {
            IEnumerable<Curso> cursos = null;
            HttpResponseMessage response = await client.GetAsync("cursos");
            if (response.IsSuccessStatusCode)
            {
                cursos = await response.Content.ReadAsAsync<IEnumerable<Curso>>();
            }
            return cursos;
        }

        public static async Task<Curso> AddAsync(Curso cur)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("cursos", cur);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<Curso>();
        }

        public static async Task AddProfesAsync(Docente_curso dc)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("profesoresycursos", dc);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("cursos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Curso cur)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("cursos", cur);
            response.EnsureSuccessStatusCode();
        }

        public static async Task InscripcionAsync(Inscripcion insc)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("inscripciones", insc);
            response.EnsureSuccessStatusCode();
        }

        public static async Task<IEnumerable<Persona>> GetProfesDelCursoAsync(int id)
        {
            IEnumerable<Persona> profes = null;
            HttpResponseMessage response = await client.GetAsync("profesoresdelcurso/" + id );
            if (response.IsSuccessStatusCode)
            {
                profes = await response.Content.ReadAsAsync<IEnumerable<Persona>>();
            }
            return profes;
        }

        public static async Task DeleteProfeyCursoAsync(int idCurso, int legajoProfesor)
        {
            string url = $"profesoresycursos/{idCurso}/{legajoProfesor}";
            HttpResponseMessage response = await client.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
        }

        public static async Task<IEnumerable<Curso>> GetCursosDisponiblesAsync(int legajo)
        {
            IEnumerable<Curso> cur = null;
            HttpResponseMessage response = await client.GetAsync("cursos/disponiblesparaalumno/" + legajo);
            if (response.IsSuccessStatusCode)
            {
                cur = await response.Content.ReadAsAsync<IEnumerable<Curso>>();
            }
            return cur;
        }
    }
}

