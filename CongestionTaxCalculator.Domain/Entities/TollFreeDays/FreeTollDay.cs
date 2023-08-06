﻿using CongestionTaxCalculator.Domain.Shared;

namespace CongestionTaxCalculator.Domain.Entities.TollFreeDays
{
    public class TollFreeDay : BaseEntity
    {
        public DayOfWeek Day { get; private set; }
        private TollFreeDay()
        {
        }
        public TollFreeDay(DayOfWeek day)
        {
            Id = Guid.NewGuid();
            Title = day.ToString();
            Day = day;
            CreatedDate = DateTime.Now;
        }

    }
}
