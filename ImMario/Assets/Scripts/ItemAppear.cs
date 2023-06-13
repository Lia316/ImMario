using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAppear : MonoBehaviour
{
    public Transform item;
    public float moveHeight = 0.9f;
    public float animationSpeed = 0.8f;
    private float newHeight = 0.0f;
    bool isBoxEnabled = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBoxEnabled && (newHeight <= moveHeight))
        {
            AudioManager.Instance.PlaySFX("powerupappears");
            newHeight += Time.deltaTime * animationSpeed;
            item.position = new Vector3(item.position.x, item.position.y + newHeight, item.position.z);
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(isBoxEnabled && collision.collider.CompareTag("Head"))
        {
            isBoxEnabled = false;
        }
    }
}
