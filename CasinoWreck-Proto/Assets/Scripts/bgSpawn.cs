using UnityEngine;

public class bgSpawn : MonoBehaviour
{
    [SerializeField]
    private Texture2D _backgroundImg;
    [SerializeField]
    private Texture2D _floorImg;
    [SerializeField]
    private GameObject _player;
    void Start()
    {
        this.transform.position = _player.transform.position;
    }

    void Update()
    {
        
    }
}
