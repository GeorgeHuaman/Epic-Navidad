using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerWithAudio : MonoBehaviour
{
    public VideoPlayer player;
    public AudioSource audioSource;

    void Start()
    {
        // Configurar salida de audio
        player.audioOutputMode = VideoAudioOutputMode.AudioSource;
        player.SetTargetAudioSource(0, audioSource);

        // Importante si el video tiene audio
        player.EnableAudioTrack(0, true);

        player.Play();
        audioSource.Play();
    }
}
