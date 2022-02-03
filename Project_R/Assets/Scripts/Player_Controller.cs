using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public Vector2 directions;
    public GameObject spawnabble;
    private int bullet_type = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //sistemul de shoot gloante
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(spawnabble, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity);

        //sistemul de movement cu limitari pe axa y
        if (Input.GetKeyUp(KeyCode.W) && this.transform.position.y !=9 )
            transform.position += new Vector3(0f, 3f, 0f);

        else if (Input.GetKeyUp(KeyCode.S) && this.transform.position.y !=0)
            transform.position -= new Vector3(0f, 3f, 0f);
    }
}
