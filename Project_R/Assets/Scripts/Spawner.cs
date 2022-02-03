using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject ally;
    private int floor1;
    private int floor2;
    private int floor3;
    private int floor4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //spawn generation
        floor1 = UnityEngine.Random.Range(0,2);
        floor2 = UnityEngine.Random.Range(0,2);
        floor3 = UnityEngine.Random.Range(0,2);
        floor4 = UnityEngine.Random.Range(0,2);

        if (floor1==1)
            Instantiate(ally, new Vector3(19f, 0f,0f), Quaternion.identity);
        else
            Instantiate(enemy, new Vector3(19f, 0f,0f), Quaternion.identity);

        if (floor2==1)
            Instantiate(ally, new Vector3(19f, 3f,0f), Quaternion.identity);
        else
            Instantiate(enemy, new Vector3(19f, 3f,0f), Quaternion.identity);

        if (floor3==1)
            Instantiate(ally, new Vector3(19f, 6f,0f), Quaternion.identity);
        else
            Instantiate(enemy, new Vector3(19f, 6f,0f), Quaternion.identity);

        if (floor4==1)
            Instantiate(ally, new Vector3(19f, 9f,0f), Quaternion.identity);
        else
            Instantiate(enemy, new Vector3(19f, 9f,0f), Quaternion.identity);
    }
}
