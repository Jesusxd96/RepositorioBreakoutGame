using System.Collections;
using System.Collections.Generic;
using System.IO;//Permite que unity guarde en memoria de la compu
using System.Runtime.Serialization.Formatters.Binary;//Para guardar los archivos en formato binario por motivos de security
using UnityEngine;

public abstract class PuntajePersistente : ScriptableObject
{
     public void Guardar(string NombreArchivo = null)
    {
        var bf = new BinaryFormatter();
        var file = File.Create(ObtenerRuta(NombreArchivo));
        var json = JsonUtility.ToJson(this);

        bf.Serialize(file, json);
        file.Close();
    }
    public void Cargar(string nombreArchivo = null)
    {
        if (File.Exists(ObtenerRuta(nombreArchivo)))
        {
            var bf = new BinaryFormatter();
            var archivo = File.Open(ObtenerRuta(nombreArchivo), FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(archivo), this);//Se "Convierte" a formato legible
            archivo.Close();
        }
    }
    public string ObtenerRuta(string nombreArchivo = null)
    {
        var nombreArchivoCompleto = string.IsNullOrEmpty(nombreArchivo) ? name : nombreArchivo;
        return string.Format("{0}/{1}.ebac", Application.persistentDataPath, nombreArchivoCompleto);
    }
}
