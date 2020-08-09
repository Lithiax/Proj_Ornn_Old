using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcAi : MonoBehaviour
{
    Animator anim;
    Vector2 movement;
    public float speed = 2;

    public Item[] itemPool;
    private static NpcAi npcInstance;
    private GameObject cloud;
    public GameObject itemSprite;
    public GameObject orderSystem;
    public GameObject interactArea;
    Item order;

    //states
    bool ordering = false;
    bool orderSprites = false;
    bool orderTaken = false;
    bool orderComplete;

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (npcInstance == null)
        {
            npcInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        cloud = transform.GetChild(0).gameObject;
        //Temporary code
        order = itemPool[0];
    }
    void Ordering()
    {
        Debug.Log("ordering");
        if (!orderSprites)
            initiateOrderSprites();

        if (interactArea.GetComponent<Interactable>().interacted)   
            OrderTaken();
    }
    void OrderTaken()
    {
        cloud.SetActive(false);
        orderSprites = false;

        orderTaken = true;
        ordering = false;
        orderSystem.GetComponent<OrderManager>().UpdateOrders(order);
    }
    void initiateOrderSprites()
    {
        //Change itemPool[0] to itemSelected when more than 1 item is made.
        cloud.SetActive(true);
        itemSprite.GetComponent<SpriteRenderer>().sprite = itemPool[0].sprite;
        orderSprites = true;
        itemPool[0].printRecipe();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "NPCStopper")
        {
            speed = 0;
            Ordering();
        }
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        anim.SetFloat("Speed", speed);
    }
}
