using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public int maxHealthPoints;
    public UiManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        healthPoints = maxHealthPoints;
        uiManager = FindObjectOfType<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(int damagePoints)
    {
        if(healthPoints >= damagePoints)
        {
            healthPoints -= damagePoints;
            uiManager.UpdateHealth(healthPoints);
        }
    }

}
