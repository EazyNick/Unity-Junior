using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 15.0f;
    private float xRange = 20.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange) //플레이어의 x위치가 -10보다 작다면
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); //위치제한
        }
        if (transform.position.x > xRange) //플레이어의 x위치가 -10보다 작다면
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); //위치제한
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); //좌우 이동

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); //스페이스바 누르면 뼈다귀 복사.
            // Instantiate는 존재하는 오브젝트 복사본을 사용할 수 있게 해줌. (물체, 시작지점, 회전)
        }
    }
}

// GetKey는 키를 누를 때 true를 반환, GetKeyDown은 키가 눌린 상태일 때 True를, GetKeyUp은 키에서 손가락을 뗄 때 true를 반환
// Input.GetAxis("??"? Prototype 1에서는 이걸로 방향전환함.
