using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownController : MonoBehaviour {

    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;
    public BossAnimController bac;
    public bool autoAttack = false;

    void Start()
    {
        uiText.text = "10.0";
        //timer = mainTimer;    
    }

    void Update () {
		if(timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");
        }
        else if(timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "10.00";
            timer = 0.0f;
            if (autoAttack) {
                bac.BossAttack();
                Reset();
            }
        }
	}

    public void setAutoAttack(bool s)
    {
        autoAttack = s;
        Reset();
    }
    public void Reset()
    {
        timer = mainTimer;
        canCount = true;
        doOnce = false;
    }
}
