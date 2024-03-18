using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsumption.Domain.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public UsageEnum Usage { get; set; }
        public float UsageAmount { get; set; }
    }
}
