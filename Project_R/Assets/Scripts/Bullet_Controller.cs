using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet_Controller : MonoBehaviour
{

    public float Speed;
    private int bulletdist=18;
    private Rigidbody2D corp_rb;
    

    void Start()
    {
        corp_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        corp_rb.AddForce(new Vector2(Speed,0), ForceMode2D.Impulse);

        //evitarea lag-ului prin eliminarea gloantelor inutile
        if (this.transform.position.x > bulletdist)
            Destroy(gameObject);
    }

        void OnCollisionEnter2D(Collision2D atingere)
    {
        if (atingere.gameObject.name != "Bullet1(Clone)" && atingere.gameObject.name != "Bullet2(Clone)" && atingere.gameObject.name != "Bullet3(Clone)" && atingere.gameObject.name != "Tree")
        Destroy(gameObject); 
    }
}