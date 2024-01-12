using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public BoxCollider2D myBoxCollider;
    public Animator myAnimator = null;
    public float MovementSpeed = 175.0f;
    public float DestructionTime = 2.2f;
    public float Animation = 0.0f;
    public bool Bullethit = false;
    public PlayerData CurrentPlayerData = null;
    void Update()
    {
        DestructionTime -= Time.deltaTime;
        Vector3 EnemyPos = transform.position;
        EnemyPos.x += MovementSpeed * Time.deltaTime;
        transform.position = EnemyPos;
        if (DestructionTime < 0)
        {
            GameObject.Destroy(gameObject);
        }
        if (Bullethit == true)
        {
            Animation += Time.deltaTime;
            GameObject.Destroy(myBoxCollider);
        }
        if (Animation >= 0.20f)
        {
            GameObject.Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        myAnimator.SetBool("BulletHit", true);
        MovementSpeed = 0;
        Bullethit = true;
        var PlayerScript = collision.gameObject.GetComponent<PlayerController>();
        if(PlayerScript == true)
        {
            CurrentPlayerData.HP -= 1;
        }
    }
}
