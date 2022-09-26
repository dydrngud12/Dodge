using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �̵��� ����� ������ٵ� ������Ʈ
    private Rigidbody playerRigidbody;
    public float speed = 8f; // �̵� �ӷ�

    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�Ƽ�
        // playerRigidbody(����)�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // ������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 �ӵ��� (xSpeed, 0, zSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // ������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;


        //playerRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, Input.GetAxis("Vertical") * speed);


        //if(Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    // ���� ����Ű �Է��� ������ ��� z ���� �� �ֱ�
        //    playerRigidbody.AddForce(0f, 0f, speed);
        //}
    }

    public void Die()
    {
        // �ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);

        // ���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        GameManager gameManager = FindObjectOfType<GameManager>();
        // ������ GameManager ������Ʈ�� EndGame() �޼��� ����
        gameManager.EndGame();
    }
}