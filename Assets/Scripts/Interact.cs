using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Animator PresentAnimator;
    public Animator FlashAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            PresentAnimator.SetTrigger("Interact");
            FlashAnimator.SetTrigger("Interact");
        }
        if (Input.GetMouseButtonDown(1))
        {
            PresentAnimator.SetTrigger("Close");
        }
    }
}
