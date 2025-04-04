using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class CanvasLoadLevel : MonoBehaviour
{
    public float holdDuration = 1.0f;
    public Image filledCircle;
    private float holdTimer = 0f;
    private bool isHolding = false;

    private void Update()
    {
        if (isHolding)
        {
            holdTimer += Time.deltaTime;
            filledCircle.fillAmount = holdTimer / holdDuration;
            if (holdTimer > holdDuration)
            {
                // Load Next Level
            }
        }
    }

    public void OnHold(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            isHolding = true;
        }
        else if (context.canceled) 
        {
            ResetHold();
        }
    }

    void ResetHold()
    {
        isHolding = false;
        holdTimer = 0f;
        filledCircle.fillAmount = 0f;
    }
}
