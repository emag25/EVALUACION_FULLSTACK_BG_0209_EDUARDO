using Reservas_API.Repositories.AlojamientoService;
using Reservas_API.Repositories.ReservaService;
using Reservas_API.Repositories.ServiciosAdicionalService;
using Reservas_API.Repositories.UsuarioService;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IUsuarioService, UsuuarioService>();
builder.Services.AddScoped<IReservasService, ReservaService>();
builder.Services.AddScoped<IAlojamientoService, AlojamientoService>();
builder.Services.AddScoped<IServiciosAdicionalService, ServicioAdicionalService>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
