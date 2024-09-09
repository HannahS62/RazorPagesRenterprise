var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); // Redirects HTTP requests to HTTPS.

app.UseStaticFiles(); // enables static files, such as HTML, CSS, images and JavaScript to be serverd.

app.UseRouting(); // adds route matching the middleware pipeline

app.UseAuthorization(); // authorises a user to access secure resources (not currently being used in this application)

app.MapRazorPages(); // enpoint configuration routing for Razor pages

app.Run(); // Runs the application 
