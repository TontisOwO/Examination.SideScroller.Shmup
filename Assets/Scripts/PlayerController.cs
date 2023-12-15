using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject BulletPrefab;

    public PlayerData CurrentPlayerData = null;

    public TextMeshProUGUI HPText = null;
    public TextMeshProUGUI PointText = null;
    public float MovementSpeed = 100.0f;

    void Update()
    {
        HPText.text = "HP:" + CurrentPlayerData.HP;
        PointText.text = "Points:" + CurrentPlayerData.Points;
        Vector3 PlayerPos = gameObject.transform.position;

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
        gameObject.transform.position = PlayerPos;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Instantiate(BulletPrefab,this.transform.position,BulletPrefab.transform.rotation);
        }
    }
}
