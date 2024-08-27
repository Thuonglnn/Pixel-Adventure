using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void PlayGame()
{
 SceneManager.LoadScene("Man_chinh");
}



public void ReloadManchoi()
{
   SceneManager.LoadScene("Man_chinh");
   Time.timeScale = 1;
}

public void PauseGame()
{
    isPause = !isPause;
    if(isPause)
    {
        Time.timeScale = 0;
    }
    else
    {
        Time.timeScale = 1;
    }
}


public void Exit()
{
   SceneManager.LoadScene("Start");
   Time.timeScale = 1;
}

public void level1()
{
    SceneManager.LoadScene("Man_1");
   Time.timeScale = 1;
}
public void level2()
{
    SceneManager.LoadScene("Man_2");
   Time.timeScale = 1;
}
public void level3()
{
    SceneManager.LoadScene("Man_3_1");
   Time.timeScale = 1;
}
}
