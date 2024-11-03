using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour
{
    public playerController playerController;
    public int iloscPunktowDoZebrania;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (playerController.zebranePunkty == iloscPunktowDoZebrania)
            {
                Debug.Log("Zebrano wszystkie punkty. Koniec gry");
            }
        }
    }
}
