using FluentAssertions;

using NUnit.Framework;

using VSATemplate.Application.Common.Exceptions;
using VSATemplate.Application.Entities;
using VSATemplate.Application.Features.TodoItems;
using VSATemplate.Application.Features.TodoLists;

using static VSATemplate.Application.IntegrationTests.Testing;

namespace VSATemplate.Application.IntegrationTests.TodoItems;
public class DeleteTodoItemTests : TestBase
{
    [Test]
    public async Task ShouldRequireValidTodoItemId()
    {
        var command = new DeleteTodoItemCommand { Id = 99 };

        await FluentActions.Invoking(() =>
            SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoItem()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        var itemId = await SendAsync(new CreateTodoItemCommand
        {
            ListId = listId,
            Title = "New Item"
        });

        await SendAsync(new DeleteTodoItemCommand
        {
            Id = itemId
        });

        var item = await FindAsync<TodoItem>(itemId);

        item.Should().BeNull();
    }
}
