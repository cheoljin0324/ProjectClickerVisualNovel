using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Novel : MonoBehaviour
{
    [SerializeField]
    private VisualNovel[] viusalNovelSystem;
    [SerializeField]
    private VideoClip[] videoClips;
    [SerializeField]
    private VideoPlayer videoPlayer;
    [SerializeField]
    private SpriteRenderer backRenderer;
    [SerializeField]
    private Sprite[] backSprite;


   private IEnumerator Start()
    {
        yield return new WaitUntil(() => viusalNovelSystem[0].UpdateDialog());
    }
}
