﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mosali.Domaine.Entities
{
    public class Employee: ModelBase
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public int SupervisorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherDetails { get; set; }
        public virtual Role Roles { get; set; }

    }
}
