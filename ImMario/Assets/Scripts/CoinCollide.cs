using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollide : MonoBehaviour
{
    public CoinManager CoinEvent;

    // Start is called before the first frame update
    void Start()
    {
        CoinEvent = GameObject.Find("EventSystem").GetComponent<CoinManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            AudioManager.Instance.PlaySFX("coin");
            CoinEvent.coin_add();
        }
    }
}
