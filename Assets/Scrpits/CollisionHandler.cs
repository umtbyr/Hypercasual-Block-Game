using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject p;

    private PlayerMovoment pmv;

    [SerializeField] private Material cubeMaterial;
   
    public static bool isDead = false;
    private Animator animator;

    private int extraLifeUsed;
    public static bool ispressed = false;
    public  static bool newDead = true;

    [SerializeField] Button replayButton;

    

    private void Awake()
    {
        animator = GameObject.Find("BackGroundImage").GetComponent<Animator>();
    }


    private void Start()
    {
        
        extraLifeUsed = PlayerPrefs.GetInt("extraLife");
        
        replayButton.onClick.AddListener(() => { ispressed = true; });
        pmv = p.GetComponent<PlayerMovoment>();

  
    }

    private void Update()
    {
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        isDead = true;
        if (other.CompareTag("Obstacle") && newDead)
        {
            
            if(PlayerPrefs.GetInt("extraLife") == 1)
            {
                SoundHandler.deadSound();
                animator.SetBool("isActiveMenu", isDead);
                gameObject.SetActive(false);
                p.SetActive(false);
                Debug.Log("hi");
                GameOver(4.5f);
                
                
            }
            else
            {
                SoundHandler.deadSound();
                Debug.Log("elseif");
                gameObject.SetActive(false);
                p.SetActive(false);
                GameOver(2f);
            }

        }
        if (other.CompareTag("Point"))
        {
            SoundHandler.getPointSound();
            pmv.Point();
            Destroy(other.gameObject);
        }
       
    }
    public void GameOver(float sec)
    {
        DestroyAnimation();
        Invoke("MenuLoader",sec);
    }






    public void GameOverWall()
    {
        
        Invoke("MenuLoader", 2f);
    }


    private void MenuLoader()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void DestroyAnimation()
    {
        Vector3 tempPos = transform.position;
        tempPos.z += 2f;
        tempPos.y += 0.5f;
        for (int i = 0; i < 12; i++)
        {

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Rigidbody rb = cube.AddComponent<Rigidbody>();
            if(i > 6)
            {
                cube.transform.position = tempPos;
            }
            else
            {
                cube.transform.position = transform.position;
            }

            cube.GetComponent<Renderer>().material = cubeMaterial;
            
        }

    }

   public void InvokeCanceler()
    {
        CancelInvoke();

    }





}
