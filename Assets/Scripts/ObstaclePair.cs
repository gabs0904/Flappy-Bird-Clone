using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePair : MonoBehaviour
{
    public Transform topObstacle;
    public Transform bottomObstacle;
    public float gap = 3f;
    public float moveSpeed = 2f;

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;


        topObstacle.localPosition = new Vector3(0, gap / 2f, 0);
        bottomObstacle.localPosition = new Vector3(0, -gap / 2f, 0);

        PolygonCollider2D topCollider = topObstacle.gameObject.AddComponent<PolygonCollider2D>();
        PolygonCollider2D bottomCollider = bottomObstacle.gameObject.AddComponent<PolygonCollider2D>();
    }

    private void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
