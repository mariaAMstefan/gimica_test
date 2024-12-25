using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFX_Open : MonoBehaviour
{
    public ParticleSystem VFX_open;
    public ParticleSystem VFX_glow;
    void VFX_Trigger()
    {
        VFX_open.Play();
        Debug.Log("You will receive a gift");
    }
    void VFX_Glow()
    {
        VFX_glow.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
