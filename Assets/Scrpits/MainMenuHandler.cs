using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{

    [SerializeField] private GameObject UIElements;

    [SerializeField] private Text TotalText;

    [SerializeField] private Text scoreText;

    [SerializeField] private Text CurrentLevelText;
    public static int loadedscene = 1;

    private static int currentLevel;

    private void Start()
       {
        
        PlayerPrefs.SetInt("extraLife", 1);
        
         currentLevel = PlayerPrefs.GetInt("currentLevel", 1);

        loadedscene = currentLevel;

        if(PlayerMovoment.point != 0) { scoreText.text = PlayerMovoment.point.ToString(); }
        if(PlayerMovoment.TotalPoint == 0)
        {
            TotalText.text = PlayerPrefs.GetInt("TotalPoint").ToString();
        }
        else
        {
            TotalText.text = PlayerMovoment.TotalPoint.ToString();
        }
        UIElements.SetActive(true);

        CurrentLevelText.text = $"LEVEL {loadedscene}";
        
    }
    

    public void PlayAgain()
    {
        SoundHandler.PlaybuttonSound();
        UIElements.SetActive(false);
        PlayerMovoment.point = 0;
        Invoke("loadscenefunct", 0.9f);
        
        
       
    }

    private void loadscenefunct()
    {
        SceneManager.LoadScene(loadedscene);
    }











}
