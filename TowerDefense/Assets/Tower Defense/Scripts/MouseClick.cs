using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {

                BoxCollider bColl = hit.collider as BoxCollider;

                if (bColl != null)
                {
                    if (bColl.gameObject.tag == "Enemy")
                    {
                        bColl.gameObject.GetComponentInParent<Enemy>().ReduceHealth();
                    }
                }
            }
        }
    }
}
