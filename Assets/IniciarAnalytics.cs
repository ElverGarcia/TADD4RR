using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;
using UFE3D;


public class IniciarAnalytics : MonoBehaviour
{
    public GlobalInfo data;

    // Start is called before the first frame update
    async void Start()
    {
        Debug.Log(data.aiOptions.engine);
        data.aiOptions.engine = AIEngine.RandomAI;
        await UnityServices.InitializeAsync();
        AnalyticsService.Instance.StartDataCollection();
    }



    // Update is called once per frame
    void Update()
    {
        Debug.Log(data.aiOptions.engine);
    }
}
