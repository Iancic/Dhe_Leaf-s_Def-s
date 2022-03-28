using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wave_Controller : MonoBehaviour
{
    Text wave;

    void Start()
    {
        wave = GetComponent<Text> ();
    }

    void Update()
    {
        wave.text = "Wave " + Spawner.wave;
    }
}
