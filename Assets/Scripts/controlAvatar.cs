using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAvatar : MonoBehaviour
{
    public bool changeMaterials = false;
    public Material mat;

    private bool oldChangeBool = false;
    public Material[] originalMats;
    private Renderer smr;

    void Start()
    {
        smr = this.GetComponentInChildren<Renderer>();
        originalMats = smr.materials;
    }

    void Update()
    {
        if (changeMaterials != oldChangeBool)
        {
            if (changeMaterials == true)
            {
                Debug.Log("SetMat");
                oldChangeBool = true;

                Material[] mats = smr.materials;
                mats[0] = mat;
                mats[1] = mat;
                mats[2] = mat;
                smr.materials = mats;

            }
            else
            {
                oldChangeBool = false;
                smr.materials = originalMats;
            }
        }
    }

    public void setScale(float x)
    {
        gameObject.transform.localScale = new Vector3(x, x, x);
    }
}
