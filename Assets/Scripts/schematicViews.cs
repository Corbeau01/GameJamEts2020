using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schematicViews : MonoBehaviour
{

    bool displaySchematics;
    public GameObject schematicView;
    public bluePrints bp;

    public bluePrints.bluePrintsEnum activeBp;

    public GameObject ladder;
    public GameObject Walkman;
    public GameObject cart;

    private int bpEnumCount = bluePrints.bluePrintsEnum.GetNames(typeof(bluePrints.bluePrintsEnum)).Length;

    // Start is called before the first frame update
    void Awake()
    {
        bp = FindObjectOfType<bluePrints>();
        displaySchematics = false;
        schematicView.SetActive(false);
    }

    void Start()
    {

    }

    private void OnEnable()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g") && bp.getBpCount() > 0)
        {
            schematicView.SetActive(!schematicView.activeSelf);
        }

        if (schematicView.activeSelf)
        {
            switch (activeBp)
            {
                case bluePrints.bluePrintsEnum.Cart:
                    cart.SetActive(true);
                    ladder.SetActive(false);
                    Walkman.SetActive(false);
                    break;
                case bluePrints.bluePrintsEnum.Ladder:
                    cart.SetActive(false);
                    ladder.SetActive(true);
                    Walkman.SetActive(false);
                    break;
                case bluePrints.bluePrintsEnum.Walkman:
                    cart.SetActive(false);
                    ladder.SetActive(false);
                    Walkman.SetActive(true);
                    break;
            }
        }
    }

    public void nextSchematic()
    {

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
                        activeBp = bluePrints.bluePrintsEnum.Walkman;
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
                    default:
                        exit = 1;
                        break;
                }
            }
        }
    }
}
