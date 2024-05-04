using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;

    private Vector2 direction = Vector2.right;
    public float speed = 10;

    [Header("CameraFollow")]
    public GameObject cam;
    [SerializeField]
    private float _camOffset = 2f;

    [Header("Controls")]
    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode moveLeftAlt = KeyCode.LeftArrow;
    public KeyCode moveRightAlt = KeyCode.RightArrow;
    private int KeyMode = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (KeyMode == 1)
        {
            if (Input.GetKey(moveLeft))
            {
                setDirection(Vector2.left);
            }

            else if (Input.GetKey(moveRight))
            {
                setDirection(Vector2.right);
            }
            else
            {
                setDirection(Vector2.zero);
            }
        }
        else if (KeyMode == 0)
        {
            if (Input.GetKey(moveLeftAlt))
            {
                setDirection(Vector2.left);
            }

            else if (Input.GetKey(moveRightAlt))
            {
                setDirection(Vector2.right);
            }
            else
            {
                setDirection(Vector2.zero);
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab))              //To change keycontrols from wasd to arrow keys
        {
            KeyMode = 1 - KeyMode;
        }
        
        if (this.transform.position.x <= 0) {
            this.transform.position = new Vector2(0, this.transform.position.y);
        }
        cam.transform.position = new Vector3(transform.position.x, transform.position.y + _camOffset, cam.transform.position.z);

    }

    private void FixedUpdate()
    {
        Vector2 position = rb.position;
        Vector2 displacement = direction * speed * Time.deltaTime;

        rb.MovePosition(position + displacement);
    }

    private void setDirection(Vector2 newDirection)
    {
        direction = newDirection;
    }
}
