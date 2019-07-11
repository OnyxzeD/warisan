using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeroAnimController : MonoBehaviour
{

    public Animator anim;
    public HitSoundH hitH;
    public HealthController healthController;
    //private DamageControl damageCon = new DamageControl();

    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            HeroAttack();
        }
    }

    public void HeroAttack()
    {
        anim.Play("AttackH");
        hitH.SoundHitH();
        healthController.DamageToB();
    }

    public void HeroDead()
    {
        anim.Play("HeroDead");
        anim.SetBool("isDead", true);
    }

}