﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odws.Api.Application.Interfaces.Repository
{
    public interface IRepository<BaseEntity>where BaseEntity:class
    {
        DbSet<BaseEntity> Table { get; }
    }
}
