package TP1

import java.time.LocalDate
import java.time.Period

val listaCategoria = ArrayList<Categoria>()
val listaSocio = ArrayList<Socio>()

fun main(args: Array<String>){

    menu()

}

fun menu(){
    println("Menu principal")
    println("1.Registrar socio")
    println("2.Iniciar sesion")
    println("3.Lista de socios")
    println("4.Lista de socios activos")
    println("5.Registrar peticion")

    print("Opcion: ")
    var opcion = readLine()!!.toInt()

    when(opcion){
        1 -> registro()
        2 -> {
            var socioIniciado = inicioSesion()
        }
        3 -> for (socio in listaSocio){
            socio.mostrarSocios()
        }
        4 -> for(categoria in listaCategoria){
            categoria.actualizar()
        }
        5 -> registrarPeticion()
    }
}

fun registro(){
    print("Nombre: ")
    val nombre = readLine().toString()
    print("Apellido: ")
    val apellido = readLine().toString()
    print("DNI: ")
    val dni = readLine().toString()
    print("Contraseña: ")
    val contrasenia = readLine().toString()
    print("Día de nacimiento: ")
    val diaNacimiento = readLine()!!.toInt()
    print("Mes de nacimiento: ")
    val mesNacimiento = readLine()!!.toInt()
    print("Año de nacimiento: ")
    val anioNacimiento = readLine()!!.toInt()
    print("Domicilio: ")
    val domicilio = readLine().toString()
    print("Localidad: ")
    val localidad = readLine().toString()
    print("Telefono: ")
    val telefono = readLine().toString()
    print("Email: ")
    val email = readLine().toString()
    print("Grupo sanguineo: ")
    val grupoSanguineo = readLine().toString()
    print("Factor: (A, B, AB, 0)")
    val factor = readLine().toString()

    var flag: Int
    do {
        print("¿Posee una enfermedad? (0.no 1.si): ")
        flag = readLine()!!.toInt()
    } while (flag != 0 && flag != 1)

    var enfermedad: Boolean

    if (flag == 1) {
        enfermedad = true
    } else {
        enfermedad = false
    }

    if (enfermedad == true) {
        var flag1: Int
        do {
            print("¿Toma un medicamento diariamente? (0.No 1.Si): ")
            flag1 = readLine()!!.toInt()
        } while (flag1 != 0 && flag1 != 1)

        var medicamento = false

        if (flag1 == 1) {
            medicamento = true
        }
    }

    var socio = Socio(
        nombre = nombre, apellido = apellido, dni = dni, contrasenia = contrasenia, diaNacimiento = diaNacimiento,
        mesNacimiento = mesNacimiento, anioNacimiento = anioNacimiento, domicilio = domicilio,
        localidad = localidad, telefono = telefono, email = email, grupoSanguineo = grupoSanguineo, factor = factor,
        enfermedad = enfermedad
    )

    var categoria = Categoria("",socio.dni)
    categoria.nombre = categoria.obtenerCategoria(anioNacimiento,mesNacimiento,diaNacimiento)

    listaCategoria.add(categoria)
    listaSocio.add(socio)

    menu()

}

fun inicioSesion():String{
    print("DNI: ")
    val dni = readLine().toString()
    var band = 0
    for (socio in listaSocio!!){
        if(dni == socio.dni){
            do{
                print("Contraseña: ")
                val contrasenia = readLine().toString()
                if (socio.contrasenia == contrasenia) {
                    band = 1
                } else {
                    print("Contraseña incorrecta. Volver a ingresarla")
                    band = 2
                }
            }while (band!=1)
        }else {
            println("No se ha encontrado un socio registrado con el DNI $dni")
            return "No se ha encontrado un socio registrado con el DNI $dni"
        }
    }
    print("Sesion iniciada")
    return dni
}

fun registrarPeticion(){
    print("Numero de peticion: ")
    val numero = readLine()!!.toInt()
    println("Dia: ")
    val diaPeticion = readLine()!!.toInt()
    println("Mes: ")
    val mesPeticion = readLine()!!.toInt()
    println("Año: ")
    val anioPeticion = readLine()!!.toInt()
    println("Cantidad de donantes: ")
    val donantes = readLine()!!.toInt()
    println("Dia limite: ")
    val diaLimite = readLine()!!.toInt()
    println("Mes limite: ")
    val mesLimite = readLine()!!.toInt()
    println("Año limite: ")
    val anioLimite = readLine()!!.toInt()
    println("Tipo de sangre (A, B, AB, 0): ")
    val tipoSangre = readLine().toString()

    var peticion = Peticion(
        numero=numero, diaPeticion=diaPeticion, mesPeticion=mesPeticion, anioPeticion=anioPeticion, donantes=donantes,
        diaLimite=diaLimite, mesLimite=mesLimite, anioLimite=anioLimite, tipoSangre=tipoSangre
    )

    println("Peticion registrada")
    peticion.mostrarPeticion()

    for(socio in TP1.listaSocio){
        socio.buscarSocios(tipoSangre)
    }
}