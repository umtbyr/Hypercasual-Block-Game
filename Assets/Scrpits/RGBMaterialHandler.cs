using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGBMaterialHandler : MonoBehaviour
{

    private float Min = 0.66666667f;
    private float Max = 1f;

    [SerializeField] private float chanceingSpeed = 0.4f;

    private float r = 1f;
    private float g = 0.6f;
    private float b = 0.66666667f;

    private Renderer myRenderer;
    private bool isMax = false;
    private bool isMin = true;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        myRenderer.material.color = new Color(r, g, b);


        if (isMax)
        {
            b -=chanceingSpeed * Time.deltaTime;
            if (b <= Min)
            {
                isMax = false;
                isMin = true;
            }
        }
        if (isMin)
        {
            b += chanceingSpeed * Time.deltaTime;
            if(b >= Max) { 
                isMin = false;
                isMax = true;
            }
        }


        
    }
}
