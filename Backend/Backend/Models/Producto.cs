using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Cilindro> Cilindros { get; set; } = new List<Cilindro>();
}
