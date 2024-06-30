using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownFloor : MonoBehaviour
{

    GameObject p;
    CollisionHandler collhandler;
    [SerializeField] GameObject playercont;
    private void Start()
    {
        
        p = GameObject.Find("MainCube").gameObject;
        collhandler = p.GetComponent<CollisionHandler>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playercont.SetActive(false);
            other.gameObject.SetActive(false);
            p.SetActive(false);
            collhandler.GameOver(3f);
            Debug.Log("wall");
        }


    }
}
