using System;
using System.Collections.Generic;

namespace DAL.DBContext;

public partial class TbPlayer
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public int Kills { get; set; }

    public int Deaths { get; set; }

    public int Assists { get; set; }

    public int Level { get; set; }

    public int? Vitorias { get; set; }

    public int? Derrotas { get; set; }
}
