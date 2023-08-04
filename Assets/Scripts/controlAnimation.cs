using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAnimation : MonoBehaviour
{
    public float speed;
    public OSC osc;
    public controlAvatar controlAv;
    Animator m_Animator;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();

        osc.SetAddressHandler("/speed", setSpeed);
        osc.SetAddressHandler("/color", setColor);
        osc.SetAddressHandler("/scale", setScale);
    }

    void Update()
    {

    }

    void setSpeed(OscMessage message)
    {
        speed = message.GetFloat(0);
        m_Animator.speed = speed;
    }

    void setColor(OscMessage message)
    {
        float x = message.GetFloat(0);
        if (x == 0)
        {
            controlAv.changeMaterials = false;
        } else
        {
            controlAv.changeMaterials = true;
        }
    }

    void setScale(OscMessage message)
    {
        float x = message.GetFloat(0);
        controlAv.setScale(x);
    }
}
