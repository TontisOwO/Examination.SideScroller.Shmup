using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float MovementSpeed = 125.0f;
    void Update()
    {
        Vector3 EnemyPos = transform.position;
        EnemyPos.x += MovementSpeed * Time.deltaTime;
        transform.position = EnemyPos;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Destroy(gameObject);
    }
}
