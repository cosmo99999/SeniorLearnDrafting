using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesign;

internal class Member
{
    public int Id;
    public User user;
    public List<Enrolment> enrolments;
    public List<DeliveryPlan> deliveryPlans;
    public List<Role> roles;

    public Member(int id)
    {
        Id = id;
    }

    public bool CreateDeliveryPlan(List<Lesson> lessons)
    {
        if(NoLessonConflicts(lessons) && IsProfesional())
        {
            deliveryPlans.Add(new DeliveryPlan(lessons));
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool NoLessonConflicts(List<Lesson> lessonInput)
    {
        foreach(DeliveryPlan p in deliveryPlans)
        {
            foreach(Lesson existingLesson in p.lessons)
            {
                foreach(Lesson newLesson in lessonInput)
                {
                    if(Lesson.IsOverlapping(existingLesson, newLesson))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    private bool IsProfesional()
    {
        foreach (Role r in roles)
        {
            if (r.roleType == RoleType.Professional)
            {
                return true;
            }
        }
        return false;
    }
}