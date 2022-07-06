package TP1

import java.time.LocalDate
import java.time.Period

open class Categoria (
    var nombre: String,
    var dni: String,
){
    fun getYear(anio: Int, mes: Int, dia: Int): Int {
        return Period.between(
            LocalDate.of(anio, mes, dia),
            LocalDate.now()
        ).years
    }

    fun obtenerCategoria(anio: Int, mes: Int, dia: Int) : String{
        var edad = getYear(anio, mes, dia)

        var nombre = " "

        if(edad in 18..57){
            nombre = "Activo"
        }
        else{
            nombre = "Pasivo"
        }
        return  nombre
    }

    fun actualizar(){
        println("Socios activos:")
        for(dniSocio in listaCategoria){
            for(socio in listaSocio){
                if(dniSocio.dni == socio.dni){
                    obtenerCategoria(socio.anioNacimiento,socio.mesNacimiento,socio.diaNacimiento)
                    if (nombre == "Activo") println(dniSocio.dni)
                }

            }
        }
    }
}

