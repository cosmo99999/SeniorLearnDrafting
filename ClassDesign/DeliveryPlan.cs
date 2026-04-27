using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesign;

internal class DeliveryPlan
{
    private bool IsCourse;
    public List<Lesson> Lessons {get; private set;}
    
    public DeliveryPlan(List<Lesson> lessons, bool isCourse)
    {
        Lessons = lessons;
        IsCourse = isCourse;
    }
}
