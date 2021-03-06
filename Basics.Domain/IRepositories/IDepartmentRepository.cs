﻿using Basics.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basics.Domain.IRepositories
{
    public interface IDepartmentRepository : IRepository<Department, string>
    {
    }
}
