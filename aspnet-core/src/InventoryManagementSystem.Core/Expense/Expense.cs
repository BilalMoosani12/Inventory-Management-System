﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InventoryManagementSystem.Expenses
{
    public class Expense : FullAuditedEntity<long>
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
    }
}