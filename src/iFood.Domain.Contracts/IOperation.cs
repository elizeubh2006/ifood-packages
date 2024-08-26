﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts
{
    public interface IOperation
    {
        string Name { get; set; }
        List<ISalesChannel> SalesChannels { get; set; }
    }
}
