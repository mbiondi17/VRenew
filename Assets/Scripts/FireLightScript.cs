using UnityEngine;

public class FireLightScript : MonoBehaviour
{
	public float minIntensity = 0.25f;
	public float maxIntensity = 0.5f;

    //the absolute value of the bounds of randomness added to the light intensity.
    [Range(0.0f, 1.0f)]
    public float randomMagn = 0.3f;
    
	public Light fireLight;

	void Update()
	{
        float randomNoise = Random.Range(1.0f - randomMagn, 1.0f + randomMagn);
        fireLight.GetComponent<Light>().intensity = minIntensity + ((maxIntensity - minIntensity) * Mathf.Abs(Mathf.Sin(Time.time)) * randomNoise);
		//float noise = Mathf.PerlinNoise(random, Time.time);
		//fireLight.GetComponent<Light>().intensity = Mathf.Lerp(minIntensity, maxIntensity, noise/2.0f);

	}
}