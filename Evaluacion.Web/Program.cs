using Evaluacion.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Se agrega AutoMapper para poder mapear los DTOS con las propiedades de las tablas ::: NOTA => REQUERIDO
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddHttpContextAccessor();

// Permite la conexion a la Base de Datos ::: NOTA => REQUERIDO
builder.Services.AddDbContexts(builder.Configuration);

// Permite el mapeo de los servicios con sus interfases y el mapeo de los repositorios con sus interfases ::: NOTA => REQUERIDO
builder.Services.AddServices();

// Deshabilitar la validaci�n del lado del cliente con ASP.NET 5 ::: NOTA => REQUERIDO
builder.Services.AddMvc().AddViewOptions(options =>
{
    options.HtmlHelperOptions.ClientValidationEnabled = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Concepto}/{action=Index}");

app.Run();