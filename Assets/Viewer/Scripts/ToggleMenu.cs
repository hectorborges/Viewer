using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    public Animator animator;
    public GameObject openImage;
    public GameObject closeImage;

    public bool opened;

    bool triggered;

    public void Toggle()
    {
        if(!triggered)
        {
            triggered = true;
            animator.SetTrigger("Triggered");
        }
        opened = !opened;
        openImage.SetActive(!opened);
        closeImage.SetActive(opened);
        animator.SetBool("Opened", opened);
    }
}
