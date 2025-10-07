
using Newtonsoft.Json.Linq;
using dynamic_json.Models;

namespace dynamic_json.JsonProcessors;

public class ToDoItemProcessor : IJsonProcessor
{
    public bool CanProcess(JObject json)
    {
        // Check for properties that match ToDoItem
        return json["Title"] != null && json["IsCompleted"] != null;
    }

    public object? Process(JObject json)
    {
        // Deserialize to ToDoItem
        var title = json["Title"]?.ToString();
        var isCompleted = json["IsCompleted"]?.ToObject<bool>() ?? false;
        return new ToDoItemProcessor
        {
            Title = title,
            IsCompleted = isCompleted
        };
    }
}