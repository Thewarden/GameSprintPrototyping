using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcade : MonoBehaviour
{
    public GameObject indicator;
    public bool isBreaking = false;
    public bool isPlaying = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (indicator.activeSelf && Input.GetKeyDown(KeyCode.Space) && !isPlaying)
        {
            Debug.Log("Breaking");
            isBreaking = true;
            Invoke("Breaking", 5);
        }

        else if(!isBreaking && indicator.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            isPlaying = true;
        }

        //Debug.Log(isBreaking);
    }

    public void Breaking()
    {
        isBreaking = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            indicator.SetActive(true);
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            indicator.SetActive(false);
        }
    }
}
