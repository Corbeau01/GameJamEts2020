using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickableBluePrint : MonoBehaviour
{
    public GameObject pickupAnim;
    public bluePrints bp;

    public bluePrints.bluePrintsEnum thisBluePrint; 

    // Start is called before the first frame update
    void Start()
    {
        bp = FindObjectOfType<bluePrints>();
    }

    // Update is called once per frame

    private void Update()
    {
        if (bp == null)
        {
            bp = FindObjectOfType<bluePrints>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedObject = collision.collider.gameObject;

        print("T0");

        if (collidedObject.tag == "Player")
        {
            print("T1");
            
            bp.addBluePrint(thisBluePrint);
            print(thisBluePrint+"Is Activated");
            if (bp == null)
            {
                bp = FindObjectOfType<bluePrints>();
                print("wuuuuuuuuut");
            }
            //AudioManager.Instance.ItemPickup.Play(transform.position);
            Instantiate(pickupAnim, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
   
}
