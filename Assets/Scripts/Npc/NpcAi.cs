using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcAi : MonoBehaviour
{
    Animator anim;
    Vector2 movement;
    public float speed = 2;

    public Item[] itemPool;

    public GameObject cloud;
    public GameObject itemSprite;
    public GameObject orderSystem;
    public GameObject interactArea;
    public Item order;
    public string state;

    //states
    public bool orderSprites = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        cloud = transform.GetChild(0).gameObject;
        //Temporary code
        order = itemPool[0];

        //shitty asf if the npc goes to zero then oh well lmaoooo 
        if (NPCData.npcPosition != Vector3.zero)
            transform.position = NPCData.npcPosition;

        if (NPCData.setState != null)
        {
            state = NPCData.setState;
            anim.SetBool(state, true);
        }

        speed = NPCData.npcSpeed;  
    }
    public void initiateOrderSprites()
    {
        //Change itemPool[0] to itemSelected when more than 1 item is made.
        cloud.SetActive(true);
        itemSprite.GetComponent<SpriteRenderer>().sprite = itemPool[0].sprite;
        orderSprites = true;
        itemPool[0].printRecipe();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "NPCStopper" && state != "OrderTaken")
        {
            //ordering state
            speed = 0;
            anim.SetBool("Ordering", true);
        }
    }
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        anim.SetFloat("Speed", speed);
    
    }
    void OnDestroy()
    {
        NPCData.npcPosition = transform.position;
        NPCData.setState = state;
        NPCData.npcSpeed = speed;
    }
}
