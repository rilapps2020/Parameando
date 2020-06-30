using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{

	//Sliders
	private float slider;
	private float slider2;
	private float Hour;
	private float Tod;

	//Luces
	public Light sun;

	//Velocidad de cambio
	public int speed;

	//SkyBox
	public Material NightSkyBoxMaterial;
	public Material DaySkyBoxMaterial;

	// ------Colores del cielo ------//

	//Niebla
	public Color NightFogColor;
	public Color DuskFogColor;
	public Color MorningFogColor;
	public Color MiddayFogColor;

	//Ambiente
	public Color NightAmbientLight;
	public Color DuskAmbientLight;
	public Color MorningAmbientLight;
	public Color MiddayAmbientLight;

	//Tinte
	public Color NightTint;
	public Color DuskTint;
	public Color MorningTint;
	public Color MiddayTint;

	//Colores del sol
	public Color SunNight;
	public Color SunDay;

	// ------Colores del cielo ------//

	//Agua
	public GameObject Water;
	public Boolean IncludeWater;
	public Color WaterNight;
	public Color WaterDay;



	// Inicio del ciclo, se empieza de noche
	void Update()
	{
		if (slider >= 1.0f)
		{
			slider = 0;
		}
		Hour = slider * 24;
		Tod = slider * 24;
		sun.transform.localEulerAngles = new Vector3((slider * 360) - 90, 0, 0);
		slider = slider + Time.deltaTime / speed;
		sun.color = Color.Lerp(SunNight, SunDay, slider * 2);

		if (IncludeWater == true)
		{
			Water.GetComponent<Renderer>().material.SetColor(1, Color.blue);
		}

		if (slider < 0.5f)
		{
			slider2 = slider;
		}
		else if (slider > 0.5f)
		{
			slider2 = 1 - slider;
		}

		if (Tod < 4)
		{
			//Noche
			RenderSettings.skybox = NightSkyBoxMaterial;
			RenderSettings.skybox.SetFloat("_Blend", 0);
			RenderSettings.skybox.SetFloat("_Blend", (Tod / 2) - 2);

			NightSkyBoxMaterial.SetColor("_Tint", Color.Lerp(NightTint, DuskTint, (Tod / 2) - 2));
			RenderSettings.ambientLight = Color.Lerp(NightAmbientLight, DuskAmbientLight, (Tod / 2) - 2);
			RenderSettings.fogColor = Color.Lerp(NightFogColor, DuskFogColor, (Tod / 2) - 2);
			//En la oscuridad
		}

		if (Tod > 6 && Tod < 8)
		{
			RenderSettings.skybox = DaySkyBoxMaterial;
			RenderSettings.skybox.SetFloat("_Blend", 0);
			RenderSettings.skybox.SetFloat("_Blend", (Tod / 2) - 3);
			DaySkyBoxMaterial.SetColor("_Tint", Color.Lerp(DuskTint, MorningTint, (Tod / 2) - 3));
			RenderSettings.ambientLight = Color.Lerp(DuskAmbientLight, MorningAmbientLight, (Tod / 2) - 3);
			RenderSettings.fogColor = Color.Lerp(DuskFogColor, MorningFogColor, (Tod / 2) - 3);
			//En la mañana

		}

		if (Tod > 8 && Tod < 10)
		{
			RenderSettings.ambientLight = MiddayAmbientLight;
			RenderSettings.skybox = DaySkyBoxMaterial;
			RenderSettings.skybox.SetFloat("_Blend", 1);
			DaySkyBoxMaterial.SetColor("_Tint", Color.Lerp(MorningTint, MiddayTint, (Tod / 2) - 4));
			RenderSettings.ambientLight = Color.Lerp(MorningAmbientLight, MiddayAmbientLight, (Tod / 2) - 4);
			RenderSettings.fogColor = Color.Lerp(MorningFogColor, MiddayFogColor, (Tod / 2) - 4);

			//Al mediodia

		}
	}
}