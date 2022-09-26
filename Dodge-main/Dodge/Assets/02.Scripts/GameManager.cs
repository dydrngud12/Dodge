using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ���� ���̺귯��
using UnityEngine.SceneManagement; // �� ���� ���� ���̺귯��
using TMPro; // TextMeshPro ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    // ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public GameObject gameoverText;
    // ���� �ð��� ǥ���� TextMeshPro ������Ʈ
    public TextMeshProUGUI timeText;
    // �ְ� ����� ǥ���� TextMeshPro ������Ʈ
    public TextMeshProUGUI recordText;

    private float surviveTime; // ���� �ð�
    private bool isGameover; // ���ӿ��� ����

    void Start()
    {
        // ���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0;
        isGameover = false;        
    }

    void Update()
    {
        // ���ӿ����� �ƴ� ����
        if (!isGameover)
        {
            // ���� �ð� ����
            surviveTime += Time.deltaTime;
            // ������ ���� �ð��� timeText
            // TextMeshPro ������Ʈ�� �̿��� ǥ��
            timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {
            // ���ӿ��� ���¿��� RŰ�� �����ٸ�,
            if (Input.GetKeyDown(KeyCode.R))
            {
                // MainScene ���� �ε�
                SceneManager.LoadScene(0);
            }
        }
    }

    // ���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {
        // ���� ���¸� ���ӿ��� ���·� ��ȯ
        isGameover = true;
        // ���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
        gameoverText.SetActive(true);

        // BestTime Ű�� ����� ���������� �ְ� ��� ��������
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // ���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if(surviveTime > bestTime)
        {
            // �ְ��ϰ��� ���� ���� �ð� ������ ����
            bestTime = surviveTime;
            // ����� �ְ� ����� BestTime Ű�� ����
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        // �ְ� ����� recordText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
        recordText.text = "Best Time : " + (int)bestTime;
    }
}
