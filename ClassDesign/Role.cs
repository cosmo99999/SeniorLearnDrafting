using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesign;
enum RoleType
{
    Standard,
    Professional,
    Honorary
}
internal class Role
{
    public bool isActive;
    public bool startDate;
    public RoleType roleType;
}


