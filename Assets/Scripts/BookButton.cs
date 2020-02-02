using UnityEngine;
using UnityEngine.SceneManagement;

public enum Options
{
none, 
boot, 
start
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
            default :
                break;
        }
    }
}
