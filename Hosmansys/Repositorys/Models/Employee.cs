using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hosmansys.Repositorys.Models;

[Table("Employee")]
public partial class Employee
{
    [Key]
    [Column("EID")]
    public int Eid { get; set; }

    [StringLength(50)]
    public string Ename { get; set; } = null!;

    [StringLength(50)]
    public string Egender { get; set; } = null!;

    [StringLength(50)]
    public string Esalary { get; set; } = null!;

    [StringLength(50)]
    public string Ephonenber { get; set; } = null!;

    [StringLength(50)]
    public string Ejob { get; set; } = null!;
}
