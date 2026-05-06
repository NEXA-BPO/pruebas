# Corrección de Falla

Describe:
- Qué error encontraste
      
    Encontre un error en la comunicicaion entre el microservicio de orderService y el microservicio de userService, debido a que no habia comunicacion bien establecida entre ellos. Pricipalmente por httpClient ya que no podia resolver la dependencia. A su vez hacia falta configurar el url para userService para que concordara la uri del microservicio de orderService.

- Por qué ocurría

  El program.cs solo llamaba a los controllers pero no registraba a HttpClient, debido a eso lanzaba una expecion.

- Cómo lo solucionaste
  
  Remplace el HttpClient por AddHttpClient, lo que me permitio configurar el baseAddress, con ello utilizando IHttpClientFactory dentro del controller logre realizar la peticion correctamente.
