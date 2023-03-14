using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagivationAnimate : MonoBehaviour
{
    public GameObject PanelMenu;

    public void OpenCloseMenu()
    {
        if(PanelMenu != null)
        {
            Animator animator = PanelMenu.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Show-Menu");
                animator.SetBool("Show-Menu",!isOpen);
            }
        }
    }
}
