namespace dynamic_json.Models;

public record ToDoItem
{
    public string? Title { get; init; }
    public bool IsCompleted { get; init; }
}