﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFood.Domain.Contracts
{
    public interface IMessage
    {
        string Title { get; set; }
        string Subtitle { get; set; }
        string Description { get; set; }
        int Priority { get; set; }
    }
}
