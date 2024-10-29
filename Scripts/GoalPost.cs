using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPost : MonoBehaviour
{
    public GoalManager goalManager;
    
        private void OnTriggerEnter2D(Collider2D collision)
        {
            BallKicking ballKicking = collision.GetComponent<BallKicking>();
            if (ballKicking != null)
            {
                Debug.Log("goal scored");
                goalManager.ShowGoal();
            }
        }
    
}
