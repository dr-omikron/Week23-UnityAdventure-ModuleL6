using UnityEngine;

namespace _Archero.Develop.Runtime.Utilities
{
    public class RandomPointGeneratorService
    {
        public Vector3 Generate(Transform center, float maxRadius)
        {
            Vector3 point = new Vector3(Random.Range(-maxRadius, maxRadius), 0, Random.Range(-maxRadius, maxRadius));
            return center.position + point;
        }
    }
}
