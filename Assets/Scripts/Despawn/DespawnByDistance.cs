using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected float disLimit = 15f;
    [SerializeField] private float distance = 0f;
    [SerializeField] protected Camera mainCam;

    protected override void LoadComponents()
    {
        LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (mainCam != null) return;
        mainCam = Transform.FindObjectOfType<Camera>();
    }

    protected override bool IsDespawn()
    {
        distance = Vector3.Distance(transform.parent.position, mainCam.transform.position);
        if (distance > disLimit) return true;
        return false;
    }

}
