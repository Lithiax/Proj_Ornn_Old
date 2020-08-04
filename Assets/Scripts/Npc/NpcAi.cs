using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcAi : Interactable
{
    Animator anim;
    Vector2 movement;
    public float speed = 2;
    public bool ordering = false;
    private bool orderSprites = false;

    public GameObject[] itemPool;
    private static NpcAi npcInstance;
    private GameObject cloud;

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
}

    void Order()
    {
        cloud.SetActive(false);
        orderSprites = false;
        ordering = false;
    }

    void initiateOrderSprites()
    {
        cloud.SetActive(true);
        GameObject item = Instantiate(itemPool[0], cloud.transform);
        item.transform.position = cloud.transform.position;
        orderSprites = true;
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
