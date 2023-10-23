using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskMaterial : MonoBehaviour
{
    public Material maskMaterial; // ����ũ�� ������ ��Ƽ����

    private void Start()
    {
        Renderer renderer = GetComponent<Renderer>();

        // ������Ʈ�� ����ũ ��Ƽ���� ����
        renderer.material = maskMaterial;
    }
}

