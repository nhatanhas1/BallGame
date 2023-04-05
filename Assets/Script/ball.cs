using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    GameController mGC;
    UIComponents mUI;
    // Start is called before the first frame update
    void Start()
    {
        mGC = FindObjectOfType<GameController>();
        mUI = FindObjectOfType<UIComponents>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            mGC.IncrementScore(); //??ng thanh bar =>t?ng ?i?m
            Destroy(gameObject);
            Debug.Log("Ball hit Bar.");
           
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DeadBar")
        {
            mGC.SetGameOver(true); // không ??ng thanh bar => gameOver
            Debug.Log("Ball hit DeadBar.");
            mUI.GameOverPanel(true);
            Destroy(gameObject);
        }
    }
}
