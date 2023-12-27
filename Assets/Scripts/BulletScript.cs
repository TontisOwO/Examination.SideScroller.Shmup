using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public BoxCollider2D myBoxCollider;
    public Animator myAnimator = null;
    public float MovementSpeed = 175.0f;
    public float DestructionTime = 3.0f;
    public float Animation = 0.0f;
    public bool Bullethit = false;
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
        var EnemyHit = collision.gameObject.GetComponent<EnemyController>();
        if (EnemyHit != null)
        {
            myAnimator.SetBool("BulletHit", true);
            MovementSpeed = 0;
            Bullethit = true;
        }
    }
}
