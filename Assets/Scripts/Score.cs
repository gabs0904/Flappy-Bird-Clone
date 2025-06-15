using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Score SO")]
public class Score : ScriptableObject
{
    public int score = 0;

    public void AddPoint()
    {
        score++;
    }
}
