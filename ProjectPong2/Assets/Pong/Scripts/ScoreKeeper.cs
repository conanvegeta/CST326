using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private Text leftTextScore;
    [SerializeField] private Text rightTextScore;

    [SerializeField] private Goal leftGoal;
    [SerializeField] private Goal rightGoal;

    [SerializeField] private GameManager gameManager;

    private int leftScore = 0;
    private int rightScore = 0;

    public int MAXSCORE = 11;
    // Start is called before the first frame update
    void Start()
    {
        RefreshScore();
    }

    private void RefreshScore()
    {
        if (leftScore == MAXSCORE || rightScore == MAXSCORE)
        {
            if (leftScore == MAXSCORE) 
                Debug.Log("Left Player wins");
            else Debug.Log("Right Player wins");

            
        }
        else
        {
            float scoreModL = (float)leftScore / MAXSCORE;
            leftTextScore.color = new Color(0, 0, scoreModL);
            
            if (leftScore < MAXSCORE / 2) leftTextScore.color = Color.white;

            float scoreModR = (float)rightScore / MAXSCORE;
            rightTextScore.color = new Color(scoreModR,0,0);
          
            if (rightScore < MAXSCORE / 2) rightTextScore.color = Color.white;
        }
    }
    public bool AddScore(Goal scoringSide)
    {
        if (scoringSide == leftGoal)
        {
            rightScore += 1;
            rightTextScore.text = rightScore.ToString();
        }

        else
        {
            leftScore += 1;
            leftTextScore.text = leftScore.ToString();
        }
        RefreshScore();

        if (leftScore >= MAXSCORE || rightScore >= MAXSCORE) return false;
        else return true;
    }

}
