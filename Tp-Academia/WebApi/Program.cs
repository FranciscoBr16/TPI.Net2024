using Data;
using Entidades;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddDbContext<AcademiaContext>();
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

#region Comisiones

app.MapGet("/comisiones", () => 
{
    return ComisionService.GetComisiones();
});

app.MapGet("/comisiones/{id}", (int id) =>
{
    return ComisionService.GetComisionById(id);
});


app.MapPost("/comisiones",  (Comision com) =>
{
    ComisionService.InsertComision(com);
});

app.MapPut("/comisiones/{id}", (Comision com) =>
{
    ComisionService.ModificarComision(com);
 
});

app.MapDelete("/comisiones/{id}",(int id) =>
{
    ComisionService.EliminarComision(ComisionService.GetComisionById(id));
});
#endregion
#region Cursos
app.MapGet("/cursos", () =>
{
    return CursoService.GetCursos();
});

app.MapGet("/cursos/{id}", (int id) =>
{
    return CursoService.GetCursoById(id);
});


app.MapPost("/cursos", (Curso cur) =>
{
    CursoService.InsertCurso(cur);
});

app.MapPut("/cursos/{id}", (Curso cur) =>
{
    CursoService.ModificarCurso(cur);

});

app.MapDelete("/Cursos/{id}", (int id) =>
{
    CursoService.EliminarCurso(CursoService.GetCursoById(id));
});


#endregion
#region Especialidad
app.MapGet("/especialidades", () =>
{
    return EspecialidadService.GetEspecialidades();
});

app.MapGet("/especialidades/{id}", (int id) =>
{
    return EspecialidadService.GetEspecialidadById(id);
});


app.MapPost("/especialidades", (Especialidad cur) =>
{
    EspecialidadService.InsertEspecialidad(cur);
});

app.MapPut("/especialidades/{id}", (Especialidad esp) =>
{
    EspecialidadService.ModificarEspecialidad(esp);

});

app.MapDelete("/especialidades/{id}", (int id) =>
{
    EspecialidadService.EliminarEspecialidad(EspecialidadService.GetEspecialidadById(id));
});

#endregion
#region Materias
app.MapGet("/materias", () =>
{
    return MateriaService.GetMaterias();
});

app.MapGet("/materias/{id}", (int id) =>
{
    return MateriaService.GetMateriaById(id);
});


app.MapPost("/materias", (Materia mat) =>
{
    MateriaService.InsertMateria(mat);
});

app.MapPut("/materias/{id}", (Materia mat) =>
{
    MateriaService.ModificarMateria(mat);

});

app.MapDelete("/materias/{id}", (int id) =>
{
    MateriaService.EliminarMateria(MateriaService.GetMateriaById(id));
});
#endregion
# region Personas
app.MapGet("/alumnos", () =>
{
    return PersonaService.GetAlumnos();
});

app.MapGet("/profesores", () =>
{
    return PersonaService.GetProfesores();
});

app.MapGet("/personas/{id}", (int legajo) =>
{
    return PersonaService.GetPersonaByLegajo(legajo);
});


app.MapPost("/personas", (Persona per) =>
{
    PersonaService.InsertPersona(per);
});

app.MapPut("/personas/{id}", (Persona per) =>
{
    PersonaService.ModificarPersona(per);

});

app.MapDelete("/personas/{id}", (int legajo) =>
{
    PersonaService.EliminarPersona(PersonaService.GetPersonaByLegajo(legajo));
});
#endregion
#region Planes
app.MapGet("/planes", () =>
{
    return PlanService.GetPlanes();
});

app.MapGet("/planes/{id}", (int id) =>
{
    return PlanService.GetPlanById(id);
});


app.MapPost("/planes", (Plan plan) =>
{
    PlanService.InsertPlan(plan);
});

app.MapPut("/planes/{id}", (Plan plan) =>
{
    PlanService.ModificarPlan(plan);

});

app.MapDelete("/planes/{id}", (int id) =>
{
    PlanService.EliminarPlan(PlanService.GetPlanById(id));
});
#endregion
#region ProfesorYCurso
app.MapGet("/profesoresycursos", () =>
{
    return ProfesorYCursoService.GetProfesoresYCursos();
});

app.MapGet("/profesoresdelcurso/{id}", (int id) =>
{
    return ProfesorYCursoService.GetProfesoresDelCurso(id);
});

/*

app.MapPost("/profesoresycursos", (ProfesorYCurso pyc) =>
{
    ProfesorYCursoService.InsertProfesorYCurso(pyc);
});

app.MapPut("/profesoresycursos/{id}", (ProfesorYCurso pyc) =>
{
    ProfesorYCursoService.ModificarProfesorYCurso(pyc);

});

app.MapDelete("/profesoresycursos/{id}", (int id) =>
{
    ProfesorYCursoService.EliminarProfesorYCurso(ProfesorYCursoService.GetProfesorYCursoById(id));
}); */
#endregion
# region Inscripciones
app.MapGet("/inscripciones", () =>
{
    return InscripcionService.GetInscripciones();
});

app.MapGet("/inscripciones/{id}", (int id) =>
{
    return InscripcionService.GetInscripcionById(id);
});


app.MapPost("/inscripciones", (Inscripcion inscripcion) =>
{
    InscripcionService.InsertInscripcion(inscripcion);
});

app.MapPut("/inscripciones/{id}", (Inscripcion inscripcion) =>
{
    InscripcionService.ModificarInscripcion(inscripcion);

});

app.MapDelete("/inscripciones/{id}", (int id) =>
{
    InscripcionService.EliminarInscripcion(InscripcionService.GetInscripcionById(id));
});
#endregion
app.Run();
