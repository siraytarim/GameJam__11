using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public string hivescene="Kavanoz"; 

    public void SahneGecisiniBaslat()
    {
        SceneManager.LoadScene(hivescene); 
    }
}
