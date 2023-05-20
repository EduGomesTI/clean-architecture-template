# region builder

using Api.Extensions;
using B3.DeafioTecnico.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerSetup();

builder.Services.AddApiVersioningSetup();

builder.Services.AddControllers();

#endregion

#region app

var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment())
{
    app.UseSwaggerUi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion
