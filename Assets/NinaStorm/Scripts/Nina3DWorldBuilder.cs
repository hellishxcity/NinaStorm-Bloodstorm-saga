using UnityEngine;

namespace NinaStorm
{
    /// <summary>
    /// Creates a simple 3D graybox for the first NinaStorm prototype.
    /// Attach to an empty GameObject and enable buildOnStart.
    /// Replace primitives with final art before release.
    /// </summary>
    public class Nina3DWorldBuilder : MonoBehaviour
    {
        public bool buildOnStart = true;
        public bool buildOnPlayOnly = true;
        public int treeCount = 36;
        public int rockCount = 24;
        public int seed = 721;

        private Transform worldRoot;

        private void Start()
        {
            if (buildOnStart) BuildWorld();
        }

        [ContextMenu("Build NinaStorm Graybox World")]
        public void BuildWorld()
        {
            if (Application.isPlaying && !buildOnPlayOnly)
            {
                // Runtime generation is supported in both modes.
            }

            if (worldRoot != null)
            {
                if (Application.isPlaying) Destroy(worldRoot.gameObject);
                else DestroyImmediate(worldRoot.gameObject);
            }

            GameObject root = new GameObject("NinaStorm_GeneratedWorld");
            worldRoot = root.transform;
            worldRoot.SetParent(transform, false);
            Random.InitState(seed);

            Make("Ashen Marches Ground", PrimitiveType.Plane, new Vector3(0, -0.15f, 0), new Vector3(12, 1, 12), new Color(0.19f, 0.22f, 0.20f));
            BuildCastle(new Vector3(0, 0, 24));
            BuildVillage(new Vector3(-24, 0, 4));
            BuildDungeon(new Vector3(23, 0, 13));
            BuildRoad();
            BuildForest();
            BuildMarkers();
            BuildMoonAndLighting();
        }

        private void BuildCastle(Vector3 p)
        {
            Make("Blackthorn Castle Keep", PrimitiveType.Cube, p + new Vector3(0, 4, 0), new Vector3(12, 8, 10), new Color(0.18f, 0.17f, 0.2f));
            Make("Throne Tower", PrimitiveType.Cylinder, p + new Vector3(0, 8, -1), new Vector3(3, 8, 3), new Color(0.12f, 0.11f, 0.14f));
            Make("Gatehouse", PrimitiveType.Cube, p + new Vector3(0, 2, -6), new Vector3(6, 4, 2), new Color(0.13f, 0.12f, 0.15f));
            Make("Crimson Gate", PrimitiveType.Cube, p + new Vector3(0, 1.4f, -7.08f), new Vector3(2.2f, 2.8f, 0.15f), new Color(0.55f, 0.02f, 0.06f));
            for (int i = 0; i < 4; i++)
            {
                float x = (i % 2 == 0 ? -1 : 1) * 6.5f;
                float z = (i < 2 ? -4.5f : 4.5f);
                Make("Castle Watchtower", PrimitiveType.Cylinder, p + new Vector3(x, 3.5f, z), new Vector3(1.8f, 7f, 1.8f), new Color(0.23f, 0.21f, 0.24f));
                Make("Tower Cap", PrimitiveType.Sphere, p + new Vector3(x, 7.4f, z), new Vector3(1.6f, 1.2f, 1.6f), new Color(0.42f, 0.025f, 0.05f));
            }
            for (int i = -2; i <= 2; i++)
                Make("Crimson Banner", PrimitiveType.Cube, p + new Vector3(i * 2.1f, 4.7f, -5.15f), new Vector3(0.8f, 1.6f, 0.12f), new Color(0.6f, 0.015f, 0.06f));
        }

        private void BuildVillage(Vector3 p)
        {
            Make("Village Square", PrimitiveType.Cube, p + new Vector3(0, 0.05f, 0), new Vector3(18, 0.2f, 14), new Color(0.27f, 0.25f, 0.22f));
            for (int i = 0; i < 6; i++)
            {
                Vector3 offset = new Vector3((i % 3) * 5f - 5f, 0, (i / 3) * 6f - 3f);
                Make("Village House", PrimitiveType.Cube, p + offset + new Vector3(0, 1.5f, 0), new Vector3(3.6f, 3f, 3.4f), new Color(0.29f, 0.23f, 0.19f));
                Make("House Roof Block", PrimitiveType.Cube, p + offset + new Vector3(0, 3.3f, 0), new Vector3(4f, 0.45f, 3.8f), new Color(0.16f, 0.13f, 0.13f));
                Make("Warm Window", PrimitiveType.Cube, p + offset + new Vector3(0, 1.9f, -1.73f), new Vector3(0.55f, 0.7f, 0.08f), new Color(0.8f, 0.25f, 0.06f));
            }
        }

