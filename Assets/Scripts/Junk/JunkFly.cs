using UnityEngine;

public class JunkFly : ObjectFly
{
    protected override void OverridingValue()
    {
        base.OverridingValue();
        moveSpeed = 3;
        direction = Vector3.left;
    }
}
