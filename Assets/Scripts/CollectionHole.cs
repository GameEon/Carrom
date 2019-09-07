using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionHole : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Coins")// || collider.gameObject.tag == "Striker")
        {
            GameManager.Instance.CoinCollected(collider.gameObject);
        }
        if(collider.gameObject.tag == "Striker")
        {
            collider.GetComponent<Striker>().StrikerReset();
            //collider.transform.position = new Vector3(0, -2.553f,0);
        }
    }
}
