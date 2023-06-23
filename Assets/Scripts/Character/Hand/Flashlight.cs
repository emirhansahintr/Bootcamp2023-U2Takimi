using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private Raycast raycast;
    [SerializeField] private GameObject spotlight;
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && raycast.flash_enabled)
        {
            if (spotlight.activeInHierarchy)
            {
                spotlight.SetActive(false);
                //Ses
            }
            else
            {
                spotlight.SetActive(true);
                //Ses
            }
        }
    }
}
