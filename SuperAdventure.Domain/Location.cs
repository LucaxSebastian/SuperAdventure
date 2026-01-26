using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Domain;

public class Location
{
    public Guid ID { get; init; } = Guid.NewGuid();
    public required string Name { get; init; }
    public required string Description { get; set; }
}

