using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerGet : MonoBehaviour
{
    private GameObject playerHand;

    // Start is called before the first frame update
    void Start()
    {
        playerHand = GameObject.Find("MarioRightHand");
        playerHand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Flower"))
        {
            print("collision with flower!");
            AudioManager.Instance.PlaySFX("useitem");
            Destroy(collision.gameObject);
            playerHand.SetActive(true);
        }
    }
}
