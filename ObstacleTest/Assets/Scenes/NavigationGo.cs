using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationGo : MonoBehaviour {
    GameObject m_tar;
    NavMeshAgent m_agent;
    float m_remain;
	// Use this for initialization
	void Start () {
        m_agent = GetComponent<NavMeshAgent>();
        m_tar = GameObject.FindWithTag("Target");
	}
	
	// Update is called once per frame
	void Update () {
        
        m_agent.SetDestination(m_tar.transform.position);
        m_remain = m_agent.remainingDistance;
        if (m_agent.remainingDistance>0&& m_agent.remainingDistance<1.0f)
        {
            Destroy(gameObject);
        }
    }
}
