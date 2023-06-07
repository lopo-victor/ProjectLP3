using System;
using System.Collections.Generic;

namespace DAL.DBContext;

public partial class TbTime
{
    public int Id { get; set; }

    public int? IdPartida { get; set; }

    public int? IdPlayerPartida { get; set; }

    public string? Time { get; set; }
}
