using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headbob : MonoBehaviour
{
    [Range(0.001f, 0.01f)]
    [SerializeField] private float Amount = 0.003f;
    [Range(1f, 30f)]
    [SerializeField] private float Frequency = 15.0f;
    [Range(5f, 100f)]
    [SerializeField] private float Smooth = 18.0f;


    [SerializeField] Movement movement;
    private void Update()
    {
        if (movement.speed > 5f)
        {
            Smooth = 35f;
        }
        else if (movement.speed < 4f)
        {
            Smooth = 5f;
        }
        else
        {
            Smooth = 18f;
        }
        HeadbobTrigger();
    }

    private void HeadbobTrigger()
    {
        float inputMagnitude = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).magnitude;
        if (inputMagnitude > 0.0f)
        {
            HeadbobStart();
        }
    }
    private Vector3 HeadbobStart()
    {
        Vector3 position = Vector3.zero;
        position.y += Mathf.Lerp(position.y, Mathf.Sin(Time.time * Frequency) * Amount * 1.4f, Smooth * Time.deltaTime);
        position.x += Mathf.Lerp(position.x, Mathf.Cos(Time.time * Frequency / 2f) * Amount * 1.6f, Smooth * Time.deltaTime);
        transform.localPosition += position;
        return position;
    }
}
