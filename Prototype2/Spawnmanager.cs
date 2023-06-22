using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //[]�� �迭(array)�� �ǹ���.
                                       //int�� ����
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        //SpawnRandomAnimal()�� 2�ʵں��� 1.5�ʰ������� ��� ȣ��, ȣ���� �޼��带 Ư�� ������ �����ϰ� Ư�� �ð��������� �ݺ��ϴ� �Լ���.
        //���ڿ��� ����� ȣ����. "SpawnRandomAnimal()"
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal(); SŰ�� ������ SpawnRandomAnimal() �޼���(�Լ�)�� ȣ��.
        }*/
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); //0���� �ִϸ��������� ��� ���� -1��ŭ ���ڷ���.
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
//Start�� Update�޼���� MonoBehaviour Ŭ�������� ������ �Լ��̴�.