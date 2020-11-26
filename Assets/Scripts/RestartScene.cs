using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    
    void Start()
    {
        
    }
        
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    
}
