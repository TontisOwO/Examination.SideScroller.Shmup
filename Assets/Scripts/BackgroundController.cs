using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float MovementSpeed = 50;
    public float OriginalPossition = 329.0f;
    public float Endpossition = -329.0f;
    private void Start()
    {
        SetRatio(4, 3);
    }
    void SetRatio(float w, float h)
    {
        if ((((float)Screen.width) / ((float)Screen.height)) > w / h)
        {
            Screen.SetResolution((int)(((float)Screen.height) * (w / h)), Screen.height, true);
        }
        else
        {
            Screen.SetResolution(Screen.width, (int)(((float)Screen.width) * (h / w)), true);
        }
    }
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
