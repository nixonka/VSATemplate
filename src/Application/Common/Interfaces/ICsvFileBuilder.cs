using VSATemplate.Application.Features.TodoLists;

namespace VSATemplate.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
