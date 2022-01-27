using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    float Speed = 0;
    Vector2 startPos;

    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //마우스 단추를 클릭한 좌표
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //마우스 버튼에서 손가를 떼었을 때 좌표
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - this.startPos.x);

            //스와이프 길이를 처음 속도로 변경
            this.Speed = swipeLength / 1000.0f;


            GetComponent<AudioSource>().Play();

        }

        transform.Translate(this.Speed, 0, 0);
        this.Speed *= 0.98f;

    }
}
