using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{

    [SerializeField]
    private Slider hpbar;
    // Start is called before the first frame update
    private float maxHP = 100;
    private float curHP = 100;
    MechColl mechcoll;
    void Start()
    {
        hpbar.value = (float) curHP / (float) maxHP;
        mechcoll = GetComponent<MechColl>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
