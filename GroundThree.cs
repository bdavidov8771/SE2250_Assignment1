using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundThree : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject blocker;
    public GameObject collectible1;
    [SerializeField] private GameObject collectible2;
    [SerializeField] private GameObject collectible3;
    [SerializeField] private GameObject collectible4;
    [SerializeField] private GameObject collectible5;
    [SerializeField] private GameObject collectible6;
    [SerializeField] private GameObject collectible7;
    [SerializeField] private GameObject finalCollectible;

    private int count;
    // Start is called before the first frame update
    void Start()
    {
        collectible1.SetActive(false);
        collectible2.SetActive(false);
        collectible3.SetActive(false);
        collectible4.SetActive(false);
        collectible5.SetActive(false);
        collectible6.SetActive(false);
        collectible7.SetActive(false);
        finalCollectible.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count = player.GetComponent<Player>().count;
        switch (count)
        {
            case 21:
                collectible2.SetActive(true);
                break;
            case 24:
                collectible3.SetActive(true);
                break;
            case 27:
                collectible4.SetActive(true);
                break;
            case 30:
                collectible5.SetActive(true);
                break;
            case 33:
                collectible6.SetActive(true);
                break;
            case 36:
                collectible7.SetActive(true);
                break;
            case 39:
                blocker.SetActive(false);
                finalCollectible.SetActive(true);
                break;
            case 45:
                break;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && count == 18)
        {
            collectible1.SetActive(true);
        }
    }

}
