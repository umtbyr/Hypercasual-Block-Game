using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButtonHandler : MonoBehaviour
{


    [SerializeField] GameObject Soundhandlr;
    [SerializeField] Sprite soundOn;
    [SerializeField] Sprite soundOff;
    private int isMuted;


    // Start is called before the first frame update
    void Start()
    {
        isMuted = PlayerPrefs.GetInt("isMuted", 1);
        if(isMuted == 0)
        {
            SoundOn();
        }
        if(isMuted == 1)
        {
            mute();
        }    
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("isMuted"));
    }

    public void onClick()
    {
        if (PlayerPrefs.GetInt("isMuted") == 1)
        {
            SoundOn();
            Debug.Log("WORKS");
        }
        else if(PlayerPrefs.GetInt("isMuted") == 0)
        {
            Debug.Log("Wokrs2");
            mute();
        }
    }

    public void mute()
    {
        gameObject.GetComponent<Image>().sprite = soundOff;
        Soundhandlr.SetActive(false);
        PlayerPrefs.SetInt("isMuted", 1);
    }
    public void SoundOn()
    {
        gameObject.GetComponent<Image>().sprite = soundOn;
        Soundhandlr.SetActive(true);
        SoundHandler.soundbuttonSound();
        PlayerPrefs.SetInt("isMuted", 0);
    }
}
