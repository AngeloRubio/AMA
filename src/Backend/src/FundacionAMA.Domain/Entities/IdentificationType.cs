﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using FundacionAMA.Domain.Shared.Entities;

using System;
using System.Collections.Generic;

namespace FundacionAMA.Domain.Entities;

public partial class IdentificationType: BaseEntity<short>
{
 
    public int? CompanyId { get; set; }

    public string Code { get; set; }

    public string Description { get; set; }

    public string Status { get; set; }
    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}