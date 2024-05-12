global using CP_POS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using CP_POS.RepositoryServices;


var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.


#region Database configure
var connectionString = builder.Configuration.GetConnectionString("DefaultConnections");
builder.Services.AddDbContext<CpPosContext>(options =>
{
    options.UseSqlServer(connectionString);
});
#endregion

#region identity configur
builder.Services.Configure<IdentityOptions>(options => {
  //  options.Password.RequireDigit = true;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;
});
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 3; // Set the required length to 3 digits
}).AddEntityFrameworkStores<CpPosContext>()
    .AddDefaultTokenProviders();
#endregion

#region For Jwt
//builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<CpPosContext>().AddDefaultTokenProviders();  // AddDefaultTokenProviders() is default token 
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options => {
        //options.SaveToken = true;
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidAudience = "http://localhost:4200",//configuration["JWT:ValidAudience"],
            ValidIssuer = "http://localhost:4200",
            //configuration["JWT:ValidIssuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"])),
            ClockSkew = TimeSpan.Zero

        };
    });

#endregion





#region add custom Services
builder.Services.AddScoped<CommonService>();
builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();
#endregion

#region Memory
builder.Services.AddMemoryCache();
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

#region for CORS Policy
app.UseCors(options =>
              options.WithOrigins("http://localhost:4200")  //Url can change according your angular app.
              .AllowAnyMethod()
              .AllowAnyHeader());
#endregion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
