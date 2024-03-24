using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hosmansys.Repositorys.Models;

[Table("Doctor")]
public partial class Doctor
{
    [Key]
    [Column("DocID")]
    public int DocId { get; set; }

    [StringLength(50)]
    public string Docname { get; set; } = null!;

    [StringLength(50)]
    public string Docgender { get; set; } = null!;

    [StringLength(50)]
    public string Docdepartment { get; set; } = null!;

    [StringLength(50)]
    public string Docsalary { get; set; } = null!;

    [StringLength(50)]
    public string Docphonenb { get; set; } = null!;
}
