using UnityEngine;
using System.Collections;

public class MoviePlayer : MonoBehaviour {
    public MovieTexture movie;
    private int playCount = 0;
    public int maxPlayCount = 2;
    void Start () {
        movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
        movie.Play();
        movie.loop = false;

        StartCoroutine(TrackVideo());
    }

    IEnumerator TrackVideo()
    {
        if (!movie.isPlaying)
        {
            movie.loop = true;
            movie.Play();
        }

        yield return new WaitForSeconds(movie.duration);

        if ((maxPlayCount > playCount))
        {
            Debug.Log(playCount);
            playCount++;

            StartCoroutine(TrackVideo());
        }
        else
        {
            Debug.Log("Stop");
            movie.Stop();
        }
    }
}
