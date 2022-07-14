﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odws.Api.Application.Interfaces.Repository
{
    public interface IReadRepository<BaseEntity> : IRepository<BaseEntity> where BaseEntity : class
    {
        
    }
}
