using UnityEngine;

public class Rotation : MonoBehaviour
{
   // public float rotationSpeed = 10f;
    // Start is called before the first frame update
    public GameManager gameManager;
    public GameObject Wheel;
    public bool wheelTriggered = false;
    public float RotationSpeed;
    public float wheelAngle;

    public int winningSegment = -1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && gameManager.gameEnded == false){
            Debug.Log(RotationSpeed);
            RotationSpeed += 0.3f;
            Debug.Log("Space button is pressed");
            wheelTriggered = true;
        }
        if(wheelTriggered == true){
            Wheel.transform.Rotate(0,0,RotationSpeed,Space.Self);
            this.RotationSpeed = this.RotationSpeed * 0.991f;
            if(RotationSpeed < 0.1){
                RotationSpeed = 0;
                wheelAngle = Wheel.transform.eulerAngles.z;
                if(wheelAngle < 0){
                    wheelAngle = wheelAngle + 360;
                }
                Debug.Log(wheelAngle % 360f / 30f);
                Debug.Log(Mathf.RoundToInt(wheelAngle % 360 / 30) + 1);
                winningSegment = Mathf.RoundToInt(wheelAngle % 360 / 30) + 1;
                wheelTriggered = false;
                gameManager.endGame(winningSegment);
            }
        } 
    }
}
