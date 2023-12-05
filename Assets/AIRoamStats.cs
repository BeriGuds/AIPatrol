using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AIStats", menuName = "ScriptableObject/AI")]
public class AIRoamStats : ScriptableObject
{
    public float healthPoints = 50f;
    public float speed = 2.5f;
    public float fov = 160f;
}
