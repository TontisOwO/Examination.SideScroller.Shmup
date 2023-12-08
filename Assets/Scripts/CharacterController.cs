using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float MovementSpeedPerSecond = 100.0f;

    void Update()
    {
        Vector3 characterPosition = gameObject.transform.position;
        if (Input.GetKey(KeyCode.W) && characterPosition.y <= 138)
        {
            characterPosition.y += MovementSpeedPerSecond * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) && characterPosition.y >= -138)
        {
            characterPosition.y -= MovementSpeedPerSecond * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) && characterPosition.x >= -185.4f)
        {
            characterPosition.x -= MovementSpeedPerSecond * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) && characterPosition.x <= 185.4f)
        {
            characterPosition.x += MovementSpeedPerSecond * Time.deltaTime;
        }
        gameObject.transform.position = characterPosition;
    }
}
