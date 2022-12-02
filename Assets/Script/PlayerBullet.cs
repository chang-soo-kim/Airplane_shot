using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 10f;//탄알 이동 속력
    private Rigidbody bulletRigidbody;//이동에 사용할 리지드바디 컴포넌트
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
        //충돌한 상대방 게임 오브젝트가 Player 태그를 가진 경우



        if (other.tag == "Finish")
        {   //상대방 게임 오브젝
            //트에서 PlayerController 컴포넌트 가져오기

            
            MechColl mechColl = other.GetComponent<MechColl>();

            if (mechColl != null)
            {
                mechColl.Die();

                Instantiate(playerbulletboom, transform.position, transform.rotation);
                
                Destroy(gameObject,0f);
            }
                    //상대방 PlayerController 컴포넌트의 Die() 메소드 실행

            
            //상대방으로 부터 PlayerController 컴포넌트를 가져오는 데 성공했다면
            //if (playerController != null)
            //{
            //상대방 PlayerController 컴포넌트의 Die() 메소드 실행

            //}

        }
    }

    // Update is called once per frame

}