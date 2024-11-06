using Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.ApiClients
{
    internal class InscripcionApiClient
    {
        private static HttpClient client = new HttpClient();

        static InscripcionApiClient()
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

        public static async Task<IEnumerable<Inscripcion>> GetInscripcionesDelAlumnoAsync(int legajo)
        {
            HttpResponseMessage response = await client.GetAsync("inscripcionesdelalumno/" + legajo);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<IEnumerable<Inscripcion>>();
            }
            return Enumerable.Empty<Inscripcion>();
        }

        public static async Task InscripcionAsync(Inscripcion insc)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("inscripciones", insc);
            response.EnsureSuccessStatusCode();
        }

        public static async Task<Inscripcion> GetAsync(int id)
        {
            Inscripcion ins = null;
            HttpResponseMessage response = await client.GetAsync("inscripciones/" + id);
            if (response.IsSuccessStatusCode)
            {
                ins = await response.Content.ReadAsAsync<Inscripcion>();
            }
            return ins;
        }

        internal static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("inscripciones/" + id);
            response.EnsureSuccessStatusCode();
        }
    }
}
