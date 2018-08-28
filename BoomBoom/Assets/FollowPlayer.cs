using UnityEngine;
using UnityEngine.PostProcessing;
public class FollowPlayer : MonoBehaviour {
    public Transform player;
    public Vector3 offset;
	public PostProcessingProfile profile;
	// Update is called once per frame

	void Start()
	{
		DepthOfFieldModel.Settings depthSettings = profile.depthOfField.settings;
		depthSettings.aperture = 3.87f;
		profile.depthOfField.settings = depthSettings;
	}
	void Update () {
		if (player.position.y > 0.5f) {
			transform.position = new Vector3 (player.position.x + offset.x, 2.92f, player.position.z + offset.z);
		} else {
			transform.position = new Vector3 (player.position.x + offset.x, player.position.y + 2.92f, player.position.z + offset.z);

			DepthOfFieldModel.Settings depthSettings = profile.depthOfField.settings;

			if(depthSettings.aperture > 0)
				depthSettings.aperture -= 0.05f;


			profile.depthOfField.settings = depthSettings;
		}

	}
}
