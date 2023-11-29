using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        CaptureInput();
    }

    private void CaptureInput()
    {
        float moveX = Input.GetAxis("Horizontal");
        player.MoveCharacter(moveX);
    }
}
