using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    public PhysicsSettings physicsSettings;

    private void Start()
    {
        ApplyPhysicsSettings();
    }

    private void ApplyPhysicsSettings()
    {
        Physics.gravity = physicsSettings.gravity;
        Physics.defaultContactOffset = physicsSettings.defaultContactOffset;
    }

    public void UpdatePhysics()
    {
        Physics.Simulate(Time.deltaTime);
    }
}