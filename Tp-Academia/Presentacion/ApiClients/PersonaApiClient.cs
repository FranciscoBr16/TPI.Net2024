using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Entidades;

namespace Presentacion.ApiClients
{
    internal class PersonaApiClient : Client
    {

        public static async Task<Persona> GetAsync(int id)
        {
            Persona per = null;
            HttpResponseMessage response = await HttpClient.GetAsync("personas/" + id);
            if (response.IsSuccessStatusCode)
            {
                per = await response.Content.ReadAsAsync<Persona>();
            }
            return per;
        }
        public static async Task<Persona> LogInAsync(int legajo, string clave)
        {
            Persona per = new Persona { Legajo = legajo, Clave = clave } ;
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync("login", per);
            if (response.IsSuccessStatusCode)
            {
                per = await response.Content.ReadAsAsync<Persona>();
            }
            return per;
        }

        public static async Task<IEnumerable<Persona>> GetAllAsync()
        {
            IEnumerable<Persona> personas = null;
            HttpResponseMessage response = await HttpClient.GetAsync("personas");
            if (response.IsSuccessStatusCode)
            {
                personas = await response.Content.ReadAsAsync<IEnumerable<Persona>>();
            }
            return personas;
        }

        public static async Task AddAsync(Persona per)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync("personas", per);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int legajo)
        {
            HttpResponseMessage response = await HttpClient.DeleteAsync("personas/" + legajo);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Persona per)
        {
            HttpResponseMessage response = await HttpClient.PutAsJsonAsync("personas", per);
            response.EnsureSuccessStatusCode();
        }

        public static async Task<IEnumerable<Persona>> GetAlumnosAsync()
        {
            IEnumerable<Persona> personas = null;
            HttpResponseMessage response = await HttpClient.GetAsync("alumnos");
            if (response.IsSuccessStatusCode)
            {
                personas = await response.Content.ReadAsAsync<IEnumerable<Persona>>();
            }
            return personas;
        }

        public static async Task<IEnumerable<Persona>> GetProfesoresDelCursoAsync(int id)
        {
            IEnumerable<Persona> profes = null;
            HttpResponseMessage response = await HttpClient.GetAsync("profesoresdelcurso/" + id);
            if (response.IsSuccessStatusCode)
            {
                profes = await response.Content.ReadAsAsync<IEnumerable<Persona>>();
            }
            return profes;
        }

        internal static async Task<object?> GetProfesoresAsync()
        {
            IEnumerable<Persona> personas = null;
            HttpResponseMessage response = await HttpClient.GetAsync("profesores");
            if (response.IsSuccessStatusCode)
            {
                personas = await response.Content.ReadAsAsync<IEnumerable<Persona>>();
            }
            return personas;
        }
    }
}

