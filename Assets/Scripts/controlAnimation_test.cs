using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAnimation_test : MonoBehaviour
{
    public float speed;
    public OSC osc;

    void Start()
    {
        osc.SetAddressHandler("/speed", setSpeed);
        osc.SetAddressHandler("/color", setColor);
    }

    void Update()
    {

    }

    void setSpeed(OscMessage message)
    {
        speed = message.GetFloat(0);
        Debug.Log(speed);
    }

    void setColor(OscMessage message)
    {
        float x = message.GetFloat(0);
        Debug.Log("setcolor");
    }
}
