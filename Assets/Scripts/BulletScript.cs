using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float MovementSpeed = 175.0f;
    public float DestructionTime = 110.0f;
    void FixedUpdate()
    {
        DestructionTime -= 1.0f;
        Vector3 EnemyPos = transform.position;
        EnemyPos.x += MovementSpeed * Time.deltaTime;
        transform.position = EnemyPos;
        if (DestructionTime < 0)
        {
            GameObject.Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        var EnemyHit = collision.gameObject.GetComponent<EnemyController>();
        if (EnemyHit != null)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
