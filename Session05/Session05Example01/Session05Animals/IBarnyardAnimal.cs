using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public interface IBarnyardAnimal
    {
        string ResingArea { get; }
        string FeedingArea { get; set; }
    }
}
