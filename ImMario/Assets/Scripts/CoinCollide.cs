using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollide : MonoBehaviour
{
    public GamePlayManager GamePlayEvent;

    // Start is called before the first frame update
    void Start()
    {
        GamePlayEvent = GameObject.Find("EventSystem").GetComponent<GamePlayManager>();
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
            GamePlayEvent.coin_add();
        }
    }
}
