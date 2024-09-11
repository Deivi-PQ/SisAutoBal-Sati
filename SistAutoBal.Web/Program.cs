using Microsoft.Extensions.Options;
using SisAutoBal.BusinessObjects.OfiSegu;
using SisAutoBal.Web.Services.AutoBal;
using SisAutoBal.Web.Models;
using SisAutoBal.Web.Services.OfiSegu;
using SisAutoBal.Web.Services.Reporte;
using SisAutoBal.Web.Services.SignalR;
using System.Net;
using SisAutoBal.Web.Services.Zoe;

var builder = WebApplication.CreateBuilder(args);

ServicePointManager
    .ServerCertificateValidationCallback +=
    (sender, cert, chain, sslPolicyErrors) => { return true; };

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSignalR();
builder.Services.AddCors(Opt =>
{
    Opt.AddPolicy("SignalR",
        builde =>
        {
            builde.SetIsOriginAllowed(origen => true)
            .AllowAnyMethod()
            .AllowCredentials()
            .AllowAnyHeader();

        });
});

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(1);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpClient("SisAutoBal", httpClient =>
{
    string uri = builder.Configuration.GetSection("UrlServicioBal").Value;
    httpClient.BaseAddress = new Uri(uri);
});

builder.Services.AddHttpClient("SisAutoZoe", httpClient =>
{
    string uri = builder.Configuration.GetSection("UrlServicioZoe").Value;
    httpClient.BaseAddress = new Uri(uri);
});


builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ICMusuaService, CMusuaService>();
builder.Services.AddScoped<IBloqueoPasoBalanzaService, BloqueoPasoBalanzaService>();
builder.Services.AddScoped<ISignalRService, SignalRService>();
builder.Services.AddScoped<IAuditoriaBalanzaService, AuditoriaBalanzaService>();
builder.Services.AddScoped<IReporteAperturaService, ReporteAperturaService>();
builder.Services.AddScoped<IReg_rfidService, Reg_rfidService>();
builder.Services.AddScoped<IBala_ContService, Bala_ContService>();
builder.Services.AddScoped<ITPunto_PasoService, TPunto_PasoService>();
builder.Services.AddScoped<ILectura_Punto_PasoService, Lectura_Punto_PasoService>();
builder.Services.AddScoped<IDato_rfid_pasoService, Dato_rfid_pasoService>();
builder.Services.AddScoped<IReco_OperService, Reco_OperService>();
builder.Services.AddScoped<ITipo_OperService,Tipo_OperService>();
builder.Services.AddScoped<IAccesoService, AccesoService>();
builder.Services.AddScoped<IPerfilService,PerfilService>();
builder.Services.AddScoped<IAcceso_PerfilService,Acceso_PerfilService>();
builder.Services.AddScoped<IUsuarioService,UsuarioService>();
builder.Services.AddScoped<IEvento_ModuloService,Evento_ModuloService>();
builder.Services.AddSingleton<UserTracker>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.UseCors("SisAutoBal");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<SignalRHub>("/SignalRHub");
});

app.Run();
