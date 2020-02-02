using UnityEngine;

public class Wireframe : MonoBehaviour
{
    public bool activated;
    private float time;
    private float randomTime;

    public float MaxTime;

    public bool Fixed;
    public GameObject Noise;
    
    //void Start() { //juste pour tester la fonction
    //    enable();
    //    Invoke("disable",3f);
    //}
    
    public void enable()
    {
        Fixed = true;
        activated = false;
    }
    
    public void disable()
    {
        Fixed = false;
    }
    
    
    void OnPreRender()
    {
        //GL.wireframe = activated;
    }

    void OnPostRender()
    {
        ///GL.wireframe = false;
    }
    void Start()
    {
        activated = false;
        Fixed = false;
        randomTime = Random.value * MaxTime;
    }
    
    void Update()
    {
        if(Fixed)
        {
            activated = false;
            Noise.SetActive(false);
            return;
        }
        if(activated)
        {
            time += Time.deltaTime;
            if (time > Random.Range(3, 5))
            {
                activated = false;
                Noise.SetActive(false);
                time = 0;
            }
        }
        if (!Fixed)
        {
            time += Time.deltaTime;
            if (time > Random.Range(4,10))
            {
                activated = !activated;
                Noise.SetActive(true);
                time = 0;
            }
        }
        else
        {
            activated = false;
        }  
    }
} 
