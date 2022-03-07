using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    private float Speed = 0.0004f;
    private Rigidbody2D corp_rb;

    // Start is called before the first frame update
    void Start()
    {
        corp_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
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

        if ( gameObject.tag == "Water" )
        {
            if (atingere.gameObject.name == "Bullet1(Clone)")
            {
                Destroy(gameObject); 
                Debug.Log("Ampped");
            }
            if (atingere.gameObject.name == "Bullet2(Clone)")
            {
                Destroy(gameObject); 
                Debug.Log("Neutral");
            }
            if (atingere.gameObject.name == "Bullet3(Clone)")
            {
                Destroy(gameObject); 
                Debug.Log("Weakness");
            }
        }
        if ( gameObject.tag == "Fire" )
        {
            if (atingere.gameObject.name == "Bullet2(Clone)")
            {
                Destroy(gameObject); 
                Debug.Log("Ampped");
            }
            if (atingere.gameObject.name == "Bullet3(Clone)")
            {
                Destroy(gameObject); 
                Debug.Log("Neutral");
            }
            if (atingere.gameObject.name == "Bullet1(Clone)")
            {
                Destroy(gameObject); 
                Debug.Log("Weakness");
            }
        }
        if ( gameObject.tag == "Nature" )
        {
            if (atingere.gameObject.name == "Bullet3(Clone)")
            {
                Destroy(gameObject); 
                Debug.Log("Ampped");
            }
            if (atingere.gameObject.name == "Bullet1(Clone)")
            {
                Destroy(gameObject); 
                Debug.Log("Neutral");
            }
            if (atingere.gameObject.name == "Bullet2(Clone)")
            {
                Destroy(gameObject); 
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
