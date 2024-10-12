using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Reflection;
using WebSisPar;
using WebSisPar.Services;
using static WebSisPar.Services.LanguageService;

var builder = WebApplication.CreateBuilder(args);

// ToDo: 555 Önemli Dil deste?i için 2. gelinen yer buras? program.cs Localizer al?nda i?lemler
#region ApiSettings
// appsettings.json'daki ApiSettings bölümünü okuma
builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("ApiSettings"));

// HttpClient'in baðýmlýlýk enjeksiyonu ile kullanýmý
builder.Services.AddHttpClient();

// Add services to the container.
builder.Services.AddControllers();
#endregion
#region Localizer
builder.Services.AddSingleton<LanguageService>();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddMvc().AddViewLocalization().AddDataAnnotationsLocalization(options =>
    options.DataAnnotationLocalizerProvider = (type, factory) =>
    {
        var assemblyName = new AssemblyName(typeof(SharedResource).GetTypeInfo().Assembly.FullName);
        return factory.Create(nameof(SharedResource), assemblyName.Name);
    });

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportCultures = new List<CultureInfo>
    {
        new CultureInfo("tr-TR"),
        new CultureInfo("az-AZ"),
        new CultureInfo("en-US"),
        new CultureInfo("fr-FR"),
        new CultureInfo("ar-SA"),
    };
    options.DefaultRequestCulture = new RequestCulture(culture: "tr-TR", uiCulture: "tr-TR");
    options.SupportedCultures = supportCultures;
    options.SupportedUICultures = supportCultures;
    options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
});
#endregion


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Core/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
// ToDo :555  Dil deste?i için 3. komt sat?r?
app.UseRequestLocalization(app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Core}/{action=Index}/{id?}");

app.Run();