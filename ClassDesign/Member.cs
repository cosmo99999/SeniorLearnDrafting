using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesign;

internal class Member
{
    private int Id;
    private User user;
    private List<Enrolment> enrolments;
    private List<DeliveryPlan> deliveryPlans;
    private List<Role> roles;

    public Member(int id)
    {
        Id = id;
    }

    public bool CreateDeliveryPlan(List<Lesson> lessons, bool isCourse)
    {
        if(DoesLessonConflictWithExisting(lessons) && IsProfesional())
        {
            deliveryPlans.Add(new DeliveryPlan(lessons, isCourse));
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool DoesLessonConflictWithExisting(List<Lesson> lessonInput)
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