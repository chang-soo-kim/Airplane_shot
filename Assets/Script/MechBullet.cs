using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechBullet : MonoBehaviour
{

    public float speed = 8f;//ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody;//�̵��� ����� ������ٵ� ������Ʈ

    // Start is called before the first frame update
    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = ���ʹ��� * �̵��۷�
        bulletRigidbody.velocity = transform.forward * speed;

        //3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 5f);
    }
    //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    void OnTriggerEnter(Collider other)
    {
        //�浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        if (other.tag == "Player")
        {   //���� ���� ������Ʈ
            //Ʈ���� PlayerController ������Ʈ ��������
            Player player = other.GetComponent<Player>();

            //�������� ���� PlayerController ������Ʈ�� �������� �� �����ߴٸ�
            if (player != null)
            {
                //���� PlayerController ������Ʈ�� Die() �޼ҵ� ����
                player.Die();
            }

        }
    }


    //void Destroy(Object obj, float t);



}
