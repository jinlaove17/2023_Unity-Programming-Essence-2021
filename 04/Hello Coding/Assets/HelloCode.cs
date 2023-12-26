using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    private void Start()
    {
        // Hello World!�� �ֿܼ� ���
        Debug.Log("Hello World!");

        // ĳ������ �������� ������ �����
        string characterName = "���";
        char bloodType = 'A';
        int age = 17;
        float height = 168.3f;
        bool isFemale = true;

        // ������ ������ �ֿܼ� ���
        Debug.Log("ĳ���� �̸�: " + characterName);
        Debug.Log("������: " + bloodType);
        Debug.Log("����: " + age);
        Debug.Log("Ű: " + height);
        Debug.Log("�����ΰ�?: " + isFemale);

        // GetDistance() �޼���� (2, 2)���� (5, 6)������ �Ÿ� ���ϱ�
        float distance = GetDistance(2, 2, 5, 6);

        Debug.Log("(2, 2)���� (5, 6)������ �Ÿ� : " + distance);

        // if������ �б� ������
        int love = 80;

        if (love > 90)
        {
            Debug.Log("Ʈ�� ����: �����ΰ� ��ȥ�ߴ�!");
        }
        else if (love > 70)
        {
            Debug.Log("�� ����: �����ΰ� ��Ͱ� �Ǿ���!");
        }
        else
        {
            Debug.Log("��� ����: �����ο��� ������.");
        }

        age = 11;

        if ((7 < age) && (age < 18))
        {
            Debug.Log("�ǹ� ������ �ް� �ֽ��ϴ�.");
        }
        
        if ((age < 13) || (age > 70))
        {
            Debug.Log("���� �� �� ���� �����Դϴ�.");
        }

        // for������ �ݺ��ϱ�
        for (int i = 0; i < 10; ++i)
        {
            Debug.Log(i + "��° �����Դϴ�.");
        }

        // while������ �ݺ��ϱ�
        bool isDead = false;
        int hp = 100;

        while (!isDead)
        {
            Debug.Log("���� ü�� : " + hp);
            hp -= 33;

            if (hp <= 0)
            {
                isDead = true;
                Debug.Log("�÷��̾�� �׾����ϴ�.");
            }
        }

        // �迭�� �л� ���� �����ϱ�
        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        for (int i = 0; i < students.Length; ++i)
        {
            Debug.Log((i + 1) + "�� �л��� ����: " + students[i]);
        }
    }

    public float GetDistance(float x1, float y1, float x2, float y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        return Mathf.Sqrt(width * width + height * height);
    }
}
