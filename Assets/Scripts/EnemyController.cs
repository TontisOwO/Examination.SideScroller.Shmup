using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public bool hitByBullet = false;
    public float HP = 1.0f;
    public float Damage = 1.0f;
    public float PointGain = 100.0f;
    public Rigidbody2D myRigidbody;
    public PlayerData CurrentPlayerData = null;
    public float MovementSpeed = 75;
    public bool isFriendly = false;
    public bool shoots = false;
    public float CanShoot = 0.0f;
    public GameObject EnemyBulletPrefab;
    void Update()
    {
        Vector3 EnemyPos = transform.position;
        EnemyPos.x -= MovementSpeed * Time.deltaTime;
        EnemyPos.z = -1;
        transform.position = EnemyPos;
        if (shoots == true)
        {
            CanShoot -= Time.deltaTime; 
            if(CanShoot < 0 && transform.position.x <= 210)
            {
                CanShoot = 1.75f;
                GameObject.Instantiate(EnemyBulletPrefab, this.transform.position + new Vector3(-15, 0, 0), EnemyBulletPrefab.transform.rotation);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag.Equals("Bullet") == true)
        {
            HP -= 1.0f;
            hitByBullet = true;
        }
        else
        {
            DealDamage();
            HP -= 1000;
            hitByBullet = false;
        }
        if (HP <= 0)
        {
            GameObject.Destroy(gameObject);
            CurrentPlayerData.TotalEnemiesKilled += 1;
            if (hitByBullet == true)
            {
                CurrentPlayerData.Points += PointGain;
                CurrentPlayerData.PointsGained += PointGain;
                if (isFriendly == true)
                {
                    CurrentPlayerData.HP += Damage;
                }
            }
        }
    }
    private void DealDamage()
    {
        CurrentPlayerData.HP -= Damage;
    }
}
