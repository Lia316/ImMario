using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;
public class CoinManager : MonoBehaviour
{
    public Text Coin_text;
    public int coin = 0;

/*    // Start is called before the first frame update
    void Start()
    {
        
    }
*/
    // Update is called once per frame
    void Update()
    {
        Coin_text.text = "Coin : " + coin;
    }

    public void coin_add()
    {
        coin++;
    }
}
