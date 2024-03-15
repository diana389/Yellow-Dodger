using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * 5;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * 5;

        transform.Translate(xValue, 0, zValue);
    }
}
