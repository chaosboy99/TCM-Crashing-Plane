using UnityEngine;

public class DestroyOnBecomeInvisible : MonoBehaviour
{
private void OnTriggerEnter2D (Collider2D other)
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
