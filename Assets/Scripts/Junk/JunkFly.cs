using UnityEngine;

public class JunkFly : ObjectFly
{
    protected override void OverridingValue()
    {
        moveSpeed = 7;
        direction = Vector3.left;
    }
}
