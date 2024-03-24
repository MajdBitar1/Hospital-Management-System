using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hosmansys.Repositorys.Models;

[Table("Patient")]
public partial class Patient
{
    [Key]
    [Column("PID")]
    public int Pid { get; set; }

    [StringLength(50)]
    public string Pname { get; set; } = null!;

    [StringLength(50)]
    public string Pgender { get; set; } = null!;

    [StringLength(50)]
    public string Paddress { get; set; } = null!;

    [StringLength(50)]
    public string Pcontactnber { get; set; } = null!;

    public int? RoomNber { get; set; }

    [Column("P_dateadmitted", TypeName = "date")]
    public DateTime PDateadmitted { get; set; }

    [Column("P_datedischarged", TypeName = "date")]
    public DateTime PDatedischarged { get; set; }
}
