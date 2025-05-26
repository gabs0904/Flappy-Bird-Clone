using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePair : MonoBehaviour
{
    public Transform topObstacle;
    public Transform bottomObstacle;
    public float gapSize = 5.5f;

  /*  Don't need this anymore
    void Awake()
    {
        topObstacle = transform.Find("TopObstacle");
        bottomObstacle = transform.Find("BottomObstacle");
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        PositionObstacles();  
    }

    void PositionObstacles()
    {
        topObstacle.localPosition = new Vector3(0, gapSize / 2f, 0);
        bottomObstacle.localPosition = new Vector3(0, -gapSize / 2f, 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
