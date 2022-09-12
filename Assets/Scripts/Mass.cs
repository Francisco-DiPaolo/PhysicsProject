using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mass : MonoBehaviour
{
    public Text textMass;

    public GameObject[] arrayBalls;

    public float massCount;

    private void Start()
    {
        massCount = arrayBalls[1].GetComponent<Rigidbody>().mass;
        textMass.text = "Mass: " + massCount.ToString();
    }
    public void SumarMass()
    {

        for (int i = 0; i < arrayBalls.Length; i++)
        {
            arrayBalls[i].GetComponent<Rigidbody>().mass += 0.5f;
        }

        textMass.text = "Mass: " + massCount.ToString();
        massCount = arrayBalls[1].GetComponent<Rigidbody>().mass;
    }


}
