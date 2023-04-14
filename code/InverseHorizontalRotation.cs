using Ceiridge;

namespace Sandbox;

public class InverseHorizontalRotation : IRotationStrategy
{
    public Rotation GetNextRotation(float speed)
    {
        var num = Time.Tick * speed % 360;
        return Rotation.From(0, -num, 0);
    }
}
