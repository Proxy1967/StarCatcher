using UnityEngine;

public class Bomb : FallingObject
{
    protected override void OnCaught()
    {
        GameManager.Instance.LoseLife();
    }
}
