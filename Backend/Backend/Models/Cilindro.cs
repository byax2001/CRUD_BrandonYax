using System;
using System.Collections.Generic;

namespace Backend.Models;

public partial class Cilindro
{
    public int Id { get; set; }

    public string? Serie { get; set; } = null!;

    public int Idenvase { get; set; }

    public int Idproducto { get; set; }

    public int Capacidad { get; set; }

    public virtual Envase? IdenvaseNavigation { get; set; }

    public virtual Producto? IdproductoNavigation { get; set; }
}
