using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SimpleUIController : MonoBehaviour
{
    [Header("UI References")]
    public TMP_InputField inputField;
    public Button submitButton;
    public TMP_Text resultText;
    public GameObject uiPanel;

    void Start()
    {
        uiPanel.SetActive(false);
        submitButton.onClick.AddListener(HandleSubmit);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && uiPanel.activeSelf)
        {
            HandleSubmit();
        }
    }

    public void ShowUI()
    {
        uiPanel.SetActive(true);
        inputField.text = "";
        resultText.text = "";
        inputField.Select();
    }

    public void HideUI()
    {
        uiPanel.SetActive(false);
    }

    void HandleSubmit()
    {
        string input = inputField.text;
        resultText.text = $"You entered: {input}";
        // Add your custom logic here
    }
}