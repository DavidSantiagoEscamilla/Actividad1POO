from parque import Parque
from atraccion import Atraccion
from guardaparque import Guardaparque

if __name__ == "__main__":
   
    nombre_alumno = "David Santiago Escamilla Castro"
    codigo_alumno = "7502410012"
    print(f"Código: {codigo_alumno} | Nombre: {nombre_alumno}")
    print("******************************")

    
    parque_con_parametros = Parque("Parque Nacional", "Montañas", 500.5)
    guardaparque_con_parametros = Guardaparque("Carlos Ruiz", 10, "Fauna")
    atraccion_con_parametros = Atraccion("Montaña Rusa", "Diversión", 150.0)

    
    parque_por_defecto = Parque()
    guardaparque_por_defecto = Guardaparque()
    atraccion_por_defecto = Atraccion()

    
    parque_por_defecto.nombre = "Parque Urbano"
    parque_por_defecto.ubicacion = "Ciudad"
    parque_por_defecto.superficie = 120.0
    parque_por_defecto.agregar_atraccion(atraccion_por_defecto)
    parque_por_defecto.agregar_guardaparque(guardaparque_por_defecto)

    
    print(parque_con_parametros)
    print(guardaparque_con_parametros)
    print(atraccion_con_parametros)

    print(parque_por_defecto)
    print(guardaparque_por_defecto)
    print(atraccion_por_defecto)
