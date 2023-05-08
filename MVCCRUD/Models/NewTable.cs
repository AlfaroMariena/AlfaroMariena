using System;
using System.Collections.Generic;

namespace MVCCRUD.Models;

public partial class NewTable
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Edad { get; set; }

    public DateTime? Fecha { get; set; }
}
