using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTwo : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject blocker;
    public GameObject collectible1;
    [SerializeField] private GameObject collectible2;
    [SerializeField] private GameObject collectible3;
    [SerializeField] private GameObject collectible4;
    [SerializeField] private GameObject collectible5;
    [SerializeField] private GameObject collectible6;

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
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count = player.GetComponent<Player>().count;
        switch (count)
        {
            case 8:
                collectible2.SetActive(true);
                break;
            case 10:
                collectible3.SetActive(true);
                break;
            case 12:
                collectible4.SetActive(true);
                break;
            case 14:
                collectible5.SetActive(true);
                break;
            case 16:
                collectible6.SetActive(true);
                break;
            case 18:
                blocker.SetActive(false);
                break;

        }
    }

        private void OnCollisionEnter(Collision collision)
        {
        if (collision.gameObject.CompareTag("Player") && count == 6) {
            collectible1.SetActive(true);
        }
    }
}
