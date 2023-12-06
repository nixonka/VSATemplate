using VSATemplate.Application.Common.Interfaces;

namespace VSATemplate.Application.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
