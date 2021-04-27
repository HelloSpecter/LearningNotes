using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class xunluotest : MonoBehaviour {
    [SerializeField] Transform m_aim1;
    [SerializeField] Transform m_aim2;
    NavMeshAgent m_agent;
    bool getReady = true;
    List<Transform> aim = new List<Transform>();
    int i = 0;
    Vector3 cur;
    Vector3 last;
    int count = 0;
    // Use this for initialization
    void Start () {
        aim.Add(m_aim1);
        aim.Add(m_aim2);
        m_agent = GetComponent<NavMeshAgent>();
        //cur = aim[0].position;
        //last = aim[1].position;
        //m_agent.stoppingDistance = 5f;
        //m_agent.isStopped = true;
    }

    // Update is called once per frame
    void Update()
    {
        i = i % aim.Count;
        //if (!m_agent.isStopped&&m_agent.remainingDistance<5.0f)
        //{
        //    m_agent.isStopped = true;
        //}
        //if (m_agent.isStopped)
        //    {
        //    m_agent.SetDestination(aim[i].position);
        //    m_agent.isStopped = false;
        //    i = i + 1;
        //    }
        //}
        if (m_agent.remainingDistance < 3f)
        {
            count++;
            if (count==150)
            {
            m_agent.SetDestination(aim[i++].position);
                count = 0;
            }
        }
    }
        
        
	
}
