using VSATemplate.Application.Common;
using VSATemplate.Application.ValueObjects;

namespace VSATemplate.Application.Entities;

public class TodoList : AuditableEntity
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public Colour Colour { get; set; } = Colour.White;

    public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
}
