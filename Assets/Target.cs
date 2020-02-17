using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 100f;
    public GameObject destroyedVersion;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
