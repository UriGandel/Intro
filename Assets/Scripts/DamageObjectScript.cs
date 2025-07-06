using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObjectScript : MonoBehaviour
{
    public HealthManager healthManager;
    public VidaScript vidaScript;

    public void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
        vidaScript = GetComponent<VidaScript>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
            healthManager.TakeDamage(vidaScript.healthPoints);

        }
    }
}