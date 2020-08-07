using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcAi : Interactable
{
    Animator anim;
    Vector2 movement;
    public float speed = 2;

    public Item[] itemPool;
    private static NpcAi npcInstance;
    private GameObject cloud;
    public GameObject itemSprite;
    public GameObject orderSystem;
    Item order;

    public bool ordering = false;
    bool orderSprites = false;
    public bool orderTaken = false;

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

    void Order()
    {
        cloud.SetActive(false);
        orderTaken = true;
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

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        anim.SetFloat("Speed", speed);

        //Triggers in NpcStopper
        if (ordering)
        {
            if (!orderSprites)
                initiateOrderSprites();

            if (interact())
                Order();
        }
    }
}
