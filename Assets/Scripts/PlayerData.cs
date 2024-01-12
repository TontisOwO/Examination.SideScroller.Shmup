using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerData", menuName = "MY STUFF")]
public class PlayerData : ScriptableObject
{
    public float HP = 3.0f;
    public float Points = 0.0f;
    public int CurrentLevel = 0;
    public int TotalEnemiesKilled = 0;
    public float PointsGained = 0;
}
