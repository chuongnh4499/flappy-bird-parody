using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] protected GameObject bulletPrefab;
    [SerializeField] protected Transform shootingPoint;

    void FixedUpdate()
    {
        Shooting();
    }

    protected void Shooting()
    {
        if (InputManager.Instance.IsClickedMouseLeft) {
            Instantiate(bulletPrefab, shootingPoint.transform.position, Quaternion.identity);
            
            InputManager.Instance.IsClickedMouseLeft = false;
        };

    }

}
