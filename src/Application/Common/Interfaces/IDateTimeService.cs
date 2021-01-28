using System;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IDateTimeService
    {
        public DateTime UtcNow { get; }
    }
}