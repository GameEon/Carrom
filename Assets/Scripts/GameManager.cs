using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
            }

            return _instance;
        }
    }

    public Transform collectedPosition;
    public float offset=0.35f;
    public int numberOfCoinsCollected;
    float strikerForce;
    public int baseStrikerForce = 10;
    public Striker striker;

    public void CoinCollected(GameObject collectedCoin)
    {
        collectedCoin.GetComponent<CircleCollider2D>().isTrigger = true;
        collectedCoin.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        offset = 0.35f * numberOfCoinsCollected;
        collectedCoin.transform.position = new Vector2(collectedPosition.position.x + offset, collectedPosition.position.y);
        numberOfCoinsCollected += 1;
    }

    public float CalculateStrikerForce()
    {
        strikerForce = (int)(baseStrikerForce * UIManager.Instance.powerIndicator.fillAmount);
        return strikerForce;
    }

}
