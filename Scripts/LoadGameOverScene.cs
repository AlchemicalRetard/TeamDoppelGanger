using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameOverScene : MonoBehaviour
{
    void Update()
    {
        if(Time.timeScale == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
