using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHandler : MonoBehaviour
{

    GameObject p;
    CollisionHandler collhandler;
    
    private void Start()
    {
        //gameObject.GetComponent<Renderer>().enabled = false;
        p = GameObject.Find("MainCube").gameObject;
        collhandler = p.GetComponent<CollisionHandler>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            //other.gameObject.SetActive(false);
            //p.SetActive(false);
            //collhandler.GameOver();
            Debug.Log("wall");
        }

        
    }
}
