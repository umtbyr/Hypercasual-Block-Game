using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointHandlerUI : MonoBehaviour
{
    [SerializeField] private float rotationMultiplyer;

    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


        transform.Rotate(rotationMultiplyer * Time.deltaTime, rotationMultiplyer * Time.deltaTime, rotationMultiplyer * Time.deltaTime);



    }
}
