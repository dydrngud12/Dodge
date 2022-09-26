using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 16; // ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody; // �̵��� ����� ������ٵ� ������Ʈ


    void Start()
    {
        // ���� ������Ʈ���� Rigigdbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        // ������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        // 15�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 15f);

        // Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
        void OnTriggerEnter(Collider other)
        {
            //�浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
            if (other.tag == "Player")
            {
                // ���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
                PlayerController playerController = other.GetComponent<PlayerController>();

                // ���� playerContro,ller ������Ʈ�� �������� �� �����ߴٸ�
                if (playerController != null)
                {
                    // ���� PlayerController ������Ʈ�� Die() �޼��� ����
                    playerController.Die();
                }
            }
        }
    }
}
