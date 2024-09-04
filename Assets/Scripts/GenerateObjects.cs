using System.Collections.Generic;
using UnityEngine;

public class GenerateObjects : MonoBehaviour
{
    [SerializeField] private float _length, _width;
    [SerializeField] private GameObject _cube;
    public List<GameObject> _cubesGenerated = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        CubeGeneration();
    }

    //Generate Gameobjects
    void CubeGeneration()
    {
        for (int i = 0; i < _length; i++)
        {
            for (int j = 0; j < _width; j++)
            {
                _cubesGenerated.Add(Instantiate(_cube, new Vector3(i, 0, j), Quaternion.identity));
            }
        }
    }

}
