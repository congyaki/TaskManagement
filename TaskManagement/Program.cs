using Microsoft.EntityFrameworkCore;
using TaskManagement.Data;
using TaskManagement.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using TaskManagement.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using TaskManagement.Services;
using TaskManagement.Interfaces.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Database");

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddIdentity<User, Role>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

//builder.Services.AddIdentity<User, IdentityRole>(options =>
//    options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<ApplicationDbContext>()
//    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Overwrite Default User settings.
    options.SignIn.RequireConfirmedAccount = false;
    options.Tokens.AuthenticatorIssuer = null;
    options.User.RequireUniqueEmail = true;

});


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.ExpireTimeSpan = TimeSpan.FromHours(36);
        options.SlidingExpiration = true;
    });

// Services
builder.Services.AddTransient<IDepartmentService, DepartmentService>();
builder.Services.AddTransient<ILabelService, LabelService>();
builder.Services.AddTransient<ITaskService, TaskService>();

builder.Services.AddHttpContextAccessor();

var assembly = typeof(Program).Assembly;
builder.Services.AddAutoMapper(assembly);
//Tương đương code trên
//builder.Services.ConfigureApplicationCookie(o => {
//    // Overwrite Default settings.
//    o.ExpireTimeSpan = TimeSpan.FromHours(36);
//    //o.SlidingExpiration = true;
//});


//builder.Services.ConfigureApplicationCookie(options =>
//{
//    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
//    options.Cookie.Name = "TaskManagementCookie";
//    options.Cookie.HttpOnly = true;
//    options.ExpireTimeSpan = TimeSpan.FromHours(3);
//    options.LoginPath = "/Identity/Account/Login";
//    // ReturnUrlParameter requires 
//    //using Microsoft.AspNetCore.Authentication.Cookies;
//    options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
//    options.SlidingExpiration = true;
//});

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Khởi tạo và seed dữ liệu cho database
using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    await app.InitialiseDatabaseAsync(serviceProvider);
}


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

//Không sử dụng authentication từ hệ thống bên ngoài như OAuth2
var cookiePolicyOptions = new CookiePolicyOptions
{
    MinimumSameSitePolicy = SameSiteMode.Strict,
};

app.UseCookiePolicy(cookiePolicyOptions);

app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();


app.Run();
