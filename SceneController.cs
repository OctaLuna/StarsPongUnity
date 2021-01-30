using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //Es el controlador de las escenas

public class SceneController : MonoBehaviour
{
    public void ChangeSceneTo(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
