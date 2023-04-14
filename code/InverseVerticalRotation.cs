using Ceiridge;

namespace Sandbox;

public class InverseVerticalRotation : IRotationStrategy
{
    public Rotation GetNextRotation(float speed)
    {
        var num = Time.Tick * speed % 360;
        return Rotation.From(-num, 0, 0);
    }
}
