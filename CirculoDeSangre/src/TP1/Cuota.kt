package TP1

class Cuota (
    var valor: Int,
){
    fun calcularCuota(nombreCategoria: String): Int {
        if(nombreCategoria == "Activo"){
            valor = 200
            print("El valor de la cuota es de $${valor}")
        }
        else{
            valor = 400
            print("El valor de la cuota es de $${valor}")
        }
        return valor
    }
}
