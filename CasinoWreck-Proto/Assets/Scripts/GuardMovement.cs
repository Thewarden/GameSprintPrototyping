using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
    public GameObject ahead;
    public GameObject StartPoint;
    public GameObject EndPoint;
    private Vector2 direction = Vector2.right;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ahead.transform.position == EndPoint.transform.position)
        {
            setDirection(-direction);
        }
        else if (ahead.transform.position == StartPoint.transform.position) //Change this to trigger and add collider2D to startPoint and endPoint.
        {
            setDirection(-direction);
        }
    }

    void setDirection(Vector2 dir)
    {
        direction = dir;
    }

    private void FixedUpdate()
    {
        

        rb.MovePosition(ahead.transform.position);
        ahead.transform.position += Vector3.right * 0.1f;

        
    }
}
