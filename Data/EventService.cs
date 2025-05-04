using System.Net.Http.Json;

public class EventService
{
    private readonly HttpClient _httpClient;

    public EventService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Event>> GetEventsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Event>>("data/events.json");
    }

    public async Task<Event> GetEventByIdAsync(int id)
    {
        var events = await GetEventsAsync();
        return events.FirstOrDefault(e => e.Id == id);
    }
}