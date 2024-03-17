using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{

    public string nextSceneName;

    public void SwitchScene()
    {
        
            Invoke("Switch", 0f);
        
    }
    void Switch()
    {
        SceneManager.LoadScene(nextSceneName);
    }

}
