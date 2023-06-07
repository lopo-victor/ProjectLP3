using System;
using System.Collections.Generic;

namespace DAL.DBContext;

public partial class TbPartida
{
    public int Id { get; set; }

    public int? WinsLaranja { get; set; }

    public int? WinsAzul { get; set; }

    public DateTime? Data { get; set; }
}
