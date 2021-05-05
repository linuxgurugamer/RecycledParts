using System;
using UnityEngine;

namespace BDMk22Plugin
{
	public class UVTransformer
	{
		public Mesh mesh;
		public GameObject gameObject;

		Vector2[] origUV;
		Vector2[] modifiedUV;
		public Vector2 textureSize;

		Texture2D texture;


		public UVTransformer(GameObject meshObject)
		{
			gameObject = meshObject;
			mesh = meshObject.GetComponent<MeshFilter>().mesh;

			origUV = new Vector2[mesh.uv.Length];
			modifiedUV = new Vector2[mesh.uv.Length];
			for(int i = 0; i < origUV.Length; i++)
			{
				origUV[i] = mesh.uv[i];	
			}

			Debug.Log ("uv vert count: "+origUV.Length);

			texture = (Texture2D)meshObject.GetComponent<MeshRenderer>().material.mainTexture;
			textureSize = new Vector2((float)texture.width, (float)texture.height);
		}

		public void UpdateUVTransformation(Vector2 initialOffset, float rotation, Vector2 rotationPivot, Vector2 shift)
		{
			for(int i = 0; i < origUV.Length; i++)
			{
				Vector2 textureSpace = Vector2.Scale(origUV[i], textureSize);
				textureSpace += initialOffset;
				textureSpace = Utils.RotateAroundPoint(textureSpace, rotationPivot, rotation);
				textureSpace += shift;

				Vector2 uvSpace = new Vector2(textureSpace.x/textureSize.x, textureSpace.y/textureSize.y);
				modifiedUV[i] = uvSpace;
			}
			mesh.uv = modifiedUV;
		}
	}
}

