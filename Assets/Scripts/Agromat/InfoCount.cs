using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoCount : MonoBehaviour
{
    [HideInInspector]
    public int count = 1;

    public float area;

    private Button btn_plus;
    private Button btn_minus;
    private Button btn_Bay;

    private Text txt_count;
    private Text txt_area;
    private Text txt_countSize;

    public CartManager _cartManager;
    // Start is called before the first frame update
    void Start()
    {
        btn_plus = transform.Find("Scroll View/Viewport/Content/Front/Count/Btn_plus").GetComponent<Button>();
        btn_minus = transform.Find("Scroll View/Viewport/Content/Front/Count/Btn_minus").GetComponent<Button>();
        btn_Bay = transform.Find("Scroll View/Viewport/Content/Front/Btn_Bay").GetComponent<Button>();

        txt_count = transform.Find("Scroll View/Viewport/Content/Front/Count/count_tile/Text").GetComponent<Text>();
        txt_area = transform.Find("Scroll View/Viewport/Content/Front/Count/Txt_count_sum_m2").GetComponent<Text>();
        txt_countSize = transform.Find("Scroll View/Viewport/Content/Front/Count/Txt_count").GetComponent<Text>();

        btn_plus.onClick.AddListener(PlusCount);
        btn_minus.onClick.AddListener(MinusCount);
        btn_Bay.onClick.AddListener(BayBtn);

        txt_area.text = "  =  " + (count * area).ToString("#.##") + " м2";
        txt_countSize.text = "кількість упаковок (" + area.ToString("#.##") + " м2/уп)";
    }

    // Update is called once per frame
    void Update()
    {
        txt_count.text = count.ToString();
    }
    private void PlusCount()
    {
        count++;
        txt_area.text = "  =  " + (count * area).ToString("#.##") + " м2";
        _cartManager.countInfo++;
    }

    private void MinusCount()
    {
        if (count > 1)
        {
            count--;
            txt_area.text = "  =  " + (count * area).ToString("#.##") + " м2";
        }
        if (_cartManager.countInfo > 0)
        {
            _cartManager.countInfo--;
        }
    }
    private void BayBtn()
    {
        _cartManager.countInfo = 0;
    }
}
