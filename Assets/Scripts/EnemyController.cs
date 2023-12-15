using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public PlayerData CurrentPlayerData = null;
    public float MovementSpeed = 75;
    void Update()
    {
        Vector3 EnemyPos = transform.position;
        EnemyPos.x -= MovementSpeed * Time.deltaTime;
        transform.position = EnemyPos;
    }
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag.Equals("Bullet") == true)
        {
            CurrentPlayerData.Points += 100.0f;
        }
        else
        {
            DealDamage();
        }
        GameObject.Destroy(gameObject);
    }
    private void DealDamage()
    {
        CurrentPlayerData.HP -= 1.0f;
    }
}
