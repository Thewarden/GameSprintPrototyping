using UnityEngine;

public class bgSpawn : MonoBehaviour
{
    [SerializeField]
    private Sprite _backgroundImg;
    [SerializeField]
    private Sprite _floorImg;
    [SerializeField]
    private GameObject _player;
    private GameObject _bgImageObject;
    private float _bgZOffset = 5;
    private PlayerScript playerScript;
    private Transform playerTransform;

    private float _spawnX;
    private float _tileLength;
    private float _tileOffset;

    void Start()
    {
        playerScript = _player.GetComponent<PlayerScript>();
        playerTransform = playerScript.transform;
        this.transform.position = new Vector3(playerScript.cam.transform.position.x, playerScript.cam.transform.position.y, 0 + _bgZOffset);
        this.GetComponentInChildren<SpriteRenderer>().sprite = _backgroundImg;
        _bgImageObject = FindChildWithTag(this.gameObject, "BgImage");
        _bgImageObject.GetComponent<SpriteRenderer>().sprite = _backgroundImg;
    }

    void Update()
    {

    }

    GameObject FindChildWithTag(GameObject parent, string tag)
    {
        GameObject child = null;

        foreach (Transform transform in parent.transform)
        {
            if (transform.CompareTag(tag))
            {
                child = transform.gameObject;
                break;
            }
        }
        return child;
    }
}
