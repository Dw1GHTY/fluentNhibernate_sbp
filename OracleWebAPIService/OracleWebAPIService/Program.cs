var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>{

    options.AddPolicy("CORS", builder =>
    {

        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });

});


builder.Services.AddMvc().AddJsonOptions(p =>
{
    p.JsonSerializerOptions.WriteIndented = true;
});

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("CORS");

app.UseAuthorization();

app.MapControllers();

app.Run();
