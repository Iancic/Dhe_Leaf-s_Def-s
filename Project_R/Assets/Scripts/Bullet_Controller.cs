using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{

    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Speed, 0f, 0f);

        //evitarea lag-ului prin eliminarea gloantelor inutile
        if (this.transform.position.x > 20)
            Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("ma omor");
        Destroy(gameObject);
    }
}