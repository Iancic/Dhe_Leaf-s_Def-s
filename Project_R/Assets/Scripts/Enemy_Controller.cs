using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    private float Speed = 0.0004f;
    private Rigidbody2D corp_rb;
    public GameObject healthbar;
    public int hitpoints;
    public static int score;
    private SpriteRenderer rend;
    private Sprite nexthitbar;
    public Sprite health1, health2, health3;

    void Start()
    {
        //score
        score = 0;

        corp_rb = GetComponent<Rigidbody2D>();
        hitpoints = 3;

        //hitbar
        rend = healthbar.GetComponent<SpriteRenderer>();
        rend.sprite = health3;
    }

    void Update()
    {
        corp_rb.AddForce(new Vector2(-Speed,0), ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D atingere)
    {
        /*coliziunea este bazata pe folosirea tagurilor specifice inamicului sistemul de ierarhie intre gloante si inamici:
            Water Enemy 2hp:
        Neutral, fire = -1 hp
        Weakness, nature = one shot
        Amplif, water = +1 hp
            Fire Enemy 2 hp:
        Neutral, nature = -1 hp
        Weakness, water = one shot
        Amplif, fire = +hp
            Nature Enemy 2hp:
        Neutral, water = -1 hp
        Weakness, fire = one shot
        Amplif, nature= +hp
        */

        hitpoints = hitpoints - 1;

        if ( hitpoints == 1 )
            nexthitbar = health1;
        else if ( hitpoints == 2 )
            nexthitbar = health2; 
        else if ( hitpoints == 0 )
            Destroy(gameObject);  

        if ( gameObject.tag == "Water" )
        {
            if (atingere.gameObject.name == "Bullet1(Clone)")
            {
                rend.sprite = nexthitbar;
                score = score + 10;
                Debug.Log("Ampped");
            }
            if (atingere.gameObject.name == "Bullet2(Clone)")
            {
                rend.sprite = nexthitbar;
                score = score + 10;
                Debug.Log("Neutral");
            }
            if (atingere.gameObject.name == "Bullet3(Clone)")
            {
                rend.sprite = nexthitbar;
                score = score + 10;
                Debug.Log("Weakness");
            }
        }
        if ( gameObject.tag == "Fire" )
        {
            if (atingere.gameObject.name == "Bullet2(Clone)")
            {
                rend.sprite = nexthitbar;
                score = score + 10;
                Debug.Log("Ampped");
            }
            if (atingere.gameObject.name == "Bullet3(Clone)")
            {
                rend.sprite = nexthitbar;
                score = score + 10;
                Debug.Log("Neutral");
            }
            if (atingere.gameObject.name == "Bullet1(Clone)")
            {
                rend.sprite = nexthitbar;
                Debug.Log("Weakness");
            }
        }
        if ( gameObject.tag == "Nature" )
        {
            if (atingere.gameObject.name == "Bullet3(Clone)")
            {
                rend.sprite = nexthitbar;
                score = score + 10;
                Debug.Log("Ampped");
            }
            if (atingere.gameObject.name == "Bullet1(Clone)")
            {
                rend.sprite = nexthitbar;
                score = score + 10;
                Debug.Log("Neutral");
            }
            if (atingere.gameObject.name == "Bullet2(Clone)")
            {
                rend.sprite = nexthitbar;
                score = score + 10;
                Debug.Log("Weakness");
            }  
        }

        if ( atingere.gameObject.tag == "Tree" )
        {
            Destroy(gameObject);  
            Debug.Log("Tree Hit"); 
        }
    }
}
