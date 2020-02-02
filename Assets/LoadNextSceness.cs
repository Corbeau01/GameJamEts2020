using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNextSceness : MonoBehaviour
{
    public void LoadMyNextScene()
    {
        SceneManager.LoadScene(sceneBuildIndex:2);
    }
}
