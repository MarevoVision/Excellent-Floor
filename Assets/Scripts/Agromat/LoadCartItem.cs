using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCartItem : MonoBehaviour
{
    public Transform contentParent;
    public CartManager _CartManager;

    private int count;
    private int numberListItem;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();

        foreach(List list in _CartManager.CartListItem.List)
        {
            if (PlayerPrefs.HasKey("numberItem" + list.Item_id))
            {
                count = PlayerPrefs.GetInt("count" + list.Item_id);
                numberListItem = PlayerPrefs.GetInt("numberItem" + list.Item_id);
                Item(numberListItem);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    private void Item(int NumberItem)
    {
        GameObject item = Instantiate(_CartManager.CartListItem.List[NumberItem].PrebafItem, contentParent);
        item.name = _CartManager.CartListItem.List[NumberItem].Item_id;
        item.gameObject.transform.Find("icon").GetComponent<Image>().sprite = _CartManager.CartListItem.List[NumberItem].Icon;
        item.gameObject.transform.Find("Txt_neme").GetComponent<Text>().text = _CartManager.CartListItem.List[NumberItem].NameItem;
        item.gameObject.transform.Find("Txt_price").GetComponent<Text>().text = _CartManager.CartListItem.List[NumberItem].Price.ToString("#.##") + " грн/м2";
        item.gameObject.GetComponent<CartAreaCalc>().area = _CartManager.CartListItem.List[NumberItem].Area;
        item.gameObject.GetComponent<CartAreaCalc>().price = _CartManager.CartListItem.List[NumberItem].Price;
        item.gameObject.GetComponent<CartAreaCalc>().count = count;
    }
}
