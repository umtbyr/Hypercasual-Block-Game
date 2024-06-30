using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenuHandler : MonoBehaviour
{


    [SerializeField] private Canvas playAgainCanvas;
    [SerializeField] private Canvas levelMenuCanvas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OpenLevelMenu()
    {
        playAgainCanvas.enabled = false;
        levelMenuCanvas.enabled = true;
        
        
    }

    public void backToPlayMenu()
    {
        levelMenuCanvas.enabled = false;
        playAgainCanvas.enabled = true;
    }

    


}
