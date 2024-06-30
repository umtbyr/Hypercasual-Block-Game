using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadMenuHandler : MonoBehaviour

{
    
    [SerializeField] Image deadmenu;
    [SerializeField] GameObject deadmenuContainer;
    private Animator animator;
    private Image im;

    [SerializeField] GameObject[] cubes;
    [SerializeField] GameObject P;

    private int TotalPoint; 
    
    void Start()
    {
        TotalPoint = PlayerMovoment.TotalPoint;
        deadmenu.enabled = false;
        animator = GameObject.Find("BackGroundImage").GetComponent<Animator>();
        
        for(int i = 1;i < cubes.Length; i++)
        {
            cubes[i].SetActive(false);
        }
       



    }

    // Update is called once per frame
    void Update()
    {
        

        if (deadmenu.enabled && PlayerPrefs.GetInt("extraLife")==1)
        {
            Debug.Log("works");
            for (int i = 0; i < cubes.Length; i++)
            {
                
                cubes[i].GetComponent<CollisionHandler>().CancelInvoke();
            }
        }
        
    }



    public void makeImmortal()
    {

        for(int i = 0; i < cubes.Length; i++)
        {
            
            cubes[i].GetComponent<BoxCollider>().isTrigger = true;
        }
        
    }
    public void makeMortal()
    {
        CollisionHandler.newDead = true;
        PlayerPrefs.SetInt("extraLife", 0);
    }

    

    public void extraLifeButton()
    {
        if (PlayerMovoment.TotalPoint >= ExtraLifeButtonHandler.extraLifeCost)
        {
            SoundHandler.extraLifeSou();
            PlayerMovoment.TotalPoint-=ExtraLifeButtonHandler.extraLifeCost;
            PlayerPrefs.SetInt("TotalPoint", PlayerMovoment.TotalPoint);
            CollisionHandler.newDead = false;

            deadmenu.enabled = true;
            deadmenuContainer.SetActive(false);
            //makeImmortal();
            P.SetActive(true);
            cubes[0].SetActive(true);

            Invoke("makeMortal", 1f);

        }

    }


}
