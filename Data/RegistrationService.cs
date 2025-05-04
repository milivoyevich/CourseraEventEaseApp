using System.Text.Json;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

public class RegistrationService
{
    private readonly IWebAssemblyHostEnvironment _env;

    public RegistrationService(IWebAssemblyHostEnvironment env)
    {
        _env = env;
    }

    public async Task RegisterAsync(Registration registration)
    {
        var filePath = Path.Combine(_env.BaseAddress, "data/registrations.json");
        using var httpClient = new HttpClient();
        var json = await httpClient.GetStringAsync(filePath);

        var registrations = JsonSerializer.Deserialize<List<Registration>>(json) ?? new List<Registration>();
        registrations.Add(registration);
        using var content = new StringContent(JsonSerializer.Serialize(registrations), Encoding.UTF8, "application/json");
        Console.WriteLine($"RegistrationService: {JsonSerializer.Serialize(registrations)}");
        await httpClient.PutAsync(filePath, content);
    }
}