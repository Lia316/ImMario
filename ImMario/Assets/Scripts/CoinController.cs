using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public CoinManager CoinEvent;

    void Start()
    {
        CoinEvent = GameObject.Find("EventSystem").GetComponent<CoinManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")|| collision.gameObject.CompareTag("Head"))
        {
            AudioManager.Instance.PlaySFX("coin");
            CoinEvent.coin_add();
            GameObject.Destroy(this.gameObject);
        }
    }
}
