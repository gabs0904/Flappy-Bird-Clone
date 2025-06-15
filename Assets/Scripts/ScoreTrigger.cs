using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public Score score;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collided with the score zone");
        if (other.CompareTag("Player"))
        {
            score.AddPoint();
            Debug.Log("Score is now: " + score.score);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
