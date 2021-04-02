using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclemovement : MonoBehaviour
{
    [Range(0.0f, 10.0f)]
    public float velocidadx = 2;
    [Range(0.0f, 10.0f)]
    public float distanciax = 2;
    [Range(0.0f, 10.0f)]
    public float velocidady = 2;
    [Range(0.0f, 10.0f)]
    public float distanciay = 2;
    [Range(0.0f, 10.0f)]
    public float velocidadz = 2;
    [Range(0.0f, 10.0f)]
    public float distanciaz = 2;
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        transform.position = startPosition + new Vector3(distanciax*Mathf.Sin(velocidadx*Mathf.PI*0.5f*time), distanciay * Mathf.Cos(velocidady * Mathf.PI * 0.5f * time), distanciaz * Mathf.Sin(velocidadz * Mathf.PI * 0.5f * time));
    }
}
