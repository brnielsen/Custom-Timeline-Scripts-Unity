using AdroitStudios.Prototype;
using UnityEngine;
using UnityEngine.Playables;

namespace TimelineScripts
{
    public class MoveObjectTrackMixer: PlayableBehaviour
    {
        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            Transform objectTransform = playerData as Transform;

            var director = playable.GetGraph().GetResolver() as PlayableDirector;

            int inputCount = playable.GetInputCount();
            for (int i = 0; i < inputCount; i++)
            {
                float inputWeight = playable.GetInputWeight(i);

                if (inputWeight > 0f)
                {
                    if (!director.state.Equals(PlayState.Playing))
                    {
                        return;
                    }
                    ScriptPlayable<MoveObjectBehaviour> inputPlayable = (ScriptPlayable<MoveObjectBehaviour>)playable.GetInput(i);

                    MoveObjectBehaviour input = inputPlayable.GetBehaviour();
                    objectTransform.position = input.NewPosition;
                    objectTransform.rotation = Quaternion.Euler(input.NewRotation);


                }
            }
        }
    }
}