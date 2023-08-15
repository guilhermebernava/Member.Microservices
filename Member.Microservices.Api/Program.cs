using Member.Microservices.Api.Injections;
using Member.Microservices.Api.Middlewares;
using Member.Microservices.Api.Profiles;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddJWT(builder);
builder.Services.AddAutoMapper(typeof(MappersProfile));
builder.Services.AddValidators();
builder.Services.AddConfiguredSwagger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseMiddleware<GlobalErrorMiddleware>();
app.Run();
