using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{

    public float Speed;
    private int bulletdist=33;
    private Rigidbody2D corp_rb;
    
    // Start is called before the first frame update
    void Start()
    {
        corp_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        corp_rb.AddForce(new Vector2(Speed,0), ForceMode2D.Impulse);

        //evitarea lag-ului prin eliminarea gloantelor inutile
        if (this.transform.position.x > bulletdist)
            Destroy(gameObject);
    }

        void OnCollisionEnter2D(Collision2D atingere)
    {
        if (atingere.gameObject.name != "Player" && atingere.gameObject.name != "Bullet1(Clone)" && atingere.gameObject.name != "Bullet2(Clone)" && atingere.gameObject.name != "Bullet3(Clone)" && atingere.gameObject.name != "Tree")
           Destroy(gameObject); 
    }
}