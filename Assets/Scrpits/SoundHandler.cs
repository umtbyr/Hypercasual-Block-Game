using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    SoundHandler instance;
    /*
    [SerializeField] public  getPonitSound;
    [SerializeField] public AudioClip dieSound;
    [SerializeField] public AudioClip extraLifeSound;
    [SerializeField] public AudioClip winSound;
    */
    public static AudioSource dieSound;
    public static AudioSource extraLife;
    public static AudioSource getPoint;
    public static AudioSource finish;
    public static AudioSource soundbutton;
    public static AudioSource Playbutton;


    private void Awake()
    {
       
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        dieSound = transform.GetChild(0).GetComponent<AudioSource>();
        extraLife = transform.GetChild(1).GetComponent<AudioSource>();
        getPoint = transform.GetChild(2).GetComponent<AudioSource>();
        finish = transform.GetChild(3).GetComponent<AudioSource>();
        soundbutton = transform.GetChild(4).GetComponent<AudioSource>();
        Playbutton = transform.GetChild(5).GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void deadSound()
    {
        dieSound.Play();
    }

    public  static void getPointSound()
    { 
        getPoint.Play();
       
    }

    public  static void extraLifeSou()
    {
        extraLife.Play();
    }

    public static void finishSound()
    {
        finish.Play();
    }

    public static void soundbuttonSound()
    {
        soundbutton.Play();
    }

    public static void PlaybuttonSound()
    {
        Playbutton.Play();
    }


}
