using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject enemyTank;
    public float timeToSpawn;
    private float counter;
    public float frequency;

    // Use this for initialization
    public void Start()
    {
        counter = timeToSpawn;
    }

    // Update is called once per frame
    public void Update()
    {
        counter -= Time.deltaTime;

        if (counter < 0)
        {
            GameObject ob = (GameObject)Instantiate(enemyTank, transform.position, transform.rotation);

            if(Random.Range(0,101) < frequency)
            {
                ob.GetComponent<EnemyTank>();
            }
            Destroy(gameObject);
        }
    }
}
