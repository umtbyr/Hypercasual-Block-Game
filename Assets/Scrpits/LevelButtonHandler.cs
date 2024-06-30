using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButtonHandler : MonoBehaviour
{

    public static LevelButtonHandler Instance;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;   
        }

        //DontDestroyOnLoad(this.gameObject);
    }


}
