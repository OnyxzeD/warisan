using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageControl : MonoBehaviour {

    private int bDamage;
    private int hDamage;
    private HealthController healthCon;
   
    public void BossAttack()
    {
        healthCon.HealthH = healthCon.HealthH - 10;

        healthCon.UpdateHealth();
    }

    public void HeroAttack()
    {
        healthCon.setHealthB(5);
        healthCon.UpdateHealth();
    }

   
}
