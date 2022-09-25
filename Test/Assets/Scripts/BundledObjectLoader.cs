using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BundledObjectLoader : MonoBehaviour
{
    string assetName = "Sedan";
    string bundleName = "testbundle";
    private void Start()
    {
        AssetBundle localAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, bundleName));

        if (localAssetBundle == null)
        {
            Debug.LogError("Failed to load AssetBundle!");
            return;
        }

        var a = localAssetBundle.LoadAllAssets();
        foreach (var asset in a)
        {
            Instantiate(asset);
        }
        localAssetBundle.Unload(false);
    }
}
