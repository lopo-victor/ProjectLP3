using System;
using System.Collections.Generic;

namespace DAL.DBContext;

public partial class TbPlayerPartida
{
    public int Id { get; set; }

    public int? IdPlayer { get; set; }

    public int? Kills { get; set; }

    public int? Assists { get; set; }

    public int? Deaths { get; set; }

    public int? Pontos { get; set; }
}
