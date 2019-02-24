using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartManager : MonoBehaviour
{
    public GeneralMenu _generalMenu;
    public Transform contentParent;
    public ChangeMaterial _ChangeMaterial;
    public PlaceOnPlane _PlaceOnPlane;
    public Animation ItemToTheCart;
    public Animation BayItemToTheCart;
    [HideInInspector]
    public int countInfo;

    public CartListItem CartListItem = new CartListItem();
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CreateItem()
    {
        if (contentParent.Find(CartListItem.List[_generalMenu.NumberItem].Item_id) == null)
        {
            Item(_generalMenu.NumberItem);
            BayItemToTheCart.Stop();
            BayItemToTheCart.Play();
        }
        else
        {
            ItemToTheCart.Stop();
            ItemToTheCart.Play();
        }
    }

    private void Item(int NumberItem)
    {
        GameObject item = Instantiate(CartListItem.List[NumberItem].PrebafItem, contentParent);
        item.name = CartListItem.List[NumberItem].Item_id;
        item.gameObject.transform.Find("icon").GetComponent<Image>().sprite = CartListItem.List[NumberItem].Icon;
        item.gameObject.transform.Find("Txt_neme").GetComponent<Text>().text = CartListItem.List[NumberItem].NameItem;
        item.gameObject.transform.Find("Txt_price").GetComponent<Text>().text = CartListItem.List[NumberItem].Price.ToString("#.##") + " грн/м2";
        item.gameObject.GetComponent<CartAreaCalc>().area = CartListItem.List[NumberItem].Area;
        item.gameObject.GetComponent<CartAreaCalc>().price = CartListItem.List[NumberItem].Price;
        item.gameObject.GetComponent<CartAreaCalc>().count = CartListItem.List[NumberItem].StartCount + countInfo;

        PlayerPrefs.SetInt("numberItem" + CartListItem.List[NumberItem].Item_id, NumberItem);
    }

    public void CreateItemAR()
    {
        if (contentParent.Find(CartListItem.List[_ChangeMaterial.usenowNumber - 1].Item_id) == null)
        {
            ItemAR(_ChangeMaterial.usenowNumber - 1);

            BayItemToTheCart.Stop();
            BayItemToTheCart.Play();
        }
        else
        {
            ItemToTheCart.Stop();
            ItemToTheCart.Play();
        }
    }

    private void ItemAR(int NumberItem)
    {
        GameObject item = Instantiate(CartListItem.List[NumberItem].PrebafItem, contentParent);
        item.name = CartListItem.List[NumberItem].Item_id;
        item.gameObject.transform.Find("icon").GetComponent<Image>().sprite = CartListItem.List[NumberItem].Icon;
        item.gameObject.transform.Find("Txt_neme").GetComponent<Text>().text = CartListItem.List[NumberItem].NameItem;
        item.gameObject.transform.Find("Txt_price").GetComponent<Text>().text = CartListItem.List[NumberItem].Price.ToString("#.##") + " грн/м2";
        item.gameObject.GetComponent<CartAreaCalc>().area = CartListItem.List[NumberItem].Area;
        item.gameObject.GetComponent<CartAreaCalc>().price = CartListItem.List[NumberItem].Price;
        item.gameObject.GetComponent<CartAreaCalc>().count = Mathf.FloorToInt(_PlaceOnPlane.rolls);

        PlayerPrefs.SetInt("numberItem" + CartListItem.List[NumberItem].Item_id, NumberItem);
    }

    public void Purchased()
    {
        Application.OpenURL("https://shop.agromat.ua/ua/order/edit");
    }
}
