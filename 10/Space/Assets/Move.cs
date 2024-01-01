using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform; // ������ �ڽ� ���� ������Ʈ�� Ʈ������

    private void Start()
    {
        // �ڽ��� ���� ��ġ�� (0.0f, -1.0f, 0.0f)���� ����
        transform.position = new Vector3(0.0f, -1.0f, 0.0f);

        // �ڽ��� ���� ��ġ�� (0.0f, 2.0f, 0.0f)���� ����
        childTransform.localPosition = new Vector3(0.0f, 2.0f, 0.0f);

        // �ڽ��� ���� ȸ���� (0.0f, 0.0f, 30.0f)���� ����
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, 30.0f);

        // �ڽ��� ���� ȸ���� (0.0f, 60.0f, 0.0f)���� ����
        childTransform.localRotation = Quaternion.Euler(0.0f, 60.0f, 0.0f);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // ���� ����Ű�� ������ �ʴ� (0.0f, 1.0f, 0.0f)�� �ӵ��� �����̵�
            transform.Translate(Vector3.up * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // �Ʒ��� ����Ű�� ������ �ʴ� (0.0f, -1.0f, 0.0f)�� �ӵ��� �����̵�
            transform.Translate(Vector3.down * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // ���� ����Ű�� ������
            // �ڽ��� �ʴ� (0.0f, 0.0f, 180.0f) ȸ��
            transform.Rotate(new Vector3(0.0f, 0.0f, 180.0f) * Time.deltaTime);

            // �ڽ��� �ʴ� (0.0f, 180.0f, 0.0f) ȸ��
            childTransform.Rotate(new Vector3(0.0f, 180.0f, 0.0f) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            // ������ ����Ű�� ������
            // �ڽ��� �ʴ� (0.0f, 0.0f, -180.0f) ȸ��
            transform.Rotate(new Vector3(0.0f, 0.0f, -180.0f) * Time.deltaTime);

            // �ڽ��� �ʴ� (0.0f, -180.0f, 0.0f) ȸ��
            childTransform.Rotate(new Vector3(0.0f, -180.0f, 0.0f) * Time.deltaTime);
        }
    }
}
