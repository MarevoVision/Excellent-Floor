using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartAreaCalc : MonoBehaviour
{
    [HideInInspector]
    public int count;

    [HideInInspector]
    public float area;

    [HideInInspector]
    public float price;

    private GeneralMenu _GeneralMenu;

    private Button btn_plus;
    private Button btn_minus;
    private Button btn_del;

    private Text txt_count;
    private Text txt_price;
    private Text txt_totalPrice;
    private Text txt_area;

    // Start is called before the first frame update
    void Start()
    {
        btn_plus = transform.Find("Count/Btn_plus").GetComponent<Button>();
        btn_minus = transform.Find("Count/Btn_minus").GetComponent<Button>();
        btn_del = transform.Find("Btn_del").GetComponent<Button>();

        txt_count = transform.Find("Count/count_tile/Text").GetComponent<Text>();
        txt_price = transform.Find("Txt_price").GetComponent<Text>();
        txt_totalPrice = transform.Find("Txt_Total_Price").GetComponent<Text>();
        txt_area = transform.Find("Count/Txt_count_sum_m2").GetComponent<Text>();

        btn_plus.onClick.AddListener(PlusCount);
        btn_minus.onClick.AddListener(MinusCount);
        btn_del.onClick.AddListener(Del);

        txt_price.text = price.ToString("#.##") + " грн/м2";
        txt_totalPrice.text = price.ToString("#.##") + " грн";
        txt_area.text = "( " + area.ToString("#.##") + " м2)";

        if(count != 0)
        {
            txt_totalPrice.text = (count * price).ToString("#.##") + " грн";
            txt_area.text = "( " + (count * area).ToString("#.##") + " м2)";
        }

        PlayerPrefs.SetInt("count" + gameObject.name, count);
    }

    // Update is called once per frame
    void Update()
    {
        txt_count.text = count.ToString();
    }
    private void PlusCount()
    {
        count++;
        txt_totalPrice.text = (count * price).ToString("#.##") + " грн";
        txt_area.text = "( " + (count * area).ToString("#.##") + " м2)";
        PlayerPrefs.SetInt("count" + gameObject.name, count);
    }

    private void MinusCount()
    {
        if(count > 1)
        {
            count--;
            txt_totalPrice.text = (count * price).ToString("#.##") + " грн";
            txt_area.text = "( " + (count * area).ToString("#.##") + " м2)";
            PlayerPrefs.SetInt("count" + gameObject.name, count);
        }
    }

    private void Del()
    {
        Destroy(gameObject);
        PlayerPrefs.DeleteKey("count" + gameObject.name);
        PlayerPrefs.DeleteKey("numberItem" + gameObject.name);
    }
}
