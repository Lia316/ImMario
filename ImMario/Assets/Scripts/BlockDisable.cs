using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDisable : MonoBehaviour
{
    public Material[] material;
    public float moveHeight = 0.75f;
    public float animationSpeed = 0.8f;

    private Renderer rend;
    private Transform item;
    private bool isBoxEnabled = true;
    private float newHeight = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;

        item = GameObject.Find("fire_flower").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBoxEnabled && (newHeight <= moveHeight))
        {
            newHeight += Time.deltaTime * animationSpeed;
            item.position = new Vector3(item.position.x, item.position.y + newHeight, item.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(isBoxEnabled && collision.collider.CompareTag("Head"))
        {
            print("collision with box & head!");
            var mats = rend.materials;
            mats[1] = material[3];
            mats[0] = material[2];
            rend.materials = mats;

            isBoxEnabled = false;
        }
    }
}
