using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schematicViews : MonoBehaviour
{

    bool displaySchematics;
    public GameObject schematicView;
    public bluePrints bp; 

    // Start is called before the first frame update
    void Awake()
    {
        bp = FindObjectOfType<bluePrints>(); 
        displaySchematics = false;
        schematicView.SetActive(false);
    }

    void Start()
    {
        
    }

    private void OnEnable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("g"))
        {
            schematicView.SetActive(!schematicView.activeSelf); 
        }
    }

    //void nextSchematic;
    

}
