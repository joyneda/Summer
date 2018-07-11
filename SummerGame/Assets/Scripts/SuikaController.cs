using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuikaController : MonoBehaviour
{

    private Rigidbody rb;
    public float direction;
    public float timeout;
    private float timeElapsed;
    public Text pointText;
    private int count;
    public int scoreValue;
    private GameController gameController;
    // Use this for initialization
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeAll;
        timeElapsed = 0.0f;
        count = 0;
       // Counter();

      
    }

    // Update is called once per frame
    void Update()
    {
       
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeout)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("zangeki"))
        {
            Pakkan();
            count = count + 10;
     //       Counter();
        }
    }
    void Pakkan()
    {
        rb.constraints = RigidbodyConstraints.None;
        rb.AddForce(new Vector3(direction, 2, 0), ForceMode.Impulse);
        rb.AddTorque(0, 0, -direction);
    }
   // void Counter(){
     //   pointText.text = " " + count.ToString();
    //}

}