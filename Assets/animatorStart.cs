using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorStart : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    GameObject player;
    void Start()
    {
        anim = GetComponent<Animator>();
        player = FindObjectOfType<PlayerController>().gameObject;
    }

    // Update is called once per frame
    float T = 0;
    bool IsAnimating = false;
    public void GoJHonnyGo()
    {
        IsAnimating = true;
        player.transform.parent = this.gameObject.transform;
        anim.enabled = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            GoJHonnyGo();
           
        }
        if(IsAnimating)
        {
            T += Time.deltaTime;
            if(T>=2.1f)
            {
                anim.enabled = false;
                player.transform.parent = null;//become batman
            }
        }
    }
}
