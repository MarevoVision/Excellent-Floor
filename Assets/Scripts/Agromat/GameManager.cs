using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlaneDetectionController _PlaneDetectionController;

    //BG
    public GameObject BG;
    //Menus
    public GameObject generalMenu;
    public GameObject TopMenu;
    public GameObject DownMenu;
    public GameObject InfoTitleMenu;
    public GameObject CartMenu;
    public GameObject SlideMenu;
    public GameObject FilterMenu;
    public GameObject _AR;
    public GameObject _2D;

    //Cart Menu Content 
    public GameObject CMC;

    //Buttons
    public GameObject btn_filter;
    public GameObject btn_AR;
    public GameObject btn_2D;
    public GameObject btn_Menu;

    //General Menu Content
    public GameObject[] GMC;

    //Top Menu Content
    public GameObject[] TMC;

    //Down Menu Content
    public GameObject[] DMC;

    // Info Title Menu Content
    public GameObject[] ITMC;

    //Content DownMenu 2D
    public GameObject[] DWC_2D;

    //Content DownMenu AR
    public GameObject[] DWC_AR;

    //NotificationMenu
    public GameObject NotificationMenu;
    public GameObject NotificationCart;
    public Text txt_notMenu;
    public Text txt_notCart;

    //Text Tile
    public Text TitleItem;

    private bool activeInfoMenu;
    private bool firstARMode;

    // Start is called before the first frame update
    void Start()
    {
        activeInfoMenu = true;
        firstARMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(CMC.transform.childCount > 0)
        {
            NotificationMenu.SetActive(true);
            NotificationCart.SetActive(true);
            txt_notMenu.text = CMC.transform.childCount.ToString();
            txt_notCart.text = CMC.transform.childCount.ToString();
        }
        if(CMC.transform.childCount <= 0)
        {
            NotificationMenu.SetActive(false);
            NotificationCart.SetActive(false);
            txt_notMenu.text = CMC.transform.childCount.ToString();
            txt_notCart.text = CMC.transform.childCount.ToString();
        }
    }

    public void DisableITMC()
    {
        foreach(GameObject go in ITMC)
        {
            go.SetActive(false);
        }
        InfoTitleMenu.SetActive(true);
    }

    public void OutLineDMC_2D()
    {
        foreach (GameObject go in DWC_2D)
        {
            go.GetComponent<Outline>().enabled = false;
        }
    }

    public void OutLineDMC_AR()
    {
        foreach (GameObject go in DWC_AR)
        {
            go.GetComponent<Outline>().enabled = false;
        }
    }

    public void GoToAR()
    {
        BG.SetActive(false);
        generalMenu.SetActive(false);
        TopMenu.SetActive(false);
        DownMenu.SetActive(false);

        if (InfoTitleMenu.activeSelf)
        {
            InfoTitleMenu.SetActive(false);
            activeInfoMenu = false;
        }

        btn_filter.SetActive(false);
        CartMenu.SetActive(false);

        btn_AR.SetActive(false);
        btn_2D.SetActive(true);
        SlideMenu.SetActive(false);
        FilterMenu.SetActive(false);
        _AR.SetActive(true);
        _2D.SetActive(false);
        if (firstARMode)
        {
            _PlaneDetectionController.SetAllPlanesActive(true);
        }

        firstARMode = true;
    }

    public void GoTo2D()
    {
        BG.SetActive(true);
        generalMenu.SetActive(true);
        TopMenu.SetActive(true);
        DownMenu.SetActive(true);

        if (!activeInfoMenu)
        {
            InfoTitleMenu.SetActive(true);
            activeInfoMenu = true;
        }

        btn_filter.SetActive(true);
        CartMenu.SetActive(false);

        btn_AR.SetActive(true);
        btn_2D.SetActive(false);
        SlideMenu.SetActive(false);
        FilterMenu.SetActive(false);
        _AR.SetActive(false);
        _2D.SetActive(true);
        if(firstARMode)
        {
            _PlaneDetectionController.SetAllPlanesActive(false);
        }
    }
}
