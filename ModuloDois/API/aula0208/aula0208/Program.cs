using aula0208.Infra;
using aula0208.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//um tipo de inje��o de independ�ncia
//qual a maneira que vai ser inst�nciada 
//sempre que precisar usar o logacao vai ser desta forma 
builder.Services.AddScoped<LogAcao>((s) => new LogAcao("C:\\Logs\\Logs.txt"));

//injeção repositórios
builder.Services.AddScoped<TipoClienteRepository>();
builder.Services.AddScoped<ClienteRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection(); - tirar para consumir pelo insomnia

app.UseAuthorization();

app.MapControllers();

app.Run();
