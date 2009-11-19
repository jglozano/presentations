﻿namespace Services
{
    using System;

    public class PostDateDTO
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }
    }
}
