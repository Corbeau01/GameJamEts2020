using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class schematicViews : MonoBehaviour
{

    bool displaySchematics;
    public GameObject schematicView;
    public bluePrints bp;
    private int prevBpCount;
    public float textCount;


    public bluePrints.bluePrintsEnum activeBp;

    public GameObject ladder;
    public GameObject Walkman;
    public GameObject cart;
    public GameObject button;
    public GameObject textBox;
    public GameObject tesseract;
    public GameObject Pyramidon; 

    private int bpEnumCount = bluePrints.bluePrintsEnum.GetNames(typeof(bluePrints.bluePrintsEnum)).Length;

    // Start is called before the first frame update
    void Awake()
    {
        bp = FindObjectOfType<bluePrints>();
        displaySchematics = false;
        button.SetActive(false); 
        schematicView.SetActive(false);
    }

    void Start()
    {

    }

    private void OnEnable()
    {

    }

    public void toggleView()
    {
        if (bp.getBpCount() > 0)
        {
            schematicView.SetActive(!schematicView.activeSelf);
        }
    }



    // Update is called once per frame
    void Update()
    {

        //if (textBox.activeSelf)
        //{
        //    textCount -= Time.deltaTime;
        //    if (textCount <= 0)
        //    {
        //        textBox.SetActive(false);
        //    }
        //}

        //if (bp.getBpCount() > prevBpCount)
        //{
        //    showTextBox();
        //    prevBpCount = bp.getBpCount();
        //}

        if(bp.getBpCount()>0)
        {
            button.SetActive(true); 
        }
        else
        {
            button.SetActive(false);
        }

        if (schematicView.activeSelf)
        {
            switch (activeBp)
            {
                case bluePrints.bluePrintsEnum.Cart:
                    cart.SetActive(true);
                    ladder.SetActive(false);
                    Walkman.SetActive(false);
                    tesseract.SetActive(false);
                    Pyramidon.SetActive(false);
                    break;
                case bluePrints.bluePrintsEnum.Ladder:
                    cart.SetActive(false);
                    ladder.SetActive(true);
                    Walkman.SetActive(false);
                    tesseract.SetActive(false);
                    Pyramidon.SetActive(false);
                    break;
                case bluePrints.bluePrintsEnum.Walkman:
                    cart.SetActive(false);
                    ladder.SetActive(false);
                    Walkman.SetActive(true);
                    tesseract.SetActive(false);
                    Pyramidon.SetActive(false);
                    break;
                case bluePrints.bluePrintsEnum.Tesseract:
                    cart.SetActive(false);
                    ladder.SetActive(false);
                    Walkman.SetActive(false);
                    tesseract.SetActive(true);
                    Pyramidon.SetActive(false);
                    break;
                case bluePrints.bluePrintsEnum.Pyramidon:
                    cart.SetActive(false);
                    ladder.SetActive(false);
                    Walkman.SetActive(false);
                    tesseract.SetActive(false);
                    Pyramidon.SetActive(true);
                    break;
            }
        }
    }

    public void nextSchematic()
    {
        print("wasaaaaaaaaaaa");
        int exit = 0;

        if (bp.getBpCount() > 0)
        {
            while (exit == 0)

            {
                switch (activeBp)
                {
                    case bluePrints.bluePrintsEnum.Cart:
                        activeBp = bluePrints.bluePrintsEnum.Ladder;
                        if (bp.checkIfBluePrintOwned(activeBp))
                        {
                            exit = 1;
                        }
                        break;
                    case bluePrints.bluePrintsEnum.Ladder:
                        activeBp = bluePrints.bluePrintsEnum.Walkman;
                        if (bp.checkIfBluePrintOwned(activeBp))
                        {
                            exit = 1;
                        }
                        break;
                    case bluePrints.bluePrintsEnum.Walkman:
                        activeBp = bluePrints.bluePrintsEnum.Tesseract;
                        if (bp.checkIfBluePrintOwned(activeBp))
                        {
                            exit = 1;
                        }
                        break;
                    case bluePrints.bluePrintsEnum.Tesseract:
                        activeBp = bluePrints.bluePrintsEnum.Pyramidon;
                        if (bp.checkIfBluePrintOwned(activeBp))
                        {
                            exit = 1;
                        }
                        break;
                        case bluePrints.bluePrintsEnum.Pyramidon:
                        activeBp = bluePrints.bluePrintsEnum.Cart;
                        if (bp.checkIfBluePrintOwned(activeBp))
                        {
                            exit = 1;
                        }
                        break;
                    default:
                        exit = 1;
                        break;
                }
            }
        }
    }

    public void previousSchematic()
    {
        int exit = 0;

        if (bp.getBpCount() > 0)
        {
            while (exit == 0)

            {
                switch (activeBp)
                {
                    case bluePrints.bluePrintsEnum.Cart:
                        activeBp = bluePrints.bluePrintsEnum.Pyramidon;
                        if (bp.checkIfBluePrintOwned(activeBp))
                        {
                            exit = 1;
                        }
                        break;
                    case bluePrints.bluePrintsEnum.Ladder:
                        activeBp = bluePrints.bluePrintsEnum.Cart;
                        if (bp.checkIfBluePrintOwned(activeBp))
                        {
                            exit = 1;
                        }
                        break;
                    case bluePrints.bluePrintsEnum.Walkman:
                        activeBp = bluePrints.bluePrintsEnum.Ladder;
                        if (bp.checkIfBluePrintOwned(activeBp))
                        {
                            exit = 1;
                        }
                        break;
                    case bluePrints.bluePrintsEnum.Tesseract:
                        activeBp = bluePrints.bluePrintsEnum.Walkman;
                        if (bp.checkIfBluePrintOwned(activeBp))
                        {
                            exit = 1;
                        }
                        break;
                        case bluePrints.bluePrintsEnum.Pyramidon:
                        activeBp = bluePrints.bluePrintsEnum.Tesseract;
                        if (bp.checkIfBluePrintOwned(activeBp))
                        {
                            exit = 1;
                        }
                        break;
                    default:
                        exit = 1;
                        break;
                }
            }
        }
    }


    //public void showTextBox()
    //{
    //    textBox.SetActive(true);
    //    textCount = 3.5f;
    //}



}
