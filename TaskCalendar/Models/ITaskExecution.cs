using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskCalendar.Models
{
    public interface ITaskExecution
    {
        ICalendarTask CalendarTask { get; }
        DateTime ExecutionDate { get; set; }
        string StringValue { get; set; }
        float FloatValue { get; set; }
        int IntValue { get; set; }
        TimeSpan SpanValue { get; set; }
    }
}
