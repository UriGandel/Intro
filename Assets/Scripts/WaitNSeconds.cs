using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitNSeconds : MonoBehaviour
{
    public float timeToWait;
    float timeElapsed;
    public Transform cuboTR;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitUntilElevate());

    }

    // Update is called once per frame
    void Update()
    {
        //if(timeElapsed >= timeToWait)
        //{
        //    Debug.Log("Tiempo cumplido");
        //    ElevateCube();
        //    timeElapsed = 0;
        //}
        //else
        //{
        //    Debug.Log(timeElapsed += Time.deltaTime);
        //}
    }

    IEnumerator WaitUntilElevate()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToWait);
            ElevateCube();
        }
    }

    void ElevateCube()
    {
        cuboTR.position += Vector3.up * 2;

    }
}
