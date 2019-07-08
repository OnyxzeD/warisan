using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour {

    public int HealthH,HealthB;
    public Text healthTextH;
    public Text healthTextB;
    public BossAnimController bossAnimC;

    // Use this for initialization
    void Start () {
        UpdateHealthB();
        UpdateHealthH();
    }
	
	// Update is called once per frame
	void Update () {
        if (HealthB <= 0)
        {
            bossAnimC.BossDead();
        }
	}

    public void DamageToH()
    {
        HealthH -= 10;
        UpdateHealthH();
    }
    public void DamageToB()
    {
        HealthB -= 10;
        UpdateHealthB();
    }

    public void UpdateHealthH()
    {
        healthTextH.text = HealthH.ToString("0");
    }

    public void UpdateHealthB()
    {
        healthTextB.text = HealthB.ToString("0");
    }
}
