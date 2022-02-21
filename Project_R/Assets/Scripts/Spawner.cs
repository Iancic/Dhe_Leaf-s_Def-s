using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fire;
    public GameObject water;
    public GameObject nature;
    public float spawn_rate;
    private int floor1;
    private int floor2;
    private int floor3;
    private int floor4;
    private int floor5;
    private float spawnloc = 33;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnning",spawn_rate,spawn_rate);       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawnning()
    {
        //spawn generation
        floor1 = UnityEngine.Random.Range(0,3);
        floor2 = UnityEngine.Random.Range(0,3);
        floor3 = UnityEngine.Random.Range(0,3);
        floor4 = UnityEngine.Random.Range(0,3);
        floor5 = UnityEngine.Random.Range(0,3);

        if (floor1==1)
            Instantiate(water, new Vector3(spawnloc, 0f,0f), Quaternion.identity);
        else
            Instantiate(fire, new Vector3(spawnloc, 0f,0f), Quaternion.identity);

        if (floor2==1)
            Instantiate(water, new Vector3(spawnloc, 3f,0f), Quaternion.identity);
        else
            Instantiate(fire, new Vector3(spawnloc, 3f,0f), Quaternion.identity);

        if (floor3==1)
            Instantiate(water, new Vector3(spawnloc, 6f,0f), Quaternion.identity);
        else
            Instantiate(fire, new Vector3(spawnloc, 6f,0f), Quaternion.identity);

        if (floor4==1)
            Instantiate(water, new Vector3(spawnloc, 9f,0f), Quaternion.identity);
        else
            Instantiate(fire, new Vector3(spawnloc, 9f,0f), Quaternion.identity);

         if (floor5==1)
            Instantiate(water, new Vector3(spawnloc, 12f,0f), Quaternion.identity);
        else
            Instantiate(fire, new Vector3(spawnloc, 12f,0f), Quaternion.identity);
    }        

}
