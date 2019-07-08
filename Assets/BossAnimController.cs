using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossAnimController : MonoBehaviour
{

    public Animator anim;
    public HitSoundB hitB;
    public HealthController healthController;
    private float delayBeforeLoading = 2.5f;

    private float timeElapsed;

    //private DamageControl damageCon = new DamageControl();

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            BossAttack();
        }
    }

    public void BossAttack()
    {
        anim.Play("AttackB");
        hitB.SoundHitB();
        healthController.DamageToH();
    }

    public void BossDead()
    {
        timeElapsed += Time.deltaTime;
        anim.Play("DeadB");
        anim.SetBool("isDead", true);

        if(timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}