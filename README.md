# tp-winform-equipo-2A

Datos guardados en archivo de configuracion:
Agregar App.config dentro de solucion principal (tp-winform-equipo-2A) que no se updatea ni se commitea por .gitignore
Ruta: app/TPWinForm_equipo-2A/tp-winform-equipo-2A/App.config
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
	<appSettings>
		<add key="DBConectionData" value="DBCONFIG"/>
	</appSettings>
</configuration>
```

Donde DBCONFIG es el string con la info a usar en la base de datos instanciada (server, database, etc).
