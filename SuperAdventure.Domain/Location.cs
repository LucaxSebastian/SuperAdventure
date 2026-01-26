using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Domain;

public class Location(string name, string description)
{
    public Guid ID { get; init; } = Guid.NewGuid();
    public string Name { get; } = name;
    public string Description { get; } = description;
}

