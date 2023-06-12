using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagFinalController : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Head"))
        {
            //            AudioManager.Instance.PlaySFX("What Sound??");
            print("Game Clear");
            GamePlayEvent.GameClear = true;
        }
    }
}
