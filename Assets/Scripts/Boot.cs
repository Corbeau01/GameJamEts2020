using UnityEngine;

public class Boot : MonoBehaviour
{
    public BookHandler bh;
    
    public void Release(){ //release the kraken
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
    
    void OnCollisionEnter() {
        bh.Explode();
    }
} 
