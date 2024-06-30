using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialHandler : MonoBehaviour
{

    private float Max = 0.96294118f;
    private float Min = 0.2372549f;

    private float chancespeed = 1.5f;

    private float r = 0.96294118f;
    private float g = 0.2372549f;
    private float b = 0.237259f;

    //private Material mymaterial;

    private Renderer myRenderer;
   
    private void Start()
    {
        //mymaterial = GetComponent<Material>();
        myRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        //mymaterial.color = new Color(r,g,b);
        myRenderer.material.color = new Color(r, g, b);


    /*
        if (r >= 1f)
        {
            
            b += 0.01f;
            if(b >= 1f)
            {
                r -= 0.01f;
                if(r <= 0f)
                {
                    g += 0.01f;
                    if(g >= 1f)
                    {
                        b -= 0.01f;
                        if(b <= 0f)
                        {
                            r += 0.01f;
                            if(r >= 1f)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    */

        if(r>=Max && g<=Min )
        {
           
            if (b <= Max)
            {
                b += chancespeed* Time.deltaTime;
            }
           
        }
        if(g<=Min && b >= Max)
        {
            if(r >= Min)
            {
                r -= chancespeed * Time.deltaTime;
            }
                             
            
            
        }
        if( r<=Min  && b >= Max)
        {
            if(g <= Max)
            {
                g += chancespeed * Time.deltaTime;
            }
            
        }
        if(r<=Min && g >=Max)
        {
            if(b >= Min)
            {
                b -= chancespeed * Time.deltaTime;
            };
            
        }
        if( g>=Max && b <= Min)
        {
            if(r <= Max)
            {
                r += chancespeed * Time.deltaTime;
            }
           
        }
        if(r>=Max && b <= Min)
        {
            if(g>=Min){
                {
                    g -= chancespeed * Time.deltaTime;
                }
            }
        }




        Debug.Log($"{r},{g},{b}");
        
    }



}
