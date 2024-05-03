using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{

    public GameObject startPoint;
    public GameObject endPoint;
    public int speed = 2;
    private Rigidbody2D rb;
    private Transform currentPos;
    private Arcade Arcade;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPos = endPoint.transform;
    }

    private void Update()
    {
        Vector2 point = currentPos.position - transform.position;
        if (currentPos == endPoint.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPos.position) < 0.5f && currentPos == endPoint.transform)
        {
            currentPos = startPoint.transform;
        }

        if (Vector2.Distance(transform.position, currentPos.position) < 0.5f && currentPos == startPoint.transform)
        {
            currentPos = endPoint.transform;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        try
        {
            if (collision.GetComponent<Arcade>().isBreaking)
            {
                Debug.Log("AAA");
            }

            else
            {
                return;
            }
        }

        catch
        {
            return;
        }
        
    }
    
}
