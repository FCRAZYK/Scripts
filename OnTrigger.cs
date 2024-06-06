using UnityEngine;
using System.Collections;

public class OnTrigger : MonoBehaviour {

    public void OnTriggerEnter2D( Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("You Entered a Battle Field!!! ");
            GameControl.EnterBattleField();
        }
    }
}
