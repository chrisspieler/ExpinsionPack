using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ceiridge;

namespace Sandbox;

public class VerticalRotation : IRotationStrategy
{
    public Rotation GetNextRotation(float speed)
    {
        var num = Time.Tick * speed % 360;
        return Rotation.From(num, 0, 0);
    }
}
