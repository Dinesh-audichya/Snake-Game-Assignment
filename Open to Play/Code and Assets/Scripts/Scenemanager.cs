using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenemanager : MonoBehaviour
{
    public GameObject Score;
    public GameObject startscrn;
    public GameObject gmovr;
    public Text points;
    int pts = 0;




    void Start()
    {
        Time.timeScale = 0f;
    }

    // Start is called before the first frame update
   
    public void rpts()
    {
        pts = 0;
        Debug.Log("Ye Snack ne call kiya");
        points.text = "" + pts;
    }

    public void startgame()
    {
        Time.timeScale = 1f;
        GameObject.Find("start").SetActive(false);
        Score.SetActive(true); 
        Debug.Log("Ye start game ne call kiya");
        pts = 0;
        points.text = "" + pts;
    }


    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        pts = 0;
        points.text = "" + pts;
    }

    public void Getpts()
    {
        Debug.Log("Ye Get Point ne call kiya");
        pts += 1;
        points.text = "" + pts; 
        
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
