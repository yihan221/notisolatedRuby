using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeWord : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI Title;
    [SerializeField] private string title;
    void Start()
    {
        Title.text = title;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
