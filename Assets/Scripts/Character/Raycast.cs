using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private LayerMask selectableObject;
    [SerializeField] private float distance = 3.5f;
    [SerializeField] private GameObject flashlight;
    public bool flash_enabled;

    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distance, selectableObject))
        {
            var selection = hit.transform;

            if (Input.GetMouseButtonDown(0))
            {
                if (selection.gameObject.CompareTag("Flashlight"))
                {
                    FlashlightOn();
                    Destroy(selection.gameObject);
                    //animation
                    //ses
                }

                if (selection.gameObject.CompareTag("Button1"))
                {
                    ElevatorButton1();
                    //animation
                }
                if (selection.gameObject.CompareTag("Paper"))
                {
                    PapersHistory();
                }

            }

        }

    }

    private void FlashlightOn()
    {
        flashlight.gameObject.SetActive(true);
        flash_enabled = true;
    }
    private void ElevatorButton1()
    {
        Debug.Log("Button1");
    }
    private void PapersHistory()
    {
        Debug.Log("Paper");
    }
}
