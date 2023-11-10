using UnityEngine;

public class Rotation : MonoBehaviour
{
   // public float rotationSpeed = 10f;
    // Start is called before the first frame update
    public GameManager gameManager;
    public GameObject Wheel;
    public float RotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Wheel.transform.Rotate(0,0,RotationSpeed,Space.Self);
        this.RotationSpeed = this.RotationSpeed * 0.96f;
        if(RotationSpeed < 0.0001){
            gameManager.endGame();
        }
    }
}
