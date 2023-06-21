using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private LayerMask selectableObject;
    [SerializeField] private float distance = 3.5f;
    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distance, selectableObject))
        {
            var selection = hit.transform;

            Debug.Log(selection.gameObject.name);

            if (Input.GetMouseButtonDown(0))
            {
                Destroy(selection.gameObject);
            }

        }

    }
}
