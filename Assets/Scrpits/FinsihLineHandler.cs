using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinsihLineHandler : MonoBehaviour
{
    GameObject p;
    CollisionHandler ch;

    [SerializeField] Text youwinText;

    [SerializeField] ParticleSystem[] particalsyst;

    // Start is called before the first frame update
    

    void Start()
    {
        stopPartical();
       youwinText.enabled = false;
        p = GameObject.Find("MainCube").gameObject;
        gameObject.GetComponent<Renderer>().enabled = false;

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SoundHandler.finishSound();
            PlayerPrefs.SetInt("currentLevel", MainMenuHandler.loadedscene + 1);
            RunPartical();
            youwinText.enabled = true;
            Invoke("BackToMenu", 3f);

        }
    }

    private void BackToMenu()
    {
        SceneManager.LoadScene(0);

    }

    private void stopPartical()
    {
        for (int i = 0; i < particalsyst.Length; i++)
        {
            particalsyst[i].Stop();
        }
    }

    private void RunPartical()
    {
        for (int i = 0; i < particalsyst.Length; i++)
        {
            particalsyst[i].Play();
        }
    }


}
