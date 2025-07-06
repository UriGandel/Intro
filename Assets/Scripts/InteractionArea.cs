using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject UIinteractionMessage;
    public bool canInteract;
    MercaderiaScript mercaderia;
    // Start is called before the first frame update
    void Start()
    {
        UIinteractionMessage.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canInteract)
            {
                Destroy(mercaderia.gameObject);
                EndInteraction();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        mercaderia = other.GetComponent<MercaderiaScript>();
        if (mercaderia)
        {
            UIinteractionMessage.SetActive(true);
            canInteract = true;


        }
    }
    private void OnTriggerExit(Collider other)
    {
        EndInteraction();
    }
    void EndInteraction()
    {
        UIinteractionMessage.SetActive(false);
        canInteract = false;
        mercaderia = null;
    }
}
