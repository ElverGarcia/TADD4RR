using System.Collections;
using System.Collections.Generic;
using UFE3D;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
   public GameObject Panel;

   
    
 


    public void OpenPanel()
    {
     

        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if(animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }
        }
    }
}
