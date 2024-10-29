using UnityEngine;
using TMPro;

public class GoalManager : MonoBehaviour
{
    public TextMeshProUGUI goalCountText;
    public float displayDuration = 2f;

    private int goalCount = 0;             

    private void Start()
    {
        UpdateGoalCountText();             
    }

    public void ShowGoal()
    {
        goalCount++;                       
        UpdateGoalCountText();             
    }

   
    private void UpdateGoalCountText()
    {
        goalCountText.text = "Goals: " + goalCount; 
    }
}
