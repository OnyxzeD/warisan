using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthController : MonoBehaviour {

    public int HealthB;
    public int HealthH;
    public Text healthTextB;
    public Text healthTextH;

    // Use this for initialization

    private void Start()
    {
        UpdateHealth();
    }

    public void setHealthB(int h)
    {
        HealthB = h;
    }

    public void setHealthH(int h)
    {
        HealthB = h;
    }

    public void getHealthB()
    {

    }

    public void getHealthH()
    {

    }

    public void UpdateHealth()
    {
        healthTextB.text = HealthB.ToString("0");
        healthTextH.text = HealthH.ToString("0");
    }
	// Update is called once per frame
	
}
