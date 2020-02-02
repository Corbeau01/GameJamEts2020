using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;
    public float thrust = 1.0f;

    public float JumpThrust = 10.0f;
    public Rigidbody rb;

    public bool CanClimb = false;
    public bool RotateAxisUnlocked;
    private bool Rotating_q = false;
    private bool Rotating_e = false;
    private int InitialAngle = 0;
    private float CurrentAngle;
    private int FinishAngle;
    private float Timer = 0;
    private features Feats;
    public GameObject MyFeet;
    public bool CanJump;

    public bool IsGoingLeft;

    public ChangeSpriteDirection SpriteDirectionController;

    // Start is called before the first frame update
    void Start()
    {
        SpriteDirectionController = GetComponent<ChangeSpriteDirection>();
        IsGoingLeft = false;
        rb = GetComponent<Rigidbody>();
        CanJump = false;
        RotateAxisUnlocked = false;
    }
   
    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y<=-100)
        {
            SceneManager.LoadScene(sceneBuildIndex:+0);
        }
        if(Input.GetKey(KeyCode.F1))
        {
            rb.velocity= new Vector3(0.0f,0.0f, 0.0f);
        }
        if (Mathf.Abs(rb.velocity.x) < 2)
        {
            rb.velocity = new Vector3(0.0f, rb.velocity.y, rb.velocity.z);
        }
        if (Mathf.Abs(rb.velocity.z) < 2)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0.0f);
        }

        if (Input.GetKey("r"))
        {
            Timer += Time.deltaTime;
            if (Timer > 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
            }
        }
        else
        {
            Timer = 0;
        }

        Feats = FindObjectOfType<features>();
        if (!(Input.GetKeyDown("q") && Input.GetKeyDown("e")) && RotateAxisUnlocked && !Rotating_q && !Rotating_e)
        {
            InitialAngle = (int)transform.eulerAngles.y;
            CurrentAngle = InitialAngle;
            if (Input.GetKeyDown("q"))
            {
                Rotating_q = true;
                FinishAngle = InitialAngle + 90;
                if (FinishAngle >= 360)
                {
                    FinishAngle -= 360;
                }
            }
            else if (Input.GetKeyDown("e"))
            {
                Rotating_e = true;
                FinishAngle = InitialAngle - 90;
                if (FinishAngle < 0)
                {
                    FinishAngle += 360;
                }
            }
        }

        if (Rotating_q)
        {
            transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);
            CurrentAngle = transform.eulerAngles.y;
            if ((FinishAngle == 0 && (int)CurrentAngle == 0) || (FinishAngle != 0 && CurrentAngle > FinishAngle))
            {
                Rotating_q = false;
                transform.rotation = Quaternion.Euler(new Vector3(0, InitialAngle + 90, 0));
            }
        }
        else if (Rotating_e)
        {
            transform.Rotate(0, -(RotationSpeed * Time.deltaTime), 0);
            CurrentAngle = transform.eulerAngles.y;
            if ((FinishAngle == 0 && (int)CurrentAngle == 0) || (FinishAngle != 0 && CurrentAngle < FinishAngle))
            {
                Rotating_e = false;
                transform.rotation = Quaternion.Euler(new Vector3(0, InitialAngle - 90, 0));
            }
        }
    }

    void FixedUpdate()
    {
        if (!(Input.GetKeyDown("d") && Input.GetKeyDown("a")))
        {
            if (Input.GetKey("d"))
            {
                SpriteDirectionController.GoingRight();
                transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
                rb.AddForce(Vector3.right * thrust);
            }
            else if (Input.GetKey("a"))
            {
                SpriteDirectionController.GoingLeft();
                transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
                rb.AddForce(Vector3.left * thrust);
            }
        }
        else
        {
            rb.velocity = new Vector3(0.0f, rb.velocity.y, 0.0f);
        }
        if (Input.GetKeyDown("space"))
        {
            if (CanJump)
            {
                rb.AddForce(Vector3.up * JumpThrust);
                CanJump = false;
            }
        }
        if(CanClimb)
        {
            this.GetComponent<Rigidbody>().useGravity = false;        
        }
        else
        {
            
            if(FindObjectOfType<features>().unlockedFeatures.Contains(features.unlockableFeatures.Gravity)==false)
            {
                return;
            }
            this.GetComponent<Rigidbody>().useGravity = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (CanClimb)
            {
                transform.Translate(Vector3.up * MovementSpeed * Time.deltaTime);
                

            }

        }
        if (Input.GetKey(KeyCode.S))
        {
            if (CanClimb)
            {
                transform.Translate(Vector3.down * MovementSpeed * Time.deltaTime);


            }

        }
    }
}

