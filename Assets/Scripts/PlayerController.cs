using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public GameObject BulletPrefab;

    public PlayerData CurrentPlayerData = null;

    public TextMeshProUGUI HPText = null;
    public TextMeshProUGUI PointText = null;
    public float MovementSpeed = 100.0f;
    public float NextBulletCapability = 0.2f;

    void Update()
    {
        HPText.text = "HP:" + CurrentPlayerData.HP;
        PointText.text = "Points:" + CurrentPlayerData.Points;
        Vector3 PlayerPos = myRigidbody.position;

        if (Input.GetKey(KeyCode.W) && PlayerPos.y <= 138)
        {
            PlayerPos.y += MovementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) && PlayerPos.y >= -138)
        {
            PlayerPos.y -= MovementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) && PlayerPos.x >= -185.4f)
        {
            PlayerPos.x -= MovementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) && PlayerPos.x <= 185.4f)
        {
            PlayerPos.x += MovementSpeed * Time.deltaTime;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && NextBulletCapability < 0.0f)
        {
            GameObject.Instantiate(BulletPrefab,this.transform.position + new Vector3(15,0,0),BulletPrefab.transform.rotation);
            NextBulletCapability = 0.2f;
        }
        gameObject.transform.position = PlayerPos;
        NextBulletCapability -= Time.deltaTime;
    }
}
