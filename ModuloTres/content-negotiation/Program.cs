using Microsoft.AspNetCore.Mvc.Formatters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//ADD -> dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml
//
builder.Services.AddMvc(config =>
            {
                //pode retornar o status 406 
                config.ReturnHttpNotAcceptable = true;
                //configura para poder retornar xml
                config.OutputFormatters.Add(new XmlSerializerOutputFormatter());
                //configura para poder receber xml
                config.InputFormatters.Add(new XmlSerializerInputFormatter(config));

                /* serealize: objeto -> json
                deserealize: json -> objeto */

                /* content - type-> request
                accept -> response */
            });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
