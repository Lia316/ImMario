using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomGet : MonoBehaviour
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
        if(collision.collider.CompareTag("Mushroom"))
        {
            AudioManager.Instance.PlaySFX("1-up");
            Destroy(collision.gameObject);
            GamePlayEvent.life_add();
        }
    }
}
