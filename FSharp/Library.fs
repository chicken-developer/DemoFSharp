namespace Unity3dClassLibrary

open UnityEngine

type SimpleScript() =
   inherit MonoBehaviour()
   member this.Start() = Debug.Log("F# say hello")
