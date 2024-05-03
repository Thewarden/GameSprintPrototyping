using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcade : MonoBehaviour
{
    public GameObject indicator;
    public bool isBreaking = false;     //Check to see if the the arcade is being broken
    public bool isPlaying = false;      //Check to see if the arcade is being played
    public bool isBroken = false;       //Check to see if the arcade is broken
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (indicator.activeSelf && Input.GetKeyDown(KeyCode.Space) && !isPlaying && !isBroken)     //If near the machine and space is pressed and currently not playing any game and the arcade is not broken
        {
            Debug.Log("Breaking");
            isBreaking = true;
            Invoke("Breaking", 5);
        }

        else if(!isBreaking && !isBroken && indicator.activeSelf && Input.GetKeyDown(KeyCode.E))        //If near the machine and E is pressed and currently not breaking and the arcade is not broken
        {
            isPlaying = true;
        }

        //Debug.Log(isBreaking);
    }

    public void Breaking()
    {
        isBreaking = false;
        isBroken = true;
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
