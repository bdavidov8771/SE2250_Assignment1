using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundOne : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject blocker;
    [SerializeField] private GameObject collectible1;
    [SerializeField] private GameObject collectible2;
    [SerializeField] private GameObject collectible3;
    [SerializeField] private GameObject collectible4;
    [SerializeField] private GameObject collectible5;
    [SerializeField] private GameObject collectible6;

    private int count;
    // Start is called before the first frame update
    void Start()
    {
        collectible2.SetActive(false);
        collectible3.SetActive(false);
        collectible4.SetActive(false);
        collectible5.SetActive(false);
        collectible6.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count = player.GetComponent<Player>().count;
        switch (count) {
            case 1:
                collectible2.SetActive(true);
                break;
            case 2:
                collectible3.SetActive(true);
                break;
            case 3:
                collectible4.SetActive(true);
                break;
            case 4:
                collectible5.SetActive(true);
                break;
            case 5:
                collectible6.SetActive(true);
                break;
            case 6:
                blocker.SetActive(false);
                break;


        }
    }
}
