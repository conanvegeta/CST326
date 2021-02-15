using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private Ball gameBall;
    [SerializeField] private Paddle leftPaddle;
    [SerializeField] private Paddle rightPaddle;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Goal leftGoal;
    [SerializeField] private Goal rightGoal;

    private Rigidbody rb;
    public Vector3 pos;

    void Start()
    {
        setPos();
    }
    //-----------------------------------------------------------------------------
    private void OnTriggerEnter(Collider other)
    {
        //do something interesting to the ball, paddle, or some other game element

        gameBall = other.GetComponent<Ball>();
        if(this.name=="PowerUp")
        {
            if (gameBall) gameBall.changeColor(Color.clear);
            gameBall.speed -=2;
        }

        setPos();
    }

    void setPos()
    {
        pos = new Vector3(5, 0, 0);
        this.transform.position = pos;
    }
}
