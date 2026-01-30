using AllForOneApiJD.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<HelloWorldService>();
builder.Services.AddScoped<AskingQuestionsService>();
builder.Services.AddScoped<AddingTwoNumbersService>();
builder.Services.AddScoped<OddOrEvenService>();
builder.Services.AddScoped<MadLibService>();
builder.Services.AddScoped<ReverseItAlphanumericService>();
builder.Services.AddScoped<ReverseItNumbersOnlyService>();
builder.Services.AddScoped<Magic8BallService>();
builder.Services.AddScoped<GuessItService>();
builder.Services.AddScoped<RestaurantPickerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
