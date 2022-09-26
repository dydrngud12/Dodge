using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletprefad; // 생성할 탄알원 원본 프리팹
    public float spawnRateMIn = 0.1f; // 최소 생성 주기
    public float spawnRateMax = 5f; // 최대 생성 주기

    private Transform target; // 발사할 대상
    private float spawnRate; // 생성 주기
    private float timeAfterSpawn; // 최근 생성 시점에서 지난 시간
    // Start is called before the first frame update
    void Start()
    {
        // 최근  생성 이후의 누적 시간을0으로 초기화
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
