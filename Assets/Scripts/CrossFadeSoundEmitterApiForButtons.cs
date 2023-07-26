using Produktivkeller.SimpleAudioSolution.Emitter;
using UnityEngine;

public class CrossFadeSoundEmitterApiForButtons: MonoBehaviour
{
    [SerializeField] private CrossFadeSoundEmitter crossFadeSoundEmitter;
    
    public void ToFirst()
    {
        crossFadeSoundEmitter.CrossFadeTo(0);
    }

    public void ToSecond()
    {
        crossFadeSoundEmitter.CrossFadeTo(1);
    }
}