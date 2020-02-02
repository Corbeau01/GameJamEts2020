using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDroper : MonoBehaviour
{
    public Transform DropPoint;
    public GameObject schematicView;
    //if is drop over a drop point.
    //Destroy
    //Activate slot
    bool isCounted = false;
    private void OnMouseUp()
    {

        if(schematicView.activeSelf==true)
        {
            if (Vector2.Distance(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(DropPoint.transform.position.x, DropPoint.transform.position.y)) <= 2)
            {
                //DropPoint.color = Color.green;
                this.transform.position = DropPoint.position;
                this.transform.parent = schematicView.transform;
                if(isCounted==false)
                {
                    schematicView.GetComponent<PartCounter>().myparts++;
                    isCounted = true;
                }
               
            }
            else
            {
                this.transform.parent = null;//become batman
                if(isCounted)
                {
                    schematicView.GetComponent<PartCounter>().myparts--;
                    isCounted = false;
                }
            }
        }
        
    }
}
