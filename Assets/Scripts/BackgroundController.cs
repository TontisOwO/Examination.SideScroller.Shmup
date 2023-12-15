using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float MovementSpeed = 50;
    public float OriginalPossition = 329.0f;
    public float Endpossition = -329.0f;
    void FixedUpdate()
    {
        Vector3 characterPosition = gameObject.transform.position;
        characterPosition.x -= MovementSpeed * Time.deltaTime;
        if (characterPosition.x < Endpossition)
        {
            characterPosition.x = OriginalPossition;
        }
        gameObject.transform.position = characterPosition;

    }
}
