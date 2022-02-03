using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ally_Controller : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-Speed, 0f, 0f);

        if (this.transform.position.x < 0)
            Destroy(gameObject);
    }
}
