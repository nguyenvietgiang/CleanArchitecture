
using Application;
using Infrastructure.DapperSetting;
using Infrastructure.Services;
using Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DI
builder.Services.AddScoped<IDataAcess, DapperDataAccess>();
// Repo
builder.Services.AddScoped<ITodoListRepository, TodoListRepository>();
// Services
builder.Services.AddScoped<ITodoListService, TodoListService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Define API
app.MapGet("/api/todolists", async (ITodoListService todoListService) =>
{
    var todoLists = await todoListService.GetAllTodoListsAsync();
    return Results.Ok(todoLists);
});


app.UseHttpsRedirection();

app.Run();

