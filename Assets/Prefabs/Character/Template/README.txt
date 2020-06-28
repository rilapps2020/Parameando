Este prefab(Character) esta compuesto por dos objetos principales:
Camera container:
Es el objeto que hace que la camara tenga un fixed position pues los SDK de google vr hacen que la camara este en la mismo posición que el objeto padre, camera container tiene:
	Main Camera: es la camara principal por donde el usuario ve y contiene:
		GvrReticlePointer: Google Cardboard SDK
		GvrEventSystem: Google Cardboard SDK
		GvrEditorEmulator: Google Cardboard SDK
		TrackCamera: objeto que utiliza Human para saber la posición de la camara y orbitar conforme a ella esto soluciona el problema del committ "Character cardboard VR"
	
	Human: Es el modelo humanoide para hacer una simulación del cuerpo humano dentro de la app y contiene los scripts:
		Animate Player.cs  -  Character = character(ObjetoPrincipal)
		Rotate Player.cs  - Camara = Main Camera
		Tracing - Track Camera = TrackCamera

Adicional este prefab tiene un script llamado Autowalk.cs desarrollado por Jupp Otto

Escrito por Juan Pablo Díaz Correa el 2 de Mayo de 2020