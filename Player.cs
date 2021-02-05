using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    private Rigidbody rb;
    [HideInInspector]public int count;
    private float movementX;
    private float movementY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetScoreText();
    }

    private void Update()
    {
        if (transform.position.y < -25 || count == 45)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            StartCoroutine(CheckGameOver());
        }
    }
    IEnumerator CheckGameOver() {
        yield return new WaitForSeconds(3);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetScoreText() {
        scoreText.text = "Score: " + count.ToString();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        if (other.CompareTag("Ground_1_Collectibles"))
        {
            count++;
        }
        else if (other.CompareTag("Ground_2_Collectibles"))
        {
            count += 2;
        }
        else if (other.CompareTag("Ground_3_Collectibles"))
        {
            count += 3;
        }
        else {
            count += 3;
        }

        SetScoreText();
    }

}
