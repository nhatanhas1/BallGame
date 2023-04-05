using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    
    public float speed = 8f;
    float xMin, xMax;
    GameController mGC;

    Transform bar;

    // Start is called before the first frame update
    void Start()
    {
        mGC = FindObjectOfType<GameController>();
        bar = this.transform;
        float worldHeight = 2 * Camera.main.orthographicSize;
        float worldWidth = worldHeight * Screen.width/ Screen.height;

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        float barWidth = sr.bounds.size.x;

        xMin = -(worldWidth - barWidth) / 2;
        xMax = (worldWidth - barWidth) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (!mGC.IsGamevOver())
        {
            float xPos = Input.GetAxisRaw("Horizontal");
            //* deltatime => ch?ng gi?t
            float moveSpeed = speed * xPos * Time.deltaTime;

            Vector3 pos = transform.position;

            if ((pos.x < xMin && moveSpeed < 0) || (pos.x > xMax && moveSpeed > 0))
            {
                return;
            }
            pos.x += moveSpeed;
            transform.position = pos;
            //bar.transform.position = pos.x;
        }


    }


}
