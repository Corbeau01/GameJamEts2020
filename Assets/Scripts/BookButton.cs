using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public enum Options
{
none, 
boot, 
start,
options,
quit
};

public class BookButton : MonoBehaviour
{
    
    public Options action = Options.none;
    
    void OnMouseDown()
    {
        switch(action) {
            case Options.boot :
                Object.FindObjectOfType<Boot>().Release();
                break;
            case Options.start :
                SceneManager.LoadScene(sceneBuildIndex:+1);
                break;
            case Options.options :
                SceneManager.LoadScene(sceneBuildIndex:+1);
                break;
            case Options.quit :
                EditorApplication.isPlaying = false;
                Application.Quit();
                break;
            default :
                break;
        }
    }
}
