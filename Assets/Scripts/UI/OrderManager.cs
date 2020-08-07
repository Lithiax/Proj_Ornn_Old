using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderManager : MonoBehaviour
{
    Item order;
    public GameObject itemSprite;
    void Start()
    {
        itemSprite.GetComponent<Image>().sprite = OrderData.Order;
    }

    void Update()
    {

    }

    public void UpdateOrders(Item order)
    {
        itemSprite.GetComponent<Image>().sprite = order.sprite;
        //Update OrderData
        OrderData.Order = order.sprite;
    }
}
