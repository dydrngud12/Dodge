using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletprefad; // ������ ź�˿� ���� ������
    public float spawnRateMIn = 0.1f; // �ּ� ���� �ֱ�
    public float spawnRateMax = 5f; // �ִ� ���� �ֱ�

    private Transform target; // �߻��� ���
    private float spawnRate; // ���� �ֱ�
    private float timeAfterSpawn; // �ֱ� ���� �������� ���� �ð�
    // Start is called before the first frame update
    void Start()
    {
        // �ֱ�  ���� ������ ���� �ð���0���� �ʱ�ȭ
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
