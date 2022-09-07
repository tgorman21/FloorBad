using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        tmp.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = "" + score;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            score = score -= 1;
            Destroy(collision.gameObject);
        }
    }
}
