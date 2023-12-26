﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDEorkShop.Entities.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T Entity);
    }
}
