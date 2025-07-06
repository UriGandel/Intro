using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        ClonarCubo();
    }

    public void ClonarCubo()
    {
        Instantiate(cubePrefab);
    }

}
