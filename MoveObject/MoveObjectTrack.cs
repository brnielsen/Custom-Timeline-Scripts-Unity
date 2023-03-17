using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace TimelineScripts
{
    [TrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(MoveObjectClip))]
    public class MoveObjectTrack : TrackAsset
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return ScriptPlayable<MoveObjectTrackMixer>.Create(graph, inputCount);
        }
    }
}