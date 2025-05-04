// using CourseraEventEaseApp.Data;

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container
// builder.Services.AddRazorPages();
// builder.Services.AddServerSideBlazor();
// builder.Services.AddHttpClient<EventService>(client =>
// {
//     client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
// });
// builder.Services.AddSingleton<RegistrationService>();

// var app = builder.Build();

// app.UseStaticFiles();
// app.UseRouting();

// app.MapBlazorHub();
// app.MapFallbackToPage("/_Host");

// app.Run();