using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 10f;//ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody;//�̵��� ����� ������ٵ� ������Ʈ
    Transform transfom;
    public GameObject playerbulletboom;
     
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 5f);
        


    }

    void OnTriggerEnter(Collider other)
    {
        //�浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���



        if (other.tag == "Finish")
        {   //���� ���� ������
            //Ʈ���� PlayerController ������Ʈ ��������

            
            MechColl mechColl = other.GetComponent<MechColl>();

            if (mechColl != null)
            {
                mechColl.Die();

                Instantiate(playerbulletboom, transform.position, transform.rotation);
                
                Destroy(gameObject,0f);
            }
                    //���� PlayerController ������Ʈ�� Die() �޼ҵ� ����

            
            //�������� ���� PlayerController ������Ʈ�� �������� �� �����ߴٸ�
            //if (playerController != null)
            //{
            //���� PlayerController ������Ʈ�� Die() �޼ҵ� ����

            //}

        }
    }

    // Update is called once per frame

}