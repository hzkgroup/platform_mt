using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

public class MenuManager : MonoBehaviour
{
     void LoadLevel(string sceneName)
    {
        //SceneManager.LoadScene(sceneName);
    }

    
    void QuitGame()
    {
        Debug.Log("Вихід з гри");
        Application.Quit();
    }
}
}
