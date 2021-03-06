using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public float seconds = 5.0f;
    public GameObject Bullet;

    void FixedUpdate()
    {
        Destroy(Bullet, seconds);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
