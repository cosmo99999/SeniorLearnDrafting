using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesign;

internal class Lesson
{
    private int id;
    private DateTime Start;
    private DateTime End;
    private string Title;
    private DeliveryPlan DeliveryPlan;

    Lesson(DateTime start, DateTime end, string title)
    {
        Start = start;
        End = end;
        Title = title;
    }

    public static bool IsOverlapping(Lesson l1, Lesson l2)
    {
        if (l1.Start < l2.End && l1.Start > l2.Start)
        {
            return true;
        }
        else if (l2.Start < l1.End && l2.Start > l1.Start)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
