using UnityEngine;

public class DestroyOnBecomeInvisible : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
