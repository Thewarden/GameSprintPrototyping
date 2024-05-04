using UnityEngine;

public class UnifiedStorage : MonoBehaviour
{
    private static int _tickets = 0;
    void Start()
    {

    }

    void Update()
    {
        
    }
    public void TicketSet(int val)
    {
        _tickets += val;
    }
    public int TicketGet()
    {
        return _tickets;
    }
}
