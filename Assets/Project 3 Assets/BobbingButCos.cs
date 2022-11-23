using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobbingButCos : MonoBehaviour
{   
    Vector3 posOffSet = new Vector3();
    Vector3 tempPos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        posOffSet = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = posOffSet;
        tempPos.y += Mathf.Cos(Time.fixedTime * Mathf.PI) * 0.25f;

        transform.position = tempPos;
    }
}
