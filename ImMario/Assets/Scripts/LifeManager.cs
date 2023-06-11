using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public Text Life_text;
    public int life = 3;

    void Update()
    {
        if (life > 0)
            Life_text.text = "Life x" + life;
        else
            Life_text.text = "Game Over";
    }

    public void life_add()
    {
        life++;
    }

    public void death()
    {
        life--;
        SceneManager.LoadScene("ImMario");
    }
}