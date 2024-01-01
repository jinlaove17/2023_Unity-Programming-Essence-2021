using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform; // 움직일 자식 게임 오브젝트의 트랜스폼

    private void Start()
    {
        // 자신의 전역 위치를 (0.0f, -1.0f, 0.0f)으로 변경
        transform.position = new Vector3(0.0f, -1.0f, 0.0f);

        // 자식의 지역 위치를 (0.0f, 2.0f, 0.0f)으로 변경
        childTransform.localPosition = new Vector3(0.0f, 2.0f, 0.0f);

        // 자신의 전역 회전을 (0.0f, 0.0f, 30.0f)으로 변경
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, 30.0f);

        // 자식의 지역 회전을 (0.0f, 60.0f, 0.0f)으로 변경
        childTransform.localRotation = Quaternion.Euler(0.0f, 60.0f, 0.0f);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // 위쪽 방향키를 누르면 초당 (0.0f, 1.0f, 0.0f)의 속도로 평행이동
            transform.Translate(Vector3.up * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // 아래쪽 방향키를 누르면 초당 (0.0f, -1.0f, 0.0f)의 속도로 평행이동
            transform.Translate(Vector3.down * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 왼쪽 방향키를 누르면
            // 자신을 초당 (0.0f, 0.0f, 180.0f) 회전
            transform.Rotate(new Vector3(0.0f, 0.0f, 180.0f) * Time.deltaTime);

            // 자식을 초당 (0.0f, 180.0f, 0.0f) 회전
            childTransform.Rotate(new Vector3(0.0f, 180.0f, 0.0f) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            // 오른쪽 방향키를 누르면
            // 자신을 초당 (0.0f, 0.0f, -180.0f) 회전
            transform.Rotate(new Vector3(0.0f, 0.0f, -180.0f) * Time.deltaTime);

            // 자식을 초당 (0.0f, -180.0f, 0.0f) 회전
            childTransform.Rotate(new Vector3(0.0f, -180.0f, 0.0f) * Time.deltaTime);
        }
    }
}
