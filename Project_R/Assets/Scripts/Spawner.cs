using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fire;
    public GameObject water;
    public GameObject nature;
    public float spawn_rate, spawnloc = 19;
    private int floor1, floor2, floor3, floor4, floor5, timestamp;
    public static int wave = 0;

    void Start()
    {
        StartCoroutine( Startup() );
    }

    IEnumerator Startup()
    {
        timestamp = UnityEngine.Random.Range(1,3);
        yield return new WaitForSeconds(timestamp);
        InvokeRepeating("Spawnning",spawn_rate,spawn_rate);             
     
    }

    void Spawnning()
    {
        //spawn generation
        floor1 = UnityEngine.Random.Range(0,5);
        floor2 = UnityEngine.Random.Range(0,5);
        floor3 = UnityEngine.Random.Range(0,5);
        floor4 = UnityEngine.Random.Range(0,5);
        floor5 = UnityEngine.Random.Range(0,5);

        if (floor1==1)
            Instantiate(water, new Vector3(spawnloc, -6.94f,0f), Quaternion.identity);
        else if (floor1==2)
            Instantiate(fire, new Vector3(spawnloc, -6.94f,0f), Quaternion.identity);
        else if (floor1==3)
            Instantiate(nature, new Vector3(spawnloc,-6.94f,0f ),Quaternion.identity);

        if (floor2==1)
            Instantiate(water, new Vector3(spawnloc, -4.2f,0f), Quaternion.identity);
        else if (floor2==2)
            Instantiate(fire, new Vector3(spawnloc, -4.2f,0f), Quaternion.identity);
        else if (floor2==3)
            Instantiate(nature, new Vector3(spawnloc,-4.2f,0f ),Quaternion.identity);

        if (floor3==1)
            Instantiate(water, new Vector3(spawnloc, -1.46f,0f), Quaternion.identity);
        else if (floor3==2)
            Instantiate(fire, new Vector3(spawnloc, -1.46f,0f), Quaternion.identity);
        else if (floor3==3)
            Instantiate(nature, new Vector3(spawnloc,-1.46f,0f ),Quaternion.identity);

        if (floor4==1)
            Instantiate(water, new Vector3(spawnloc, 1.28f,0f), Quaternion.identity);
        else if (floor4==2)
            Instantiate(fire, new Vector3(spawnloc, 1.28f,0f), Quaternion.identity);
        else if (floor4==3)
            Instantiate(nature, new Vector3(spawnloc,1.28f,0f ),Quaternion.identity);

         if (floor5==1)
            Instantiate(water, new Vector3(spawnloc, 4.02f,0f), Quaternion.identity);
        else if (floor5==2)
            Instantiate(fire, new Vector3(spawnloc, 4.02f,0f), Quaternion.identity);
        else if (floor5==3)
            Instantiate(nature, new Vector3(spawnloc,4.02f,0f ),Quaternion.identity);
        
        wave = wave + 1;
    }        

}
