using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechColl : MonoBehaviour
{
    // Start is called before the first frame update
    public int count;
    
    public bool counton
    {
        get; set;
    }

    public GameObject Mechcollboom;

    public void Start()
    { }
    public void Die()
    {   //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        
        ++count;
        counton = true;
       // Debug.Log(counton);

        if (count == 101)
        {
            
            Instantiate(Mechcollboom, new Vector3(0f, 150f, 350f), transform.rotation);
            Destroy(gameObject, 0f);
            
        }


        //gameManager = FindObjectOfType<GameManger>();

        //gameManager.EndGame();
    }
    public void Update()
    { }
}
