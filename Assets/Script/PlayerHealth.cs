using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   public int health = 5;
    private bool isDead = false;
    public void TakeDamage(int damage)
    {
        if (isDead)
            return;
    
        health -= damage;
        Debug.Log("Player Health:" + health);

        if (health <= 0)
        {
            isDead = true;
            Debug.Log("PlayerDie");
            Destroy(gameObject);
        }
    }
}
