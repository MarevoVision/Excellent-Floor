using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMenu : MonoBehaviour
{
    private int numberItem;
    public Transform contentGeneral;

    public int NumberItem { get => numberItem; set => numberItem = value; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Greet()
    {
        switch (NumberItem)
        {
            case 1:
                print("Why hello there good sir! Let me teach you about Trigonometry!");
                break;
            case 2:
                print("Hello and good day!");
                break;
            case 3:
                print("Whadya want?");
                break;
            case 4:
                print("Grog SMASH!");
                break;
            case 5:
                print("Ulg, glib, Pblblblblb");
                break;
        }
    }
}
