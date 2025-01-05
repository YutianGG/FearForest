using System.Collections;
using UnityEngine;

public class MiniMapDemo : MonoBehaviour
{
    public MeshRenderer obj1Centered;
    public MeshRenderer obj2;

    public Sprite obj;


    // Start is called before the first frame update
    void Start()
    {
        var minimap = FindObjectOfType<Arikan.MiniMapView>();

        var img = minimap.FollowCentered(obj1Centered.transform);
        img.color = obj1Centered.material.color;

        var img2 = minimap.Follow(obj2.transform, obj);
        img2.color = obj2.material.color;
    }
}
