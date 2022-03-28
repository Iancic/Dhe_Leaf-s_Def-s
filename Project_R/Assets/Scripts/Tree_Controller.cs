using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_Controller : MonoBehaviour
{

    public GameObject healthbar;
    private int hitpoints = 3;
    private SpriteRenderer rend;
    private Sprite nexthitbar;
    public Sprite health1, health2, health3;

    void Start()
    {
        //hitbar
        rend = healthbar.GetComponent<SpriteRenderer>();
        rend.sprite = health3;
        
    }

    void OnCollisionEnter2D(Collision2D atingere)
    {

        if ( gameObject.tag == "Tree")
        {
            if ( atingere.gameObject.name == "Nature(Clone)" || atingere.gameObject.name == "Water(Clone)" || atingere.gameObject.name == "Fire(Clone)" )
            {
                hitpoints = hitpoints - 1;

                if ( hitpoints == 2 )
                    {
                    nexthitbar = health2;
                    rend.sprite = nexthitbar;
                    }
                if ( hitpoints == 1 )
                    {
                    nexthitbar = health1; 
                    rend.sprite = nexthitbar;
                    }
                if ( hitpoints == 0  || hitpoints < 0)
                    // Application.Quit() does not work in the editor so
                    // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
                    UnityEditor.EditorApplication.isPlaying = false;
            }
        } 
    }
}
