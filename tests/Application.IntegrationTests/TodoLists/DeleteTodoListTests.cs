using FluentAssertions;

using NUnit.Framework;

using VSATemplate.Application.Common.Exceptions;
using VSATemplate.Application.Entities;
using VSATemplate.Application.Features.TodoLists;

using static VSATemplate.Application.IntegrationTests.Testing;

namespace VSATemplate.Application.IntegrationTests.TodoLists;
public class DeleteTodoListTests : TestBase
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand { Id = 99 };
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand
        {
            Id = listId
        });

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
