using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleInteract : MonoBehaviour
{
    [SerializeField]
    private GameObject _ticketSystemObject;
    private UnifiedStorage _ticketsSystem;
    // Start is called before the first frame update
    void Start()
    {
        _ticketsSystem = _ticketSystemObject.GetComponent<UnifiedStorage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _ticketsSystem.TicketSet(5);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log(_ticketsSystem.TicketGet());
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene(1);
        }
    }

}
