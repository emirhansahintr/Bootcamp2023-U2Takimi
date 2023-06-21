using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;

            if (Input.GetMouseButtonDown(0) && selection.CompareTag(selectableTag) && hit.distance <= 3.5f)
            {
                Debug.Log(selection.gameObject.name);
                Destroy(selection.gameObject);
            }

        }

    }
}
