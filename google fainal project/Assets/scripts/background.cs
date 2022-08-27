using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public BoxCollider2D cal;
    public Rigidbody2D rb;
    public float weidth;
    private float scrollspeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        cal = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        weidth = cal.size.x;
        cal.enabled = false;
        rb.velocity = new Vector2( scrollspeed , 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -weidth)
        {
            Vector2 ResetPosition = new Vector2( weidth * 2f,0);
            transform.position = (Vector2)transform.position + ResetPosition;
        }
            
    }
}
