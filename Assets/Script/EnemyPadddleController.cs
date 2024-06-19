    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPadddleController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 3f;
    public Vector2 limits = new Vector2(-15f, 15f);

    private GameObject ball;


    private void Start()
    {
            rb = GetComponent<Rigidbody2D>();
        ball = GameObject.Find("Ball");
    }

    void Update()
    {
       if (ball != null) 
        
        {
            float targetY = Mathf.Clamp(ball.transform.position.y, limits.x , limits.y);
            Vector2 targetPosition = new Vector2(transform.position.x, targetY);
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
        
        } 
    }

}
