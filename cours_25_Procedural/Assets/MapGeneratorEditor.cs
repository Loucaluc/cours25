using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(mapGenerator))]
public class MapGeneratorEditor : Editor {

    public override void OnInspectorGUI()
    {
        mapGenerator mapGen = (mapGenerator)target;

        if (DrawDefaultInspector())
        {

            if (mapGen.autoUpdate)
            {
                mapGen.GenerateMap();
            }
        }

        if (GUILayout.Button("Generator"))
        {
            mapGen.GenerateMap();
        }
    }
}
