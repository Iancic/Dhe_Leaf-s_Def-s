using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Controller : MonoBehaviour
{
    Text score;

    void Start()
    {
        score = GetComponent<Text> ();
    }

    void Update()
    {
        score.text = "Score " + Enemy_Controller.score;
    }
}
