using UnityEngine;
using System.Collections;

public class WaitForSeconds : MonoBehaviour {

    public float timeToWait;
    private float counter;

    // Use this for initialization
    void Start () {
        counter = timeToWait;
    }
	
    // Update is called once per frame
    void Update () {
        counter -= Time.deltaTime;
        if(counter <= 0)
        {
            Destroy(gameObject);
        }
    }
}
