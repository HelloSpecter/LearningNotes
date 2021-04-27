using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatBall : MonoBehaviour {
    [SerializeField] GameObject Perfab_Ball;
    // Use this for initialization
    int Temp = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Temp++;
        if (Temp>150)
        {
            Temp = 0;
        GameObject m_Ball = Instantiate(Perfab_Ball,transform.position,Quaternion.identity);

        }
	}
}
