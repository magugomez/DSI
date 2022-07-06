package TP1

open class Peticion (
    var numero: Int,
    var diaPeticion: Int,
    var mesPeticion: Int,
    var anioPeticion: Int,
    var donantes: Int,
    var diaLimite: Int,
    var mesLimite: Int,
    var anioLimite: Int,
    var tipoSangre: String,
){
    fun mostrarPeticion(){
        println("Peticion numero: ${numero}")
        println("Fecha de peticion: ${diaPeticion}/${mesPeticion}/${anioPeticion}")
        println("Cantidad de donantes solicitados: ${donantes}")
        println("Fecha limite: ${diaLimite}/${mesLimite}/${anioLimite}")
        println("Tipo de sangresolicitada: ${tipoSangre}")
    }
}