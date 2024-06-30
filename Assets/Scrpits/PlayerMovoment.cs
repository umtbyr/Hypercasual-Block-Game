using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovoment : MonoBehaviour
{
    [SerializeField]
    public  float walkSpeed = 10f;

    private float maxSpeed = 40f;
    private float speedUp = 1f;

    [SerializeField]
    public static int point = 0;
  
    private Transform cubesTransform;

    [SerializeField]
    private float turnMultiplayer = 200f;

    private int turndirection;
    private Rigidbody rb;

    private GameObject mainCube;
    private GameObject upCube;
    private GameObject leftCube;
    private GameObject rightCube;

    private bool isSplit = false;

    
    private Text PointText;

    private Button splitUp;
    private Button splitCorners;


    public static int TotalPoint;




    // Start is called before the first frame update
    void Start()
    {
        TotalPoint = PlayerPrefs.GetInt("TotalPoint");
        PointText = GameObject.Find("PointText").GetComponent<Text>();
        splitUp = GameObject.Find("SplitUpButton").GetComponent<Button>();
        splitCorners = GameObject.Find("SplitCornerButton").GetComponent<Button>();
        rb = GetComponentInChildren<Rigidbody>();
        mainCube = gameObject.transform.GetChild(0).gameObject;
        upCube = gameObject.transform.GetChild(1).gameObject;
        leftCube = gameObject.transform.GetChild(2).gameObject;
        rightCube = gameObject.transform.GetChild(3).gameObject;

      
        
    }

    // Update is called once per frame
    void Update()
    {
        PointUpdate();
        Walk();
    }

    private void Walk()
    {
        if(walkSpeed != maxSpeed)
        {
            walkSpeed += speedUp * Time.deltaTime;
        }
       
        
        transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);

        transform.Rotate(0f,turndirection * turnMultiplayer * Time.deltaTime,0f);
        
       
    }

   
    public void Turning(int turnvalue)
    {
        
        turndirection = turnvalue;

    }

    public void Jump()
    {
        turndirection = 0;
        rb.AddForce(new Vector3(1f, 1000f, 0f));
        Debug.Log("Jump");
    }


    public void PointUpdate()
    {
        string pointstring = $"{point}";
        PointText.text = pointstring;
    }



 

    public void SplitUp()
    {

        if (!isSplit)
        {
            mainCube.transform.localScale = new Vector3(6f, 2.5f, 2.5f);
            isSplit = true;
        }
        
        mainCube.SetActive(true);
        upCube.SetActive(true);
        leftCube.SetActive(false);
        rightCube.SetActive(false);

        splitUp.interactable = false;
        //splitCorners.interactable = false;

        Invoke("Idle", 2f);       
    }

    public void SplitCorners()
    {
        splitUp.interactable = false;
        splitCorners.interactable = false;


        mainCube.SetActive(false);
        upCube.SetActive(false); 

        leftCube.SetActive(true);
        rightCube.SetActive(true);

        Invoke("Idle", 2f);

    }

    public void Idle()
    {
        splitCorners.interactable = true;
        splitUp.interactable = true;

        mainCube.SetActive(true );
        leftCube.SetActive(false);
        rightCube.SetActive(false);
        upCube.SetActive(false);
        isSplit = false;

        mainCube.transform.localScale = new Vector3(10f, 5f, 5f);
    }

    public void Point()
    {
        point++;
        TotalPoint++;
        PlayerPrefs.SetInt("TotalPoint", TotalPoint);
    }
}

