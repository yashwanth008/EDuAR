using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackground : MonoBehaviour
{
    public Camera cam;
    public Dropdown mydropdown;


   
    // Update is called once per frame
    void Update()
    {
      switch (mydropdown.value)
        {
            case 1:
                cam.backgroundColor = Color.white;
                break;
            case 2:  
                cam.backgroundColor = Color.black;
                break;

        }
         
    }
    
}
  

