using UnityEngine;

public class ComputerInteraction2 : MonoBehaviour
{
    [Header("Visuals")]
    public Material normalMaterial;
    public Material highlightMaterial;
    
    [Header("UI Control")]
    public GameObject passwordCheckUI;
    public FirstPersonMovement fpsMovement;

    private Renderer screenRenderer;

    void Start()
    {
        screenRenderer = GetComponent<Renderer>();
        screenRenderer.material = normalMaterial;
        passwordCheckUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            screenRenderer.material = highlightMaterial;
            StartInteraction();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            screenRenderer.material = normalMaterial;
            EndInteraction();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EndInteraction();
        }
    }

    void StartInteraction()
    {
        passwordCheckUI.SetActive(true);
        fpsMovement.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void EndInteraction()
    {
        passwordCheckUI.SetActive(false);
        fpsMovement.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}