using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArtefact : MonoBehaviour
{
    public float SpeedY;
    public float SpeedX;
    public float SpeedZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += new Vector3(SpeedX * Time.deltaTime, SpeedY * Time.deltaTime, SpeedZ * Time.deltaTime);
    }
}
