using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class CurrentDate : MonoBehaviour
{
    [SerializeField] TMP_Text currentTime;

    void Update()
    {
        currentTime.text = DateTime.Now.ToLongDateString(); // date and time (day/month/year)
    }                                
}