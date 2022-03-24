using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fire;
    public GameObject water;
    public GameObject nature;
    public float spawn_rate;
    private int floor1, floor2, floor3, floor4, floor5;
    private float spawnloc = 19;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnning",spawn_rate,spawn_rate);       
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
            Instantiate(water, new Vector3(spawnloc, -6.94f,0f), Quaternion.identity);
        else if (floor1==2)
            Instantiate(fire, new Vector3(spawnloc, -6.94f,0f), Quaternion.identity);
        else
            Instantiate(nature, new Vector3(spawnloc,-6.94f,0f ),Quaternion.identity);

        if (floor2==1)
            Instantiate(water, new Vector3(spawnloc, -4.2f,0f), Quaternion.identity);
        else if (floor2==2)
            Instantiate(fire, new Vector3(spawnloc, -4.2f,0f), Quaternion.identity);
        else
            Instantiate(nature, new Vector3(spawnloc,-4.2f,0f ),Quaternion.identity);

        if (floor3==1)
            Instantiate(water, new Vector3(spawnloc, -1.46f,0f), Quaternion.identity);
        else if (floor3==2)
            Instantiate(fire, new Vector3(spawnloc, -1.46f,0f), Quaternion.identity);
        else
            Instantiate(nature, new Vector3(spawnloc,-1.46f,0f ),Quaternion.identity);

        if (floor4==1)
            Instantiate(water, new Vector3(spawnloc, 1.28f,0f), Quaternion.identity);
        else if (floor4==2)
            Instantiate(fire, new Vector3(spawnloc, 1.28f,0f), Quaternion.identity);
        else
            Instantiate(nature, new Vector3(spawnloc,1.28f,0f ),Quaternion.identity);

         if (floor5==1)
            Instantiate(water, new Vector3(spawnloc, 4.02f,0f), Quaternion.identity);
        else if (floor5==2)
            Instantiate(fire, new Vector3(spawnloc, 4.02f,0f), Quaternion.identity);
        else
            Instantiate(nature, new Vector3(spawnloc,4.02f,0f ),Quaternion.identity);
    }        

}
