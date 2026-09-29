using UnityEngine;

public class Star : FallingObject
{
    protected override void OnCaught()
    {
        GameManager.Instance.AddScore();
    }
}
