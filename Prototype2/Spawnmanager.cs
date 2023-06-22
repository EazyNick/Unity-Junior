using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //[]은 배열(array)을 의미함.
                                       //int는 정수
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        //SpawnRandomAnimal()을 2초뒤부터 1.5초간격으로 계속 호출, 호출한 메서드를 특정 시점에 시작하고 특정 시간간격으로 반복하는 함수다.
        //문자열을 사용해 호출함. "SpawnRandomAnimal()"
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal(); S키를 누르면 SpawnRandomAnimal() 메서드(함수)를 호출.
        }*/
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); //0부터 애니몰프리팹의 어레이 길이 -1만큼 숫자랜덤.
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
//Start와 Update메서드는 MonoBehaviour 클래스에서 유래된 함수이다.