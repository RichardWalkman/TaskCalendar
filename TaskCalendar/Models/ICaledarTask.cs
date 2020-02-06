using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static TaskCalendar.Models.CalendarTaskEnv;

namespace TaskCalendar.Models
{
    public interface ICalendarTask
    {
        int TaskID { get; }
        ICalendarTask MainCalendarTask { get; }
        string Name { get; }
        string Note { get; }
        TaskPeriodic TaskPeriodic { get; }
        int PeriodicMultipleRate { get; }
        TaskKind TaskKind { get; }
        TaskMeasureType MeasureType { get; set; }

        IList<ITaskExecution> Executions { get; set; }

        void ExecuteTask(DateTime Time, string Value);
    }
}
