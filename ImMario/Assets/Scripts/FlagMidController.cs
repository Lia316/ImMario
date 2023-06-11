using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagMidController : MonoBehaviour
{
    public RespawnManager RespawnEvent;

    // Start is called before the first frame update
    void Start()
    {
        RespawnEvent = GameObject.Find("EventSystem").GetComponent<RespawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Head"))
        {
            //            AudioManager.Instance.PlaySFX("What Sound??");
            print("Mid Save");
            RespawnEvent.midsave = true;
        }
    }
}