        private void BuildDungeon(Vector3 p)
        {
            Make("Veilfall Tunnels Ruin", PrimitiveType.Cube, p + new Vector3(0, 2.5f, 0), new Vector3(10, 5, 8), new Color(0.16f, 0.15f, 0.17f));
            Make("Dungeon Darkness", PrimitiveType.Cube, p + new Vector3(0, 1.5f, -4.08f), new Vector3(3.2f, 3f, 0.1f), Color.black);
            Make("Blood Sigil", PrimitiveType.Cylinder, p + new Vector3(0, 0.1f, -5f), new Vector3(2.4f, 0.08f, 2.4f), new Color(0.65f, 0.015f, 0.04f));
            Make("Dungeon Encounter Marker", PrimitiveType.Sphere, p + new Vector3(0, 1.2f, 0), Vector3.one * 0.9f, new Color(0.8f, 0.02f, 0.05f));
        }

        private void BuildRoad()
        {
            for (int i = 0; i < 8; i++)
                Make("Winding Road Segment", PrimitiveType.Cube, new Vector3(-17 + i * 5f, 0.02f, 13 + Mathf.Sin(i * 0.6f) * 4f), new Vector3(6f, 0.12f, 2.8f), new Color(0.24f, 0.22f, 0.2f));
        }

        private void BuildForest()
        {
            for (int i = 0; i < treeCount; i++)
            {
                Vector3 p = new Vector3(Random.Range(-48f, 48f), 0, Random.Range(-35f, 48f));
                if (Mathf.Abs(p.x) < 13 && p.z > -5 && p.z < 36) continue;
                Make("Ironwood Trunk", PrimitiveType.Cylinder, p + Vector3.up * 2f, new Vector3(0.65f, 4f, 0.65f), new Color(0.18f, 0.12f, 0.09f));
                Make("Ironwood Canopy", PrimitiveType.Sphere, p + Vector3.up * 5.2f, new Vector3(3.6f, 4.2f, 3.6f), new Color(0.09f, 0.17f, 0.12f));
            }
            for (int i = 0; i < rockCount; i++)
            {
                Vector3 p = new Vector3(Random.Range(-50f, 50f), 0, Random.Range(-40f, 50f));
                Make("Marches Rock", PrimitiveType.Sphere, p + Vector3.up * 0.45f, new Vector3(Random.Range(0.7f, 2.2f), Random.Range(0.5f, 1.5f), Random.Range(0.7f, 2f)), new Color(0.28f, 0.28f, 0.29f));
            }
        }

        private void BuildMarkers()
        {
            Make("Story Start - Veilfall Tunnels", PrimitiveType.Cylinder, new Vector3(23, 0.2f, 13), new Vector3(1.3f, 0.12f, 1.3f), new Color(0.8f, 0.02f, 0.05f));
            Make("Free Roam Portal - Red Queendom", PrimitiveType.Cylinder, new Vector3(0, 0.15f, 9), new Vector3(2.1f, 0.12f, 2.1f), new Color(0.55f, 0.02f, 0.15f));
            Make("Hollow Knight Arena", PrimitiveType.Cylinder, new Vector3(31, 0.1f, 24), new Vector3(5f, 0.1f, 5f), new Color(0.22f, 0.06f, 0.08f));
        }

        private void BuildMoonAndLighting()
        {
            GameObject moon = Make("Blood Moon", PrimitiveType.Sphere, new Vector3(0, 42, 65), Vector3.one * 8f, new Color(0.7f, 0.12f, 0.18f));
            Collider c = moon.GetComponent<Collider>();
            if (c != null) Destroy(c);
            Light sun = FindObjectOfType<Light>();
            if (sun == null)
            {
                GameObject lightObject = new GameObject("Moonlit Directional Light");
                lightObject.transform.rotation = Quaternion.Euler(35f, -35f, 0f);
                sun = lightObject.AddComponent<Light>();
                sun.type = LightType.Directional;
                sun.intensity = 0.55f;
                sun.color = new Color(0.62f, 0.68f, 0.9f);
            }
            RenderSettings.ambientLight = new Color(0.13f, 0.14f, 0.22f);
        }

        private GameObject Make(string objectName, PrimitiveType type, Vector3 position, Vector3 scale, Color color)
        {
            GameObject obj = GameObject.CreatePrimitive(type);
            obj.name = objectName;
            obj.transform.SetParent(worldRoot, true);
            obj.transform.position = position;
            obj.transform.localScale = scale;
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                Material material = new Material(Shader.Find("Standard"));
                material.color = color;
                renderer.sharedMaterial = material;
            }
            return obj;
        }
    }
}