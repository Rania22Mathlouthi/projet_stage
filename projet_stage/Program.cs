using Microsoft.EntityFrameworkCore;
using projet_stage.Data;
using projet_stage.IServices;
using projet_stage.IDAO;

using projet_stage.Services;
using projet_stage.DAO;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ModelDbContext>(o=>
{ o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
    o.UseLazyLoadingProxies();
});

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeDAO, EmployeeDAO>();
builder.Services.AddScoped<IMaterialService, MaterialService>();
builder.Services.AddScoped<IMaterialDAO, MaterialDAO>();
builder.Services.AddScoped<IEmployee_Material_AssignmentService, Employee_Material_AssignmentService>();
builder.Services.AddScoped<IEmployee_Material_AssignmentsDAO, Employee_Material_AssignmentsDAO>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
