using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class features : MonoBehaviour
{
    public Camera TheCamera;
    public GameObject Character;
    public GameObject RightImage;
    public GameObject BackFuck;
    public Sprite NewImage1Jump;
    public Sprite NewImage2Jump;
    public RemoveJumpTutorial JumpTutorial;

    public bool fait;
    public bool IFait;
    public enum unlockableFeatures
    {
        wireframe,
        couleur,
        sound,
        twoPointFivey,
        twoPointFivex,
        twoPointFivez,
        Threed,
        Gravity,
        Jump
    }



    public List<unlockableFeatures> unlockedFeatures;

    public void Awake()
    {
        unlockedFeatures = new List<unlockableFeatures>();
    }

    public void unlockFeature(unlockableFeatures featToUnlock)
    {
        if (!unlockedFeatures.Contains(featToUnlock))
        {
            unlockedFeatures.Add(featToUnlock);
           // Debug.Log("feature unlocked");
        }
    }

    public bool checkIfFeatureUnlocked(unlockableFeatures feature)
    {
        return unlockedFeatures.Contains(feature); 
    }
    void Update()
    {
        if (TheCamera.GetComponent<Wireframe>().enabled)
        {
            if (unlockedFeatures.Contains(unlockableFeatures.wireframe))
            {
                print("t3");
                TheCamera.GetComponent<Wireframe>().Fixed = true;
                Destroy(BackFuck.gameObject);
            }
        }

        if (unlockedFeatures.Contains(unlockableFeatures.Gravity))
        {
            Character.GetComponent<Rigidbody>().useGravity = true;
        }

        if (unlockedFeatures.Contains(unlockableFeatures.Jump))
        {
            if (!fait)
            {
                RightImage.GetComponent<Image>().sprite = NewImage1Jump;
                RightImage.GetComponent<AnimateKey>().image1 = NewImage1Jump;
                RightImage.GetComponent<AnimateKey>().image2 = NewImage2Jump;
                Character.GetComponent<PlayerController>().CanJump = true;
                Character.GetComponent<PlayerController>().MyFeet.SetActive(true);
                RightImage.SetActive(true);
            }
            fait = true;
           
            JumpTutorial.RelevantNow();
        }

        if (unlockedFeatures.Contains(unlockableFeatures.twoPointFivey))
        {
            Character.GetComponent<PlayerController>().RotateAxisUnlocked = true;
        }
    }

}
