using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel : MonoBehaviour
{
    public string levelName;
    
    public void ToLevel()
    {
        SceneManager.LoadScene(levelName);
    }
}
