using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SlotsScript : MonoBehaviour
{
    // Start is called before the first frame update
    char[] easyNum = { '0', '1' };
    char[] medNum = { '0', '1', '2', '3', '4' };
    char[] hardNum = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    char[] Num;
    public TMP_Text slotNum;
    public float time;
    private int index;
    void Start()
    {
        slotNum = GetComponent<TMP_Text>();
        Num = hardNum;
    }

    // Update is called once per frame
    void Update()
    {
        //slotNum.text = Num[index%10].ToString();
        //index++;
        slotNum.text = Num[Random.Range(0, Num.Length)].ToString();
    }

    public void setEasy()
    {
        index = 0;
        Num = easyNum;
    }

    public void setMedium()
    {
        index = 0;
        Num = medNum;
    }

    public void setHard()
    {
        index = 0;
        Num= hardNum;
    }

    public void On()
    {
        enabled = true;
        Invoke("Off", 5);
    }

    public void Off()
    {
        Invoke("DelayNum", time);
    }

    public void DelayNum()
    {
        enabled = false;
    }
}
