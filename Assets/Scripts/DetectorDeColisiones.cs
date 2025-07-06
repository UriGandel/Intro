using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeColisiones : MonoBehaviour
{
    public ScoreManager scoreManager;
    public MercaderiaScript mercaderiaScript;
    // Start is called before the first frame update

    public void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        mercaderiaScript = GetComponent<MercaderiaScript>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
            scoreManager.AddScore(mercaderiaScript.scorepoints);
        }
       }
    
    
}
