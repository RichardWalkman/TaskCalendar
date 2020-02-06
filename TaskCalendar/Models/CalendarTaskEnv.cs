using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskCalendar.Models
{
    public class CalendarTaskEnv
    {
        public enum TaskKind
        {
            Regular = 0,
            OnceTime = 1
        }

        public enum TaskPeriodic
        {
            Year = 0,
            HalfYear,
            Season,
            Month,
            HalfMonth,
            Decade,
            Week,
            Day,
            Hour
        }

        public enum TaskMeasureType
        {
            Boolean = 1,
            Double,
            Triple,
            String,
            Float,
            Int,
            Date,
            Time,
            Interval
        }

    }
}
