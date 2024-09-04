using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CubeSelector))]
public class CubeSelector : EditorWindow
{
    public CubeCoordinates _objectcoordinates;
    private int _xValue, _zValue;
    [MenuItem("MyTools/Cube Selector")]
    static void WindowGet()
    {
        GetWindow<CubeSelector>("Cube Selector");
    }
    private void OnGUI()
    {
        _objectcoordinates = (CubeCoordinates)EditorGUILayout.ObjectField("Cube Coordinates", _objectcoordinates, typeof(CubeCoordinates), false);
        //To create buttons
        for (int i = 0; i < 10; i++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int j = 0; j < 10; j++)
            {
                if (GUILayout.Button("X:" + i + " Y:" + j, GUILayout.Width(50), GUILayout.Height(50)))
                {
                    _xValue = i;
                    _zValue = j;
                    _objectcoordinates._xCoordinate = i;
                    _objectcoordinates._zCoordinate = j;
                }
            }
            EditorGUILayout.EndHorizontal();
        }

        GUILayout.Label("Selected" + _xValue + " " + _zValue);
    }
}

