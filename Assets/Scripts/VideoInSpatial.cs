using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoInSpatial : MonoBehaviour
{
    public VideoPlayer player;
    public Renderer screenRenderer;

    void Start()
    {
        player.renderMode = VideoRenderMode.MaterialOverride;
        player.targetMaterialRenderer = screenRenderer;
        player.targetMaterialProperty = "_MainTex";
        player.Play();
    }
}
