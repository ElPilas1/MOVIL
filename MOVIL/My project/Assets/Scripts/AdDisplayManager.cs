using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class AdDisplayManager : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    public static AdDisplayManager instance;
    public string unityAdsID;//
    public int AndroidID;
    public int AppleID;
    public bool testMode = true;
    private string currentAdID;

    public void OnUnityAdsAdLoaded(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        //throw new System.NotImplementedException();
        //ameManager.Instance.LoadScene();
        SceneManager.LoadScene("Menú");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        if (!Advertisement.isInitialized)
        {
#if UNITY_ANDROID||UNITY_EDITOR||UNITY_STANDALONE_WIN
            Advertisement.Initialize(AndroidID.ToString(), testMode); //TESTMODE SIEMPRE EN TRUE PARA NO DENUNCIAS
            currentAdID=AndroidID.ToString();
#elif UNITY_IOS
          Advertisement.Initialize(AppleId.ToString(), testMod);
            currentAdID=AppleID.ToString();

#endif


        }
    }
    public void ShowAD()
    {
        if(Advertisement.isInitialized)
        {
            Advertisement.Load(AndroidID.ToString(currentAdID));
            Advertisement.Show(AndroidID.ToString(currentAdID));   
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
