﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCustomers.Domain.AggregatesModel.BaseAggregate
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Status Status { get; set; }
    }
}