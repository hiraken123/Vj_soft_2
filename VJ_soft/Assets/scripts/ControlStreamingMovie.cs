using UnityEngine;
using System.Collections;

public class ControlStreamingMovie : MonoBehaviour
{
  public MovieTexture movieTexture;

  private static readonly string url = "http://www.unity3d.com/webplayers/Movie/sample.ogg";

  void Start()
  {
    StartCoroutine(LoadMovie());
  }

  void Update()
  {
  }

  IEnumerator LoadMovie()
  {
    WWW www = new WWW(url);
    movieTexture = www.movie;

    while (!movieTexture.isReadyToPlay) {
      yield return null;
    }
		/*
    guiTexture.texture = movieTexture;
    audio.clip = movieTexture.audioClip;
    movieTexture.loop = true; // ループ
    movieTexture.Play();
    audio.Play();
    */
  }
}
