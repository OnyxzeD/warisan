using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossAnimController : MonoBehaviour {

    public Animator anim;
    public int HealthH;
    public Text healthTextH;
    //private DamageControl damageCon = new DamageControl();

    // Use this for initialization
    void Start()
    {
        HealthH = 100;
        UpdateHealth();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            BossAttack();
            anim.Play("AttackB");
        }
    }

    public void BossAttack()
    {
        HealthH -= 10;
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        healthTextH.text = HealthH.ToString("0");
    }
}
