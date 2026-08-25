using Microsoft.EntityFrameworkCore;
using TerraQuest.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TerraQuestContext>(options => options.UseSqlite("Data Source=TerraQuest.db"));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<TerraQuestContext>();
    context.Database.Migrate();
    DbInitializer initializer = new DbInitializer();
    initializer.Initialize(context);
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();