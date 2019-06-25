using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAnimController : MonoBehaviour {

    public Animator anim;
    private DamageControl damageCon;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            damageCon.HeroAttack();
            anim.Play("AttackH");
        }
    }
}
