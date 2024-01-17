using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioClip audioClip;
    public GameObject mainScene;
    private AudioVisualizer audioVisualizer;
    private PhysicsController physicsController;
    private ParticleController particleController;

    void Start()
    {
        audioVisualizer = GetComponent<AudioVisualizer>();
        physicsController = GetComponent<PhysicsController>();
        particleController = GetComponent<ParticleController>();

        audioVisualizer.AudioClip = audioClip;
        audioVisualizer.VisualizeAudio();

        physicsController.UpdatePhysics();
        particleController.UpdateParticles();
    }

    void Update()
    {
        audioVisualizer.VisualizeAudio();
        physicsController.UpdatePhysics();
        particleController.UpdateParticles();
    }
}