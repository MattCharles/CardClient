using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ServerCreator : MonoBehaviour
{
    public GameObject targetList;

    public Button buttonPrefab;
    public TMP_Text TMP_InputField;

    public void Create()
    {
        Button newButton = Instantiate<Button>(buttonPrefab, targetList.transform);
        Debug.Log(TMP_InputField.text.Trim());
        newButton.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = (TMP_InputField.text.Trim());
    }
}
