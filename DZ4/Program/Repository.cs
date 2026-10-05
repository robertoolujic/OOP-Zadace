using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

public record class Repository(
    [property: JsonPropertyName("score")] string Score,
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("url")] Uri URL,
    [property: JsonPropertyName("language")] string Language,
    [property: JsonPropertyName("watchers")] int Watchers,
    [property: JsonPropertyName("pushed_at")] DateTime DLastPushUtc)

{
    public DateTime LastPush => DLastPushUtc.ToLocalTime();
}