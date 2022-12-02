using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float Speed = 40f;
    float a = 0f;
    public GameObject playerbullet; //������ ź���� ���� ������
    public GameObject playerboom;
    private GameManager gamemanager;
    GameObject bullet;
    
    public GameObject playerbulletInstantiate;
    float rototi = 0.05f;

    private float timeAfterSpawn; //�ֱ� ���� �������� ���� �ð�


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

        float Input_x = Input.GetAxis("Horizontal");
        float Input_y = Input.GetAxis("Vertical");
        float Speed_x = Input_x * Speed;
        float Speed_y = Input_y * Speed;
        Vector3 newVelocity = new Vector3(Speed_x,0 , Speed_y);
        rigidbody.velocity = newVelocity;

        transform.Rotate(0, 0, -Input_x * Time.deltaTime * 60f);

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, Input_x), Time.deltaTime);

        

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(playerbullet, transform.position, transform.rotation);
        }

        

    }

    public void Die()
    {   //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
        Instantiate(playerboom, transform.position, transform.rotation);
        gamemanager = FindObjectOfType<GameManager>();
        gamemanager.EndGame();
    }
}
