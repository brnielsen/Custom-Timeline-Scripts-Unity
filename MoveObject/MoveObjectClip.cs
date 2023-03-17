using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace TimelineScripts
{
    public class MoveObjectClip : PlayableAsset
    {
        //public Vector3 NewPosition = Vector3.zero;

       // public Vector3 NewRotation = Vector3.zero;

        public Transform NewTransform;
        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<MoveObjectBehaviour>.Create(graph);

            MoveObjectBehaviour moveObjectBehaviour = playable.GetBehaviour();

            moveObjectBehaviour.NewPosition = NewTransform.position;
            moveObjectBehaviour.NewRotation = NewTransform.rotation.eulerAngles;

            return playable;
        }
    }
}