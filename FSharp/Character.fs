namespace Unity3dClassLibrary

open UnityEngine

type CharacterScript() =
   inherit MonoBehaviour()
   member this.Start() = Debug.Log("F# say hello from Maincamera")