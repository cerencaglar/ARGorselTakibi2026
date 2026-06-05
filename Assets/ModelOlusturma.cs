using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ModelOlusturma : MonoBehaviour
{
    public string[] imageNames;
    public GameObject[] prefabs;

    public void ResimDegisimi(ARTrackablesChangedEventArgs<ARTrackedImage> args)
    {
        foreach (var trackedImage in args.added)
        {
            string imageName = trackedImage.referenceImage.name;
            for (int i = 0; i < imageNames.Length; i++)
            {
                if (imageName == imageNames[i])
                {
                    Instantiate(prefabs[i], trackedImage.transform.position, trackedImage.transform.rotation);
                    break;
                }
            }
        }
    }
}
