using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mhlink : MonoBehaviour
{
    public void OpenLink(string Urlname){
        Application.OpenURL(Urlname);
    }
}
