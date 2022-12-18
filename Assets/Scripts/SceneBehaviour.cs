using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBehaviour : MonoBehaviour
{
    public void GoToScene(int sceneInt)
    {
        SceneManager.LoadScene(sceneInt);
    }
}
