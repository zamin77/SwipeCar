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
            //���콺 ���߸� Ŭ���� ��ǥ
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //���콺 ��ư���� �հ��� ������ �� ��ǥ
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - this.startPos.x);

            //�������� ���̸� ó�� �ӵ��� ����
            this.Speed = swipeLength / 1000.0f;


            GetComponent<AudioSource>().Play();

        }

        transform.Translate(this.Speed, 0, 0);
        this.Speed *= 0.98f;

    }
}
