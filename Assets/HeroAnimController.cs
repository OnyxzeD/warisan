using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HeroAnimController : MonoBehaviour {

    public Animator anim;
    public int HealthB;
    public Text healthTextB;
    //private DamageControl damageCon = new DamageControl();

    // Use this for initialization
    void Start () {
        HealthB = 50;
        UpdateHealth();
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            HeroAttack();
            anim.Play("AttackH");
        }
    }

    public void HeroAttack()
    {
        anim.Play("AttackH");
        HealthB -= 10;
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        healthTextB.text = HealthB.ToString("0");
    }
}
