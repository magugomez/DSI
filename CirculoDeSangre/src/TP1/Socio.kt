package TP1

open class Socio (
    var nombre: String,
    var apellido: String,
    var dni: String,
    var contrasenia: String,
    var diaNacimiento: Int,
    var mesNacimiento: Int,
    var anioNacimiento: Int,
    var domicilio: String,
    var localidad: String,
    var telefono: String,
    var email: String,
    var grupoSanguineo: String,
    var factor: String,
    var enfermedad: Boolean,
    var medicamento: Boolean = false,
){
    fun mostrarSocios(){
        print(nombre)
        println(apellido)
    }

    fun buscarSocios(tipoSangre:String){
        for (dni in listaCategoria){
            if (nombre == "Activo" && tipoSangre == grupoSanguineo){    //agregar condicion de ultima donacion
                println("DNI del socio: $dni")
                println("Nombre: $nombre $apellido")
                println("Tipo de sangre: $factor")
            }
        }
    }
}
