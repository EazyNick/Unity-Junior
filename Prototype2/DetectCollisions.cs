using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)//MonoBehaviour클래스에 있는 메서드, 한콜라이더가 다른 콜라이더와 충돌할 때마다 실행
    {
        Destroy(gameObject); //충돌한 오브젝트 삭제
        Destroy(other.gameObject); //다른 오브젝트도 삭제
    }



}
