using UnityEngine;

public class FogZone : MonoBehaviour
{
    [Header("Made by inertia")]

    [SerializeField] string triggerTag;
    [SerializeField] float fogDensity;
    [SerializeField] Color fogColor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTag))
        {
            RenderSettings.fog = true;
            RenderSettings.fogDensity = fogDensity;
            RenderSettings.fogColor = fogColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(triggerTag))
        {
            RenderSettings.fog = false;
        }
    }
}
