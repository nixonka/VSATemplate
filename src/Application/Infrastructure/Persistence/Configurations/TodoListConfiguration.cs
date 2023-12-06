// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;
//
// using VSATemplate.Application.Entities;
//
// namespace VSATemplate.Application.Infrastructure.Persistence.Configurations;
//
// public class TodoListConfiguration : IEntityTypeConfiguration<TodoList>
// {
//     public void Configure(EntityTypeBuilder<TodoList> builder)
//     {
//         builder.Property(t => t.Title)
//             .HasMaxLength(200)
//             .IsRequired();
//
//         builder
//             .OwnsOne(b => b.Colour);
//     }
// }
