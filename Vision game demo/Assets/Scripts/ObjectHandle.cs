using UnityEngine;
using System.Collections.Generic;

[ExecuteInEditMode]
public class ObjectHandle : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        if (target != null)
        {
            if (renderer == null)
            {
                gameObject.AddComponent<MeshRenderer>();
                List<Material> list = new List<Material>();
                Renderer[] rens = target.GetComponentsInChildren<Renderer>();
                foreach (Renderer r in rens)
                    foreach (Material m in r.sharedMaterials)
                        if (!list.Contains(m))
                            list.Add(m);
                renderer.sharedMaterials = list.ToArray();
            }
            target.position = transform.position;
            target.rotation = transform.rotation;
        }
    }
}