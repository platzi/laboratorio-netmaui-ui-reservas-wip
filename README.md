# **Laboratorio .NET MAUI**

A continuación se muestra el resultado esperado de la aplicación  con las correcciones aplicadas.

<p>
<img src="https://github.com/platzi/laboratorio-netmaui-ui-reservas-wip/blob/main/Images/RealEstateAppUI.png" height="440" width="520"/>
</p>

## Descripcion de requerimientos:

- **Pantalla 1**
    
    **Pantalla con defectos actuales:**
    
    <img src="https://github.com/platzi/laboratorio-netmaui-ui-reservas-wip/blob/main/Images/Pantalla1.png" height="540" width="290"/>

    **A continuación se presenta un desglose de los puntos a corregir:**
    
    - La imagen principal no se visualiza correctamente, el equipo desea que se muestre tal cual al diseño final de la App.
    - Los bordes del Frame deben ser redondeados y hacer ovarlaping con la imagen principal. Actualmente no estan de esa manera.
    - Es necesario agregar estilos a las imágenes de bloque "Feature controls".
    - El equipo no a podido agregar los botones superiores. Por tanto, necesitamos que sean agregados los botones de:
        - Featured
        - Like
        - Share
        - Buton inferior de cifras
        
        Y que estos sean agregados como se muestra en la imagen presentada a continuación:
        
        <img src="https://github.com/platzi/laboratorio-netmaui-ui-reservas-wip/blob/main/Images/Pantalla1.1.png" height="240" width="420"/>
        
    - **Recuadro del vendedor**
        - Actualmente no se muestra la foto, por lo que se requiere que se vea como el siguiente diseno:
            
          <img src="https://github.com/platzi/laboratorio-netmaui-ui-reservas-wip/blob/main/Images/Pantalla1.2.png" height="110" width="320"/>
            
        - Además, actualmente tenemos un fondo diferente al deseado y no se muestra el texto de abajo.
    - **Botón de Message**
        - Esta cuadrado, se requiere bordes redondeados.
        - Tiene el texto agregado, sin embargo este no se puede visibilizar, se requiere mostrarlo con color de letras blancas.
        
- **Pantalla 2**
    
    **Pantalla con defectos actuales:**
    
    <img src="https://github.com/platzi/laboratorio-netmaui-ui-reservas-wip/blob/main/Images/Pantalla2.png" height="540" width="290"/>
    
    **A continuación se presenta un desglose de los puntos a corregir:**
    
    **Card de viviendas:**
    
    - Se requiere agregar la información de las tarjetas en una lista que se alimente de la clase Building.  Como se muestra en el siguiente ejemplo:
    
      <img src="https://github.com/platzi/laboratorio-netmaui-ui-reservas-wip/blob/main/Images/Pantalla2.1.png" height="270" width="300"/>
    
    - En la columna donde se indica el texto “Betterhome”, se necesita lo siguiente:
        - La palabra Betterhome debe estar con un color de texto #2a295f.
        - El punto “.” debe de estar en color rojo.
        - Todo esto debe estar estar declarado en un Label único.
    - El icono de la cama y el precio, deben estar alineados como se muestra a continuación:
        
      <img src="https://github.com/platzi/laboratorio-netmaui-ui-reservas-wip/blob/main/Images/Pantalla2.2.png" height="150" width="120"/>
        
        - Debes agregar el estatus de la vivienda, como el ejemplo de Premium mostrado a continuación:
            
        <img src="https://github.com/platzi/laboratorio-netmaui-ui-reservas-wip/blob/main/Images/Pantalla2.3.png" height="100" width="320"/>
            
        - Es necesario agregar estilos a las imágenes de bloque Feature controls.
        
   <p> Esta UI fue inpirado en el diseño <a href="https://dribbble.com/shots/16415832-Real-estate-app" Target="_blank">Real estate app</a> de Dribble.</>
