using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;
    public float  followDistance = 5f;

    // Attack Logic by enemy to player
    public float attackDistance = 1f;
    public int Damage = 1;

    public float attackCooldown = 1f;
    private float lastAttackTime;

    void Update ()
    {
        if(player == null)
        {
            return;
        }
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance < followDistance)
    {
        Vector2 direction = (player.position - transform.position).normalized;
        transform.position += (Vector3)( direction * speed * Time.deltaTime);
    }

        // Attack Logic by enemy to player
        if (distance < attackCooldown && Time.time > lastAttackTime)
    {
            Attack();
            lastAttackTime = Time.time + attackCooldown;
    }
    }

    void Attack()
    {
        if (player == null)
        {
            return;
        }
        Debug.Log("Enemy Hit Player");
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();

        if (playerHealth != null) 
        {
            playerHealth.TakeDamage(Damage);
        }
    }

}
