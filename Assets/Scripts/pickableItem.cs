using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickableItem : MonoBehaviour
{
    
    public GameObject pickupAnim;
    public features feats;

    public features.unlockableFeatures featureToUnlock; 

    // Start is called before the first frame update
    void Start()
    {
        feats = FindObjectOfType<features>();
    }

    // Update is called once per frame
  
    private void Update()
    {
        if (feats == null)
        {
            feats = FindObjectOfType<features>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        GameObject collidedObject = collision.collider.gameObject;

        Debug.Log(collidedObject.tag);

        if (collidedObject.tag == "Player")
        {
            Destroy(this.gameObject);
            feats.unlockFeature(featureToUnlock); 

            //if (gm == null)
            //{
            //    gm = FindObjectOfType<GeneratorMap>();
            //    print("wuuuuuuuuut");
            //}
            //AudioManager.Instance.ItemPickup.Play(transform.position);
            Instantiate(pickupAnim, this.transform.position, Quaternion.identity);
        }
    }

}
