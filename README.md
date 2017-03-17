# CrytalReport
Primera practica de Crystal Report desde VS


Para que no marque error al cargar el reporte, se requiere cambiar la cadena
<startup><supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/></startup>
del archivo de app.config y sustituirla por la siguiente cadena
<startup useLegacyV2RuntimeActivationPolicy="true"> 
    <supported Runtimeversion="v4.0"/> 
</startup>


No se les olvide señalar al archivo de reporte que se copie en la carpeta de salida.
