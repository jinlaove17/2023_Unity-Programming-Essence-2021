using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody; // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8.0f; // �̵� �ӷ�

    private void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //// ���� ����Ű �Է��� ������ ��� z ���� �� �ֱ�
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    playerRigidbody.AddForce(0.0f, 0.0f, speed);
        //}

        //// �Ʒ��� ����Ű �Է��� ������ ��� -z ���� �� �ֱ�
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    playerRigidbody.AddForce(0.0f, 0.0f, -speed);
        //}

        //// ������ ����Ű �Է��� ������ ��� x ���� �� �ֱ�
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    playerRigidbody.AddForce(speed, 0.0f, 0.0f);
        //}

        //// ���� ����Ű �Է��� ������ ��� -x ���� �� �ֱ�
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    playerRigidbody.AddForce(-speed, 0.0f, speed);
        //}

        // ������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 �ӵ��� (xSpeed, 0.0f, zSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0.0f, zSpeed);

        // ������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        // �ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);

        // ���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        GameManager gameManager = FindObjectOfType<GameManager>();

        // ������ GameManager ������Ʈ�� EndGame() �޼��� ����
        if (gameManager != null)
        {
            gameManager.EndGame();
        }
    }
}
