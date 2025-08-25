using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBackground : MonoBehaviour
{
    public GameObject[] background;

    public float zPos = 200;
    public float xPos = 0;

    public bool createBackground = false;

    int backNum;

    // Update is called once per frame
    void Update()
    {
        if (!createBackground)
        {
            createBackground = true;
            StartCoroutine(GenerateBack());
        }
    }

    // Coroutine - method that adds time delays
    IEnumerator GenerateBack()
    {
        backNum = Random.Range(0, 3); // choose between 4 numbers 0-4
        Debug.Log("backNum:" + backNum);

        // check for containerRamp
        if (backNum == 0)
        {
            Debug.Log("section 2");
            xPos = -100;
        }
        else if (backNum == 1)
        {
            Debug.Log("section 3");
            xPos = -100;
        }
        else if (backNum == 2)
        {
            Debug.Log("section 4");
            xPos = -100;
        }
        // else if (backNum == 3)
        // {
        //     Debug.Log("section 4");
        // }
        zPos += 150;
        Instantiate(background[backNum],
        new Vector3(xPos, 0, zPos),
        background[backNum].transform.rotation);

        //zPos += 200;
        yield return new WaitForSeconds(0.5f);
        createBackground = false;
    }
}
