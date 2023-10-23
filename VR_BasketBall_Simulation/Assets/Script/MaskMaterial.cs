using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskMaterial : MonoBehaviour
{
    public Material maskMaterial; // 마스크를 적용할 머티리얼

    private void Start()
    {
        Renderer renderer = GetComponent<Renderer>();

        // 오브젝트에 마스크 머티리얼 적용
        renderer.material = maskMaterial;
    }
}

