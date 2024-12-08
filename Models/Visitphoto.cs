using System;
using System.Collections.Generic;

namespace Advanced_Frontend_Final_Api.Models;

public partial class VisitPhoto
{
    public int Id { get; set; }

    public string? Photourl { get; set; }

    public int? Visitid { get; set; }

    public virtual Visit? Visit { get; set; }
}
