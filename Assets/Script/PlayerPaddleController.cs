using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleController : MonoBehaviour
{
    public float speed = 5f;
    public string movementAxisName = "Vertical";

    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        if (isPlayer)
            spriteRenderer.color = SaveController.Instance.colorPlayer;
        else
            spriteRenderer.color = SaveController.Instance.colorEnemy;
    }

    void Update()
    {
        float moveInput = Input.GetAxis(movementAxisName);
        Vector3 newPosition = transform.position + Vector3.up * moveInput*speed * Time.deltaTime;
        newPosition.y = Mathf.Clamp(newPosition.y, -15f, 15f);
        transform.position = newPosition;

    }


}
  