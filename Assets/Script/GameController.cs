using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime = 5f;


    float mSpawn;
    public int mScore;
    bool mGameOver;

    UIComponents mUI;

    // Start is called before the first frame update
    void Start()
    {
        mScore = 0;
        //FindObjectOfType(): tìm ki?u d? li?u theo tên
        mUI = FindObjectOfType<UIComponents>();
        mUI.SetScoreText("Score: 0");
    }

    // Update is called once per frame
    void Update()
    {
        if (mGameOver)
        {
            mScore = 0;
            mUI.SetScoreText("Score: 0");
            return;
        }    

        if (ball != null)
        {
            mSpawn -= Time.deltaTime;
            if(mSpawn < 0)
            {
                //Random.range(): sinh s? ng?u nhiên trong m?t kho?ng
                Vector2 pos = new Vector2(Random.Range(-5, 5), 6);
                //hàm Instantiate(); t?o ??i t??ng GameObject
                //có 3 tham s?
                //tham s? 1: ??i t??ng c?n t?o
                //tham s? 2: v? trí, t?a ?? ??i t??ng xu?t hi?n trên màn hình
                //tham s? 3: góc xoay, tính toán theo Quaternion
                Instantiate(ball, pos, Quaternion.identity);
                mSpawn = spawnTime; // reset mSpaw
            }
            
        }

    }

    public void SetScore(int score)
    {
        mScore = score;
    }

    public int GetScore()
    {
        return mScore;
    }

    public void IncrementScore()
    {
        mScore++;
        mUI.SetScoreText("Score: " + mScore);
    }

    public void SetGameOver(bool state)
    {
        mGameOver = state;
    }

    public bool IsGamevOver()
    {
        return mGameOver;
    }

    public void Replay()
    {
        mGameOver = false;
        mUI.GameOverPanel(false); //?n Panel
    }
}
