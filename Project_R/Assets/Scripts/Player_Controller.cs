using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Vector2 directions;
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;
    //public GameObject Spell1;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //sistemul de shoot gloante

        //water bullet 1
        if (Input.GetKeyDown(KeyCode.Q))
        {
                Instantiate(bullet1, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity);
        }

        //fire bullet 2
        if (Input.GetKeyDown(KeyCode.W))
        {
                Instantiate(bullet2, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity);
        }

        //nature bullet3
        if (Input.GetKeyDown(KeyCode.E))
        {
                Instantiate(bullet3, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity);
        }

        /* sistemul de abilitati
        if (Input.GetKeyDown(KeyCode.R))
        {
                Instantiate(Spell1, new Vector3(this.transform.position.x,this.transform.//position.y,0), Quaternion.identity);
        } */

        //sistemul de movement cu limitari pe axa y
        if (Input.GetKeyDown(KeyCode.UpArrow) && this.transform.position.y == 1.05f )
            transform.position += new Vector3(0f, 3f, 0f);

        else if (Input.GetKeyDown(KeyCode.DownArrow) && this.transform.position.y !=0)
            transform.position -= new Vector3(0f, 3f, 0f);
    }
}
