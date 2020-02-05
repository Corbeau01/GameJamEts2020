using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNextSceness : MonoBehaviour
{
    public int sceneNumber;
    public float time;

    public void LoadMyNextScene()
    {
        SceneManager.LoadScene(sceneBuildIndex:sceneNumber);
    }

    void Update()
    {
        if (time > 10.0f)
        {
            LoadMyNextScene();
        }
        else
        {
            time += Time.deltaTime;
        }
    }
}
