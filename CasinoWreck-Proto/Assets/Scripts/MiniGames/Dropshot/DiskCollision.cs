using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskCollision : MonoBehaviour
{
    [SerializeField]
    private GameObject _diskSwitch = null;
    private MovementSwitchDisk _diskScript;

    void Start()
    {
        _diskScript = _diskSwitch.GetComponent<MovementSwitchDisk>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ForkBase")
        {
            _diskScript.SetFallFalse();
        }
    }
}
