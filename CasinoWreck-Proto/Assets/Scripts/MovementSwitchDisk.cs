using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSwitchDisk : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _diskArray;
    [SerializeField]
    private int _diskIndex;
    [SerializeField]
    private float _speed = 2f;
    private float _lBound = -20f;
    private float _rBound = 13f;

    void Start()
    {
        _diskIndex = 0;
        foreach(GameObject it in _diskArray) {
            it.transform.position = new Vector2(Random.Range(_lBound, _rBound), it.transform.position.y);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _diskIndex += 1;
            if (_diskIndex >= _diskArray.Length)
            {
                _diskIndex = 0;
            }
        }
        if (Input.GetKey(KeyCode.A) && _diskArray[_diskIndex].transform.position.x > _lBound)
        {
            _diskArray[_diskIndex].transform.Translate(Vector2.left * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.D) && _diskArray[_diskIndex].transform.position.x < _rBound)
        {
            _diskArray[_diskIndex].transform.Translate(Vector2.right * Time.deltaTime * _speed);
        }
    }
}
