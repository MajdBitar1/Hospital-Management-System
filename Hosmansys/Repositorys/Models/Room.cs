using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hosmansys.Repositorys.Models;

[Table("Room")]
public partial class Room
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [StringLength(50)]
    public string Rtype { get; set; } = null!;

    [StringLength(50)]
    public string Rperiod { get; set; } = null!;
}
