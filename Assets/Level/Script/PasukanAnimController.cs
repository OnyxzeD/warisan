using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasukanAnimController : MonoBehaviour {

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
            PasukanAttack();
        }
    }

    public void PasukanAttack()
    {
        anim.Play("PasukanAttack");
        hitB.SoundHitB();
        healthController.DamageToH();
    }

    public void PasukanDead()
    {
        anim.Play("PasukanDead");
        timeElapsed += Time.deltaTime;
        anim.SetBool("isDead", true);

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
