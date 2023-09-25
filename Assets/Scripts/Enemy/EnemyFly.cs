using UnityEngine;

public class EnemyFly : ObjectFly
{
    protected override void OverridingValue()
    {
        moveSpeed = 7;
        direction = Vector3.left;
    }
}
