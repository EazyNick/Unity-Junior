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
        if (transform.position.x < -xRange) //�÷��̾��� x��ġ�� -10���� �۴ٸ�
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); //��ġ����
        }
        if (transform.position.x > xRange) //�÷��̾��� x��ġ�� -10���� �۴ٸ�
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); //��ġ����
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); //�¿� �̵�

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); //�����̽��� ������ ���ٱ� ����.
            // Instantiate�� �����ϴ� ������Ʈ ���纻�� ����� �� �ְ� ����. (��ü, ��������, ȸ��)
        }
    }
}

// GetKey�� Ű�� ���� �� true�� ��ȯ, GetKeyDown�� Ű�� ���� ������ �� True��, GetKeyUp�� Ű���� �հ����� �� �� true�� ��ȯ
// Input.GetAxis("??"? Prototype 1������ �̰ɷ� ������ȯ��.
