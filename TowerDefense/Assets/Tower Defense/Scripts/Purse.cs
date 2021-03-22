using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purse : MonoBehaviour
{
    public int coinAmount;

    // Start is called before the first frame update
    void Start()
    {
        coinAmount = 0;
    }

    public void IncreaseCoins(string enemyName)
    {
        if (enemyName.Contains("SmallBadGuy"))
        {
            coinAmount += 20;
        }
        else if (enemyName.Contains("BigBadGuy"))
        {
            coinAmount += 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
