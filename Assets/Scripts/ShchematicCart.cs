using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShchematicCart : MonoBehaviour
{
    public Button InventoryButton;
    private void OnCollisionEnter(Collision collision)
    {
        print(collision);
        InventoryButton.enabled = true;
    }
}
