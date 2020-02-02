using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateViews : MonoBehaviour
{
    public GameObject SchematicView;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            SchematicView.SetActive(!SchematicView.activeSelf);

        }
    }
}
