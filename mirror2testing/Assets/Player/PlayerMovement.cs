using Mirror;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    [SerializeField] public float moveSpeed = 5f; // Скорость движения игрока
    [SerializeField] private Rigidbody2D rb; // Ссылка на Rigidbody2D

    private Vector2 input; // Вектор движения


    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        // Получаем ввод с клавиатуры
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        // Перемещаем игрока
        rb.MovePosition(rb.position + input * moveSpeed / 100);
    }
}
