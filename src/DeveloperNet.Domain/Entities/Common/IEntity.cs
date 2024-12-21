﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperNet.Domain.Entities.Common
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
