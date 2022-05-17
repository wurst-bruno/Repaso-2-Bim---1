using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour
{

    public GameObject brickPrefab;
    public float xOffset;
    public Text userOffset;
    int counter = 0;

    void Start()
    {
       
    }

    void Update()
    {
        
    }

    public void CloneBrick()
    {
        if(counter == 0)
        {
            xOffset = float.Parse(userOffset.text);
        }


        if (counter < 5)
        {
            GameObject clon;
            clon = Instantiate(brickPrefab);
            clon.transform.position = new Vector3(xOffset, 0, 0);
            xOffset += 1.1f;
            counter++;

        }

    }


}

