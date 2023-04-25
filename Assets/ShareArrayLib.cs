using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShareArrayLib : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI arrayDisplay;
    [SerializeField] private Button decrementButton;
    [SerializeField] private int arrayLength;

    [DllImport("__Internal")]
    private static extern void setupShareArray(int[] arr, int len);

    public static int[] ShareArray;

    void Start()
    {
        ShareArray = new int[arrayLength];

        setupShareArray(ShareArray, arrayLength);

        decrementButton.onClick.AddListener(() =>
        {
            for(var i = 0; i < ShareArray.Length; i++)
            {
                ShareArray[i]--;
            }
        });
    }

    private void Update()
    {
        if (ShareArray == null) return;
        arrayDisplay.text = string.Join(' ', ShareArray);
    }
}
